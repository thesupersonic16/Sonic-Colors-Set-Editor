using HedgeLib;
using HedgeLib.Exceptions;
using HedgeLib.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public partial class SelectStageForm : Form
    {

        // Variables/Constants
        public string FilePath = "";
        public MainForm Form;
        public StageNamesFile StageNames = new StageNamesFile();

        // Constructors
        public SelectStageForm()
        {
            InitializeComponent();
            // Loads the names if the file exists
            if (File.Exists("StageNames.bin"))
                StageNames.Load("StageNames.bin");
            Theme.ApplyDarkThemeToAll(this);
        }

        // Methods
        public SelectStageForm(MainForm form, string filePath) : this()
        {
            Form = form;
            FilePath = filePath;

            foreach (string fileName in 
                Directory.GetFiles(Helpers.CombinePaths(FindSonic_2010_0(filePath), "set")))
            {
                string name = Path.GetFileNameWithoutExtension(fileName);
                string friendlyName = GetFriendlyName(name);

                // Checks if a friendly name exists
                if (friendlyName != name)
                    name += $" ({friendlyName})";

                var lvi = new ListViewItem(name);
                lvi.Tag = Path.GetFileNameWithoutExtension(fileName);
                listView1.Items.Add(lvi);
            }
            Console.WriteLine("Found {0} Files in {1}.", listView1.Items.Count, filePath);
            Theme.ApplyDarkThemeToAll(listView1);
        }

        /// <summary>
        /// Looks for a friendly name for the given file name
        /// </summary>
        /// <param name="orcName">The file name of the orc</param>
        /// <returns>The Friendly name if one exists, orcName if one doesn't exist</returns>
        public string GetFriendlyName(string orcName)
        {
            foreach (var entry in StageNames.Entries)
                if (orcName.Contains(entry.OrcFileName))
                    return entry.FriendlyName;
            return orcName;
        }

        /// <summary>
        /// Attempts to finds the sonic_2010_0 path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>The path to sonic_2010_0</returns>
        public string FindSonic_2010_0(string path)
        {
            // In sonic2010_0
            if (path.EndsWith("sonic2010_0"))
                return path;
            // In sonic2010_0's SubFolders
            if (Directory.GetParent(path).Name == "sonic2010_0")
                return Directory.GetParent(path).FullName;
            // In Game Root
            if (Directory.Exists(Path.Combine(path, "sonic2010_0")))
                return Path.Combine(path, "sonic2010_0");
            return path;
        }

        /// <summary>
        /// Tells SCSE to open the orc file
        /// </summary>
        /// <param name="stageName"></param>
        public void OpenStage(string stageName)
        {
            string path = Helpers.CombinePaths(FilePath, "set", stageName + ".orc");
            Form.OpenSetData(path);
        }

        // GUI Events
        private void Button_Load_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                OpenStage(listView1.SelectedItems[0].Tag as string);
            }
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Button_Load.Enabled = listView1.SelectedItems.Count != 0;
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                OpenStage(listView1.SelectedItems[0].Tag as string);
                Close();
            }
        }

        public class StageNamesFile : FileBase
        {
            public List<Entry> Entries = new List<Entry>();

            public override void Load(Stream fileStream)
            {
                var reader = new ExtendedBinaryReader(fileStream, true);
                string sig = reader.ReadSignature();
                if (sig != "SCSE")
                    throw new InvalidSignatureException("SCSE", sig);
                int entryCount = reader.ReadInt32();
                for (int i = 0; i < entryCount; ++i)
                {
                    var entry = new Entry();
                    entry.OrcFileName  = reader.ReadString();
                    entry.FriendlyName = reader.ReadString();
                    Entries.Add(entry);
                }
            }

            public override void Save(Stream fileStream)
            {
                var writer = new ExtendedBinaryWriter(fileStream, true);
                writer.WriteSignature("SCSE");
                writer.Write(Entries.Count);
                foreach (var entry in Entries)
                {
                    writer.Write(entry.OrcFileName);
                    writer.Write(entry.FriendlyName);
                }
            }

            public class Entry
            {
                // Variables/Constants
                public string OrcFileName = "";
                public string FriendlyName = "";
            }

        }
    }
}
