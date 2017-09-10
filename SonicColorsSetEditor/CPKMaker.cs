using HedgeLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public class CPKMaker
    {
        public static Type CPKMakerType = null;
        public static Type EnumCpkFileModeType = null;
        public static object CPKMakerObject = null;

        public uint DataAlign
        {
            get
            {
                return (uint)CPKMakerType.GetProperty("DataAlign").GetValue(CPKMakerObject);
            }
            set
            {
                CPKMakerType.GetProperty("DataAlign").SetValue(CPKMakerObject, value);
            }
        }

        public CPKMaker()
        {
            // Load DLL
            if (CPKMakerType == null)
            {
                string dllPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "CpkMaker.dll");
                var cpkMaker = Assembly.LoadFile(dllPath);
                CPKMakerType = cpkMaker.GetType("CriCpkMaker.CpkMaker");
                EnumCpkFileModeType = cpkMaker.GetType("CriCpkMaker.CpkMaker+EnumCpkFileMode");
            }
            CPKMakerObject = Activator.CreateInstance(CPKMakerType);
        }

        public void BuildCPK(string inDirectory, string filePath)
        {
            var cpkMaker = CPKMakerObject;
            
            // cpkMaker.CpkFileMode = CriCpkMaker.CpkMaker.EnumCpkFileMode.ModeFilename;
            CPKMakerType.GetProperty("CpkFileMode").SetValue(cpkMaker,
                EnumCpkFileModeType.GetField("ModeFilename").GetValue(null));

            DataAlign = 16;

            // Add Files
            uint id = 0;
            foreach (string path in Directory.GetFiles(inDirectory, "*", SearchOption.AllDirectories))
            {
                string localPath = path;
                string cpkPath = localPath.Replace(inDirectory + @"\", "");

                AddFile(localPath, cpkPath, id++);
            }
            
            StartToBuild(filePath);
        }

        public void BuildCPK(string inDirectory)
        {
            string cpkFileName = new DirectoryInfo(inDirectory).Name + ".cpk";
            string filePath = Helpers.CombinePaths(Directory.GetParent(inDirectory).FullName,
                cpkFileName);

            BuildCPK(inDirectory, filePath);
        }

        public void ExtractCPK(string outDirectoryPath, string inFilePath)
        {
            AnalyzeCpkFile(inFilePath);
            if (!Directory.Exists(outDirectoryPath))
                Directory.CreateDirectory(outDirectoryPath);
            StartToExtract(outDirectoryPath);
            WaitForComplete();
        }

        public string ExtractCPK(string inFilePath)
        {
            string directory = Directory.GetParent(inFilePath).FullName +
                Path.DirectorySeparatorChar +
                Path.GetFileNameWithoutExtension(inFilePath);
            ExtractCPK(directory, inFilePath);
            return directory;
        }

        public bool IsCompleted()
        {
            return Execute() == Status.Complete;
        }

        #region CPKMaker Methods
        public bool AnalyzeCpkFile(string filePath)
        {
            // cpkMaker.AnalyzeCpkFile(filePath);
            var method = CPKMakerType.GetMethod("AnalyzeCpkFile", new[] { typeof(string) });
            return (bool)method.Invoke(CPKMakerObject, new object[] { filePath });
        }

        public void StartToExtract(string filePath)
        {
            // cpkMaker.StartToExtract(filePath);
            var method = CPKMakerType.GetMethod("StartToExtract", new[] { typeof(string) });
            method.Invoke(CPKMakerObject, new object[] { filePath });
        }

        public void StartToBuild(string filePath)
        {
            // cpkMaker.StartToBuild(filePath);
            var method = CPKMakerType.GetMethod("StartToBuild", new[] { typeof(string) });
            method.Invoke(CPKMakerObject, new object[] { filePath });
        }

        /// <summary>
        /// NOTE: This returns a void not a CFileInfo
        /// </summary>
        public void AddFile(string localFilePath, string cpkFilePath, uint ID)
        {
            // cpkMaker.AddFile(localFilePath, cpkFilePath, ID);
            var method = CPKMakerType.GetMethod("AddFile", new[] { typeof(string), typeof(string), typeof(uint) });
            method.Invoke(CPKMakerObject, new object[] { localFilePath, cpkFilePath, ID });
        }

        public bool WaitForComplete()
        {
            // cpkMaker.WaitForComplete();
            var method = CPKMakerType.GetMethod("WaitForComplete");
            return (bool)method.Invoke(CPKMakerObject, new object[0]);
        }

        public Status Execute()
        {
            // cpkMaker.Execute();
            var method = CPKMakerType.GetMethod("Execute");
            return (Status)method.Invoke(CPKMakerObject, new object[0]);
        }

        public double GetProgress()
        {
            // cpkMaker.GetProgress();
            var method = CPKMakerType.GetMethod("GetProgress");
            return (double)method.Invoke(CPKMakerObject, new object[0]);
        }

        #endregion CPKMaker Methods

        public enum Status
        {
            Stop,
            Verified = 202,
            Verifying = 201,
            VerifyPreparing = 200,
            Extracted = 102,
            Extracting = 101,
            ExtractPreparing = 100,
            Complete = 50,
            CpkBuildFinalize = 17,
            MselfRewriting = 16,
            HeaderRewriting = 15,
            EtocBuilding = 14,
            GtocBuilding = 13,
            ItocBuilding = 12,
            TocBuilding = 11,
            PreTocBuilding = 10,
            GtocInfoMaking = 9,
            Error = -1,
            ItocInfoMaking = 8,
            TocInfoMaking = 7,
            FileDataBuildingCopying = 6,
            FileDataBuildingStart = 5,
            FileDataBuildingPrep = 4,
            PreFileDataBuilding = 3,
            HeaderSkipping = 2,
            HeaderMselfSkipping = 1
        }

    }
}
