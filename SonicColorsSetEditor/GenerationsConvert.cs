using HedgeLib.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace HedgeLib.Sets
{
    public class ColorstoGensSetData : ColorsSetData
    {
        public void GensExportXML(string filePath,
            Dictionary<string, SetObjectType> objectTemplates = null, Dictionary<string, string> ColorstoGensRenamers = null, Dictionary<string, string> ColorstoGensParamMods = null, Dictionary<string, string> ColorstoGensRotateMods = null)
        {
            using (var fileStream = File.OpenWrite(filePath))
            {
                GensExportXML(fileStream, objectTemplates, ColorstoGensRenamers, ColorstoGensParamMods, ColorstoGensRotateMods);
            }
        }

        public void GensExportXML(Stream fileStream,
            Dictionary<string, SetObjectType> objectTemplates = null, Dictionary<string, string> ColorstoGensRenamers = null, Dictionary<string, string> ColorstoGensParamMods = null, Dictionary<string, string> ColorstoGensRotateMods = null)
        {
            //Convert to XML file and save
            var rootElem = new XElement("SetObject");

            foreach (var obj in Objects)
            {
                //Skip objects with no template.
                if (obj.IsTemplateExists == false) continue;

                //Generate Object Element
                var GensObjName = obj.ObjectType;
                //Messy rename to prevent error caused by element name starting with a number.
                foreach (var node in ColorstoGensRenamers)
                {
                    if (GensObjName == node.Value)
                    {
                        GensObjName = node.Key;
                    }
                }

                var objElem = new XElement(GensObjName);

                //Generate CustomData Element
                //Messy use RangeOut value as Range value.
                foreach (var customData in obj.CustomData)
                {
                    if (customData.Key == "RangeOut")
                    {
                        objElem.Add(GenerateParamElementGens(
                            customData.Value, "Range"));
                    }

                }

                //Generate Parameters Element
                var template = objectTemplates?[obj.ObjectType];

                for (int i = 0; i < obj.Parameters.Count; ++i)
                {
                    var name = template?.Parameters[i].Name;
                    //Ignore parameters containing "Unknown"
                    if (!name.Contains("Unknown"))
                    {
                        objElem.Add(GenerateParamElementGens(obj.Parameters[i],
                            template?.Parameters[i].Name));
                    }
                }

                //Generate Transforms Elements
                objElem.Add(GeneratePositionElement(obj.Transform));
                //Apply rotation to objects that need it
                var rotateModifier = new float();
                foreach (var node in ColorstoGensRotateMods)
                {
                    if (obj.ObjectType == node.Key)
                    {
                        rotateModifier = float.Parse(node.Value.ToString());
                        break;
                    }
                }
                objElem.Add(GenerateRotationElement(obj.Transform, obj.ObjectType, rotateModifier));

                //Generate ID Element
                var objIDAttr = new XElement("SetObjectID", obj.ObjectID);
                objElem.Add(objIDAttr);

                ////Generate MultiSet Elements
                if (obj.Children.Length > 0)
                {
                    var multiElem = new XElement("MultiSetParam");

                    for (int i = 0; i < obj.Children.Length; ++i)
                    {
                        var childElem = new XElement("Element");
                        childElem.Add(new XElement("Index", i + 1));
                        childElem.Add(GeneratePositionElement(obj.Children[i]));
                        childElem.Add(GenerateRotationElement(obj.Children[i], obj.ObjectType, rotateModifier));
                        multiElem.Add(childElem);
                    }
                    multiElem.Add(new XElement("BaseLine", 1));
                    multiElem.Add(new XElement("Direction", 0));
                    multiElem.Add(new XElement("Interval", 1));
                    multiElem.Add(new XElement("IntervalBase", 0));
                    multiElem.Add(new XElement("PositionBase", 0));
                    multiElem.Add(new XElement("RotationBase", 0));
                    objElem.Add(multiElem);
                }

                //Add all of this to the XDocument
                rootElem.Add(objElem);
            }

            var xml = new XDocument(rootElem);
            xml.Save(fileStream);

            //Sub-Methods
            XElement GenerateParamElementGens(
                SetObjectParam param, string name)
            {
                var dataType = param.DataType;
                var elem = new XElement((string.IsNullOrEmpty(name)) ?
                    "Parameter" : name);

                if (dataType == typeof(Vector3))
                {
                    //Scale
                    var tempVector3 = new Vector3();
                    tempVector3 = (Vector3)param.Data;
                    tempVector3.X = (tempVector3.X / 10);
                    tempVector3.Y = (tempVector3.Y / 10);
                    tempVector3.Z = (tempVector3.Z / 10);
                    param.Data = tempVector3;

                    Helpers.XMLWriteVector3(elem, (Vector3)param.Data);
                }
                else if (dataType == typeof(Vector4) || dataType == typeof(Quaternion))
                {
                    Helpers.XMLWriteVector4(elem, (Vector4)param.Data);
                }
                else if (dataType == typeof(Single))
                {
                    var singleValue = new Single();
                    singleValue = float.Parse(param.Data.ToString());
                    //Parameter scaling
                    foreach (var node in ColorstoGensParamMods)
                    {
                        if (name.Contains(node.Key))
                        {
                            singleValue = singleValue / float.Parse(node.Value.ToString());
                            break;
                        }
                    }

                    if (Math.Abs(singleValue) < 1)
                    {
                        elem.Value = singleValue.ToString("0.########################"); //Prevent scientific notation
                    }
                    else
                    {
                        elem.Value = singleValue.ToString("#################################.########################"); //Prevent scientific notation
                    }
                }
                else if ((name == "ACameraID") || (name == "BCameraID") || (name == "ALinkObjID") || (name == "BLinkObjID"))
                {
                    var targetIDAttr = new XElement("SetObjectID", param.Data.ToString());
                    elem.Add(targetIDAttr);
                }
                else
                {
                    elem.Value = param.Data.ToString();
                    //Boolean caps
                    if (param.Data.ToString() == "True")
                    {
                        elem.Value = "true";
                    }
                    else if (param.Data.ToString() == "False")
                    {
                        elem.Value = "false";
                    }
                }

                return elem;
            }

            XElement GeneratePositionElement(
                SetObjectTransform transform, string name = "Transform")
            {
                //Convert Position into elements.
                var posElem = new XElement("Position");

                //Scaling
                transform.Position.X = (transform.Position.X / 10);
                transform.Position.Y = (transform.Position.Y / 10);
                transform.Position.Z = (transform.Position.Z / 10);

                Helpers.XMLWriteVector3(posElem, transform.Position);

                //Add elements to new position element and return it.
                return new XElement(posElem);
            }

            XElement GenerateRotationElement(
                SetObjectTransform transform, string name = "Transform", float rotateModifier = 0)
            {
                //Convert Rotation into elements.
                var rotElem = new XElement("Rotation");

                //Rotate objects that need it
                if (rotateModifier != 0)
                {
                    var temp = transform.Rotation.ToEulerAngles();
                    temp.Y = temp.Y + rotateModifier;
                    if ((rotateModifier == 180) || (rotateModifier == -180))
                    {
                        temp.X = temp.X * -1;
                    }
                    else if ((rotateModifier == 90) || (rotateModifier == -90))
                    {
                        var temptemp = temp.X;
                        temp.X = temp.Z;
                        temp.Z = temptemp;

                        if (rotateModifier == 90)
                        {
                            temp.X = temp.X * -1;
                        }
                    }
                    transform.Rotation = new Quaternion(temp);
                }

                Helpers.XMLWriteVector4(rotElem, transform.Rotation);

                //Add elements to new rotation element and return it.
                return new XElement(rotElem);
            }
        }
    }
}
