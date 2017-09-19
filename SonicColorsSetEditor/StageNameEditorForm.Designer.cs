using SonicColorsSetEditor.Properties;

namespace SonicColorsSetEditor
{
    partial class StageNameEditorForm
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
            this.Button_SaveAndQuit = new System.Windows.Forms.Button();
            this.Button_AddEntry = new System.Windows.Forms.Button();
            this.Panel_Entries = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label_Page = new System.Windows.Forms.Label();
            this.Button_PrevPage = new System.Windows.Forms.Button();
            this.Button_NextPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_SaveAndQuit
            // 
            this.Button_SaveAndQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SaveAndQuit.Location = new System.Drawing.Point(12, 609);
            this.Button_SaveAndQuit.Name = "Button_SaveAndQuit";
            this.Button_SaveAndQuit.Size = new System.Drawing.Size(440, 23);
            this.Button_SaveAndQuit.TabIndex = 0;
            this.Button_SaveAndQuit.Text = "Save and Quit";
            this.Button_SaveAndQuit.UseVisualStyleBackColor = true;
            this.Button_SaveAndQuit.Click += new System.EventHandler(this.Button_SaveAndQuit_Click);
            // 
            // Button_AddEntry
            // 
            this.Button_AddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddEntry.Location = new System.Drawing.Point(351, 580);
            this.Button_AddEntry.Name = "Button_AddEntry";
            this.Button_AddEntry.Size = new System.Drawing.Size(101, 23);
            this.Button_AddEntry.TabIndex = 1;
            this.Button_AddEntry.Text = "Add Entry";
            this.Button_AddEntry.UseVisualStyleBackColor = true;
            this.Button_AddEntry.Click += new System.EventHandler(this.Button_AddEntry_Click);
            // 
            // Panel_Entries
            // 
            this.Panel_Entries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Entries.Location = new System.Drawing.Point(12, 55);
            this.Panel_Entries.Name = "Panel_Entries";
            this.Panel_Entries.Size = new System.Drawing.Size(440, 519);
            this.Panel_Entries.TabIndex = 2;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.Label_Title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label_Title.Location = new System.Drawing.Point(115, 5);
            this.Label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(209, 31);
            this.Label_Title.TabIndex = 6;
            this.Label_Title.Text = "StageNames Editor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ORC File Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Friendly Name";
            // 
            // Label_Page
            // 
            this.Label_Page.AutoSize = true;
            this.Label_Page.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Page.Location = new System.Drawing.Point(350, 13);
            this.Label_Page.Name = "Label_Page";
            this.Label_Page.Size = new System.Drawing.Size(87, 26);
            this.Label_Page.TabIndex = 9;
            this.Label_Page.Text = "Page: 0";
            // 
            // Button_PrevPage
            // 
            this.Button_PrevPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_PrevPage.Location = new System.Drawing.Point(12, 580);
            this.Button_PrevPage.Name = "Button_PrevPage";
            this.Button_PrevPage.Size = new System.Drawing.Size(37, 23);
            this.Button_PrevPage.TabIndex = 10;
            this.Button_PrevPage.Text = "<";
            this.Button_PrevPage.UseVisualStyleBackColor = true;
            this.Button_PrevPage.Click += new System.EventHandler(this.Button_PrevPage_Click);
            // 
            // Button_NextPage
            // 
            this.Button_NextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_NextPage.Location = new System.Drawing.Point(55, 580);
            this.Button_NextPage.Name = "Button_NextPage";
            this.Button_NextPage.Size = new System.Drawing.Size(37, 23);
            this.Button_NextPage.TabIndex = 11;
            this.Button_NextPage.Text = ">";
            this.Button_NextPage.UseVisualStyleBackColor = true;
            this.Button_NextPage.Click += new System.EventHandler(this.Button_NextPage_Click);
            // 
            // StageNameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 642);
            this.Controls.Add(this.Button_NextPage);
            this.Controls.Add(this.Button_PrevPage);
            this.Controls.Add(this.Label_Page);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Panel_Entries);
            this.Controls.Add(this.Button_AddEntry);
            this.Controls.Add(this.Button_SaveAndQuit);
            this.DoubleBuffered = true;
            this.Icon = global::SonicColorsSetEditor.Properties.Resources.icon;
            this.MaximumSize = new System.Drawing.Size(480, 2000);
            this.MinimumSize = new System.Drawing.Size(480, 600);
            this.Name = "StageNameEditorForm";
            this.Text = "StageNames Editor";
            this.Load += new System.EventHandler(this.StageNameEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_SaveAndQuit;
        private System.Windows.Forms.Button Button_AddEntry;
        private System.Windows.Forms.Panel Panel_Entries;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_Page;
        private System.Windows.Forms.Button Button_PrevPage;
        private System.Windows.Forms.Button Button_NextPage;
    }
}