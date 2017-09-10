namespace SonicColorsSetEditor
{
    partial class WaitCPKBuildForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitCPKBuildForm));
            this.Label_Status = new System.Windows.Forms.Label();
            this.ProgressBar_Progress = new System.Windows.Forms.ProgressBar();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Segoe UI", 32F);
            this.Label_Status.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Status.Location = new System.Drawing.Point(164, 21);
            this.Label_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(267, 59);
            this.Label_Status.TabIndex = 5;
            this.Label_Status.Text = "Please Wait...";
            // 
            // ProgressBar_Progress
            // 
            this.ProgressBar_Progress.Location = new System.Drawing.Point(12, 96);
            this.ProgressBar_Progress.Name = "ProgressBar_Progress";
            this.ProgressBar_Progress.Size = new System.Drawing.Size(600, 34);
            this.ProgressBar_Progress.TabIndex = 6;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Enabled = false;
            this.Button_Cancel.Location = new System.Drawing.Point(12, 152);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(600, 23);
            this.Button_Cancel.TabIndex = 7;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // WaitCPKBuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 187);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.ProgressBar_Progress);
            this.Controls.Add(this.Label_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WaitCPKBuildForm";
            this.Text = "Building CPK";
            this.Load += new System.EventHandler(this.WaitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.ProgressBar ProgressBar_Progress;
        private System.Windows.Forms.Button Button_Cancel;
    }
}