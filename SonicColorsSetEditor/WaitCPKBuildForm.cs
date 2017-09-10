using SonicColorsSetEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicColorsSetEditor
{
    public partial class WaitCPKBuildForm : Form
    {
        public CPKMaker Cpkmaker;
        public int lastPercentage = 0;

        public WaitCPKBuildForm(CPKMaker cpkmaker)
        {
            InitializeComponent();
            Cpkmaker = cpkmaker;
        }

        public void UpdateLabel(string text)
        {
            Label_Status.Text = text;
            Label_Status.Location = new Point(Size.Width / 2 - Label_Status.Size.Width / 2, Label_Status.Location.Y);
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Tick)).Start();
            UpdateLabel("Building CPK");
        }

        private void Tick()
        {
            while (true)
            { 
                // Gets the progress.
                var status = Cpkmaker.Execute();

                if (status == CPKMaker.Status.Error)
                {   // Failed
                    Invoke(new Action(() =>
                    {
                        MessageBox.Show("Failed to build the CPK", MainForm.ProgramName, MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        DialogResult = DialogResult.No;
                    }));
                    break;
                }
                else if (status == CPKMaker.Status.Complete)
                {   // Completed
                    Invoke(new Action(() => DialogResult = DialogResult.Yes));
                    break;
                }

                int percentage = (int)Math.Round(Cpkmaker.GetProgress());
                if (lastPercentage != percentage)
                    Invoke(new Action(() => ProgressBar_Progress.Value = lastPercentage = percentage));
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
