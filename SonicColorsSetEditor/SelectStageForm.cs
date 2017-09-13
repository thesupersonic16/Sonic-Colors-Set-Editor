using HedgeLib;
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
        public string FilePath = "";
        public MainForm Form;

        public SelectStageForm()
        {
            InitializeComponent();
        }

        public SelectStageForm(MainForm form, string filePath) : this()
        {
            Form = form;
            FilePath = filePath;

            foreach (string fileName in 
                Directory.GetFiles(Helpers.CombinePaths(FindSonic_2010_0(filePath), "set")))
            {
                var lvi = new ListViewItem(Path.GetFileNameWithoutExtension(fileName));
                lvi.Tag = Path.GetFileNameWithoutExtension(fileName);
                listView1.Items.Add(lvi);
            }
            Console.WriteLine("Found {0} Files in {1}.", listView1.Items.Count, filePath);
        }

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

        public void OpenStage(string stageName)
        {
            string path = Helpers.CombinePaths(FilePath, "set", stageName + ".orc");
            Form.OpenSetData(path);
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                OpenStage(listView1.SelectedItems[0].Tag as string);
                Close();
            }
        }
    }
}
