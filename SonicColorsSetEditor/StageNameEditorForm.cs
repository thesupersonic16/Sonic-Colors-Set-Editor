using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public partial class StageNameEditorForm : Form
    {
        // Variables/Constants
        public SelectStageForm.StageNamesFile StageNamesFile = 
            new SelectStageForm.StageNamesFile();

        public int Page = 0;
        public int EntriesPerPage = 20;

        // Constructors
        public StageNameEditorForm()
        {
            InitializeComponent();
        }

        // Methods
        public void UpdateData()
        {
            Panel_Entries.SuspendLayout();
            Panel_Entries.Controls.Clear();
            int y = 10;
            int index = 0;
            foreach (var entry in StageNamesFile.Entries)
            {
                index++;
                // Checks if entries are in range
                if (index > Page * EntriesPerPage && index < (Page + 1) * EntriesPerPage)
                {
                    var panel = new Panel();
                    var TextBox_OrcName = new TextBox();
                    var TextBox_FriendlyName = new TextBox();
                    var Button_Remove = new Button();
                    TextBox_OrcName.Size = new Size(150, 25);
                    TextBox_OrcName.Location = new Point(0, 0);
                    TextBox_OrcName.Text = entry.OrcFileName;
                    TextBox_OrcName.TextChanged += TextBox_OrcName_TextChanged;
                    TextBox_FriendlyName.Size = new Size(175, 25);
                    TextBox_FriendlyName.Location = new Point(160, 0);
                    TextBox_FriendlyName.Text = entry.FriendlyName;
                    TextBox_FriendlyName.TextChanged += TextBox_FriendlyName_TextChanged;
                    Button_Remove.Size = new Size(64, 21);
                    Button_Remove.Location = new Point(345, 0);
                    Button_Remove.Text = "Remove";
                    Button_Remove.Click += Button_Remove_Click;
                    panel.Size = new Size(Panel_Entries.Width - 20, 26);
                    panel.Location = new Point(10, y);
                    panel.Tag = entry;
                    panel.Controls.Add(TextBox_OrcName);
                    panel.Controls.Add(TextBox_FriendlyName);
                    panel.Controls.Add(Button_Remove);
                    Panel_Entries.Controls.Add(panel);
                    y += 26;
                }
            }
            Label_Page.Text = "Page: " + Page;
            Theme.ApplyDarkThemeToAll(this);
            Panel_Entries.ResumeLayout();
        }

        // GUI Events
        private void TextBox_OrcName_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var entry = textbox.Parent.Tag as SelectStageForm.StageNamesFile.Entry;
            entry.OrcFileName = textbox.Text;
        }

        private void TextBox_FriendlyName_TextChanged(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            var entry = textbox.Parent.Tag as SelectStageForm.StageNamesFile.Entry;
            entry.FriendlyName = textbox.Text;
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            var panel = ((Control)sender).Parent as Panel;
            var entry = panel.Tag as SelectStageForm.StageNamesFile.Entry;
            StageNamesFile.Entries.Remove(entry);
            UpdateData();
        }

        private void StageNameEditorForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("StageNames.bin"))
                StageNamesFile.Load("StageNames.bin");
            UpdateData();
        }

        private void Button_SaveAndQuit_Click(object sender, EventArgs e)
        {
            StageNamesFile.Save("StageNames.bin", true);
            DialogResult = DialogResult.OK;
        }

        private void Button_AddEntry_Click(object sender, EventArgs e)
        {
            StageNamesFile.Entries.Add(new SelectStageForm.StageNamesFile.Entry());
            UpdateData();
        }

        private void Button_PrevPage_Click(object sender, EventArgs e)
        {
            if (Page > 0)
                Page--;
            UpdateData();
        }

        private void Button_NextPage_Click(object sender, EventArgs e)
        {
            Page++;
            UpdateData();
        }

    }
}
