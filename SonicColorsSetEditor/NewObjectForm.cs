using HedgeLib.Sets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public partial class NewObjectForm : Form
    {
        public MainForm Form;

        public NewObjectForm()
        {
            InitializeComponent();
        }

        public NewObjectForm(MainForm form) : this()
        {
            Form = form;
            foreach (string objName in Form.TemplatesColors.Keys)
                comboBox1.Items.Add(objName);
            comboBox1.SelectedIndex = 0;
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.HasFlag(DialogResult.OK))
                {

                    // Creates a new SetObjectType
                    if (!Form.TemplatesColors.ContainsKey(comboBox1.Text))
                        Form.TemplatesColors.Add(comboBox1.Text, new SetObjectType());

                    var setObject = new SetObject(
                        Form.TemplatesColors[comboBox1.Text], comboBox1.Text, GenerateID(Form.SetData));
                    MainForm.WriteDefaultCustomData(setObject);
                    Form.SetData.Objects.Add(setObject);
                }
            }
            catch { }
        }

        public static uint GenerateID(SetData setData)
        {
            bool taken = false;
            for(uint i = 0; i < setData.Objects.Count; ++i)
            {
                taken = false;
                foreach (var obj in setData.Objects)
                    if (obj.ObjectID == i) taken = true;
                if (!taken)
                    return i;
            }
            return (uint)setData.Objects.Count;
        }
    }
}
