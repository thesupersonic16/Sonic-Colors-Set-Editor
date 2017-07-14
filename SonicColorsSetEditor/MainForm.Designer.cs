namespace SonicColorsSetEditor
{
    partial class MainForm
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
            this.Label_Objects = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_OpenExtractedCPK = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_BuildCPK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAndBuildCPK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ExtractCPK = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAndLaunchSC = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadTemplates_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListView_Objects = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericUpDown_ObjectID = new System.Windows.Forms.NumericUpDown();
            this.Button_MainApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListView_CustomData = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBox_ObjectType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_RemoveParam = new System.Windows.Forms.Button();
            this.Button_AddParam = new System.Windows.Forms.Button();
            this.ListView_Param = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupBox_Transform = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_ScaleZ = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_ScaleY = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_ScaleX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Add_Transform = new System.Windows.Forms.Button();
            this.Button_RemoveTransform = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericUpDown_TransIndex = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Roll = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Yaw = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Pitch = new System.Windows.Forms.NumericUpDown();
            this.Button_TransformApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDown_Z = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.Button_AddObject = new System.Windows.Forms.Button();
            this.Button_RemoveObject = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStrip_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.ReloadSetData_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ObjectID)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupBox_Transform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_TransIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_X)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Objects
            // 
            this.Label_Objects.AutoSize = true;
            this.Label_Objects.Location = new System.Drawing.Point(21, 38);
            this.Label_Objects.Name = "Label_Objects";
            this.Label_Objects.Size = new System.Drawing.Size(46, 13);
            this.Label_Objects.TabIndex = 0;
            this.Label_Objects.Text = "Objects:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.ToolStripMenuItem_OpenFile,
            this.ToolStripMenuItem_OpenExtractedCPK,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem_OpenFile
            // 
            this.ToolStripMenuItem_OpenFile.Name = "ToolStripMenuItem_OpenFile";
            this.ToolStripMenuItem_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem_OpenFile.Size = new System.Drawing.Size(254, 22);
            this.ToolStripMenuItem_OpenFile.Text = "Open File";
            this.ToolStripMenuItem_OpenFile.Click += new System.EventHandler(this.ToolStripMenuItem_OpenFile_Click);
            // 
            // ToolStripMenuItem_OpenExtractedCPK
            // 
            this.ToolStripMenuItem_OpenExtractedCPK.Name = "ToolStripMenuItem_OpenExtractedCPK";
            this.ToolStripMenuItem_OpenExtractedCPK.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.ToolStripMenuItem_OpenExtractedCPK.Size = new System.Drawing.Size(254, 22);
            this.ToolStripMenuItem_OpenExtractedCPK.Text = "Open \"sonic2010_0\"";
            this.ToolStripMenuItem_OpenExtractedCPK.Click += new System.EventHandler(this.ToolStripMenuItem_OpenExtractedCPK_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_BuildCPK,
            this.ToolStripMenuItem_SaveAndBuildCPK,
            this.ToolStripMenuItem_ExtractCPK,
            this.ToolStripMenuItem_SaveAndLaunchSC,
            this.ReloadTemplates_ToolStripMenuItem,
            this.ReloadSetData_ToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // ToolStripMenuItem_BuildCPK
            // 
            this.ToolStripMenuItem_BuildCPK.Enabled = false;
            this.ToolStripMenuItem_BuildCPK.Name = "ToolStripMenuItem_BuildCPK";
            this.ToolStripMenuItem_BuildCPK.Size = new System.Drawing.Size(240, 22);
            this.ToolStripMenuItem_BuildCPK.Text = "Build CPK";
            this.ToolStripMenuItem_BuildCPK.Click += new System.EventHandler(this.ToolStripMenuItem_BuildCPK_Click);
            // 
            // ToolStripMenuItem_SaveAndBuildCPK
            // 
            this.ToolStripMenuItem_SaveAndBuildCPK.Enabled = false;
            this.ToolStripMenuItem_SaveAndBuildCPK.Name = "ToolStripMenuItem_SaveAndBuildCPK";
            this.ToolStripMenuItem_SaveAndBuildCPK.Size = new System.Drawing.Size(240, 22);
            this.ToolStripMenuItem_SaveAndBuildCPK.Text = "Save And Build CPK";
            this.ToolStripMenuItem_SaveAndBuildCPK.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAndBuildCPK_Click);
            // 
            // ToolStripMenuItem_ExtractCPK
            // 
            this.ToolStripMenuItem_ExtractCPK.Enabled = false;
            this.ToolStripMenuItem_ExtractCPK.Name = "ToolStripMenuItem_ExtractCPK";
            this.ToolStripMenuItem_ExtractCPK.Size = new System.Drawing.Size(240, 22);
            this.ToolStripMenuItem_ExtractCPK.Text = "Extract CPK";
            this.ToolStripMenuItem_ExtractCPK.Click += new System.EventHandler(this.ToolStripMenuItem_ExtractCPK_Click);
            // 
            // ToolStripMenuItem_SaveAndLaunchSC
            // 
            this.ToolStripMenuItem_SaveAndLaunchSC.Enabled = false;
            this.ToolStripMenuItem_SaveAndLaunchSC.Name = "ToolStripMenuItem_SaveAndLaunchSC";
            this.ToolStripMenuItem_SaveAndLaunchSC.Size = new System.Drawing.Size(240, 22);
            this.ToolStripMenuItem_SaveAndLaunchSC.Text = "Save and Launch SC";
            this.ToolStripMenuItem_SaveAndLaunchSC.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAndLaunchSC_Click);
            // 
            // ReloadTemplates_ToolStripMenuItem
            // 
            this.ReloadTemplates_ToolStripMenuItem.Name = "ReloadTemplates_ToolStripMenuItem";
            this.ReloadTemplates_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.ReloadTemplates_ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.ReloadTemplates_ToolStripMenuItem.Text = "Reload Templates";
            this.ReloadTemplates_ToolStripMenuItem.Click += new System.EventHandler(this.ReloadTemplates_ToolStripMenuItem_Click);
            // 
            // ListView_Objects
            // 
            this.ListView_Objects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListView_Objects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.ListView_Objects.FullRowSelect = true;
            this.ListView_Objects.Location = new System.Drawing.Point(13, 55);
            this.ListView_Objects.MultiSelect = false;
            this.ListView_Objects.Name = "ListView_Objects";
            this.ListView_Objects.ShowGroups = false;
            this.ListView_Objects.Size = new System.Drawing.Size(185, 339);
            this.ListView_Objects.TabIndex = 2;
            this.ListView_Objects.UseCompatibleStateImageBehavior = false;
            this.ListView_Objects.View = System.Windows.Forms.View.Details;
            this.ListView_Objects.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Objects_ItemSelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Object Name";
            this.columnHeader1.Width = 127;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NumericUpDown_ObjectID);
            this.groupBox1.Controls.Add(this.Button_MainApply);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboBox_ObjectType);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.GroupBox_Transform);
            this.groupBox1.Location = new System.Drawing.Point(204, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 391);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Object: (No Object Selected)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Object ID:";
            // 
            // NumericUpDown_ObjectID
            // 
            this.NumericUpDown_ObjectID.Location = new System.Drawing.Point(121, 34);
            this.NumericUpDown_ObjectID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NumericUpDown_ObjectID.Name = "NumericUpDown_ObjectID";
            this.NumericUpDown_ObjectID.Size = new System.Drawing.Size(55, 20);
            this.NumericUpDown_ObjectID.TabIndex = 9;
            // 
            // Button_MainApply
            // 
            this.Button_MainApply.Location = new System.Drawing.Point(182, 32);
            this.Button_MainApply.Name = "Button_MainApply";
            this.Button_MainApply.Size = new System.Drawing.Size(82, 23);
            this.Button_MainApply.TabIndex = 8;
            this.Button_MainApply.Text = "Apply";
            this.Button_MainApply.UseVisualStyleBackColor = true;
            this.Button_MainApply.Click += new System.EventHandler(this.Button_MainApply_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListView_CustomData);
            this.groupBox3.Location = new System.Drawing.Point(279, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 175);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Custom Data";
            // 
            // ListView_CustomData
            // 
            this.ListView_CustomData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_CustomData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.ListView_CustomData.FullRowSelect = true;
            this.ListView_CustomData.Location = new System.Drawing.Point(6, 21);
            this.ListView_CustomData.MultiSelect = false;
            this.ListView_CustomData.Name = "ListView_CustomData";
            this.ListView_CustomData.Size = new System.Drawing.Size(159, 146);
            this.ListView_CustomData.TabIndex = 4;
            this.ListView_CustomData.UseCompatibleStateImageBehavior = false;
            this.ListView_CustomData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Object Type:";
            // 
            // ComboBox_ObjectType
            // 
            this.ComboBox_ObjectType.FormattingEnabled = true;
            this.ComboBox_ObjectType.Location = new System.Drawing.Point(11, 33);
            this.ComboBox_ObjectType.Name = "ComboBox_ObjectType";
            this.ComboBox_ObjectType.Size = new System.Drawing.Size(104, 21);
            this.ComboBox_ObjectType.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.ListView_Param);
            this.groupBox2.Location = new System.Drawing.Point(6, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 322);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.Button_RemoveParam);
            this.panel1.Controls.Add(this.Button_AddParam);
            this.panel1.Location = new System.Drawing.Point(5, 286);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 30);
            this.panel1.TabIndex = 4;
            // 
            // Button_RemoveParam
            // 
            this.Button_RemoveParam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_RemoveParam.Enabled = false;
            this.Button_RemoveParam.Location = new System.Drawing.Point(130, 3);
            this.Button_RemoveParam.Name = "Button_RemoveParam";
            this.Button_RemoveParam.Size = new System.Drawing.Size(123, 23);
            this.Button_RemoveParam.TabIndex = 1;
            this.Button_RemoveParam.Text = "Remove";
            this.Button_RemoveParam.UseVisualStyleBackColor = true;
            this.Button_RemoveParam.Click += new System.EventHandler(this.Button_RemoveParam_Click);
            // 
            // Button_AddParam
            // 
            this.Button_AddParam.Location = new System.Drawing.Point(3, 3);
            this.Button_AddParam.Name = "Button_AddParam";
            this.Button_AddParam.Size = new System.Drawing.Size(121, 23);
            this.Button_AddParam.TabIndex = 0;
            this.Button_AddParam.Text = "Add";
            this.Button_AddParam.UseVisualStyleBackColor = true;
            this.Button_AddParam.Click += new System.EventHandler(this.Button_AddParam_Click);
            // 
            // ListView_Param
            // 
            this.ListView_Param.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView_Param.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.ListView_Param.FullRowSelect = true;
            this.ListView_Param.Location = new System.Drawing.Point(5, 13);
            this.ListView_Param.MultiSelect = false;
            this.ListView_Param.Name = "ListView_Param";
            this.ListView_Param.Size = new System.Drawing.Size(256, 267);
            this.ListView_Param.TabIndex = 3;
            this.ListView_Param.UseCompatibleStateImageBehavior = false;
            this.ListView_Param.View = System.Windows.Forms.View.Details;
            this.ListView_Param.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_Param_ItemSelectionChanged);
            this.ListView_Param.DoubleClick += new System.EventHandler(this.ListView_Param_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 140;
            // 
            // GroupBox_Transform
            // 
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_ScaleZ);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_ScaleY);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_ScaleX);
            this.GroupBox_Transform.Controls.Add(this.label5);
            this.GroupBox_Transform.Controls.Add(this.Button_Add_Transform);
            this.GroupBox_Transform.Controls.Add(this.Button_RemoveTransform);
            this.GroupBox_Transform.Controls.Add(this.label4);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_TransIndex);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_Roll);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_Yaw);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_Pitch);
            this.GroupBox_Transform.Controls.Add(this.Button_TransformApply);
            this.GroupBox_Transform.Controls.Add(this.label2);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_Z);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_Y);
            this.GroupBox_Transform.Controls.Add(this.label1);
            this.GroupBox_Transform.Controls.Add(this.NumericUpDown_X);
            this.GroupBox_Transform.Location = new System.Drawing.Point(279, 17);
            this.GroupBox_Transform.Name = "GroupBox_Transform";
            this.GroupBox_Transform.Size = new System.Drawing.Size(301, 187);
            this.GroupBox_Transform.TabIndex = 1;
            this.GroupBox_Transform.TabStop = false;
            this.GroupBox_Transform.Text = "Transform";
            // 
            // NumericUpDown_ScaleZ
            // 
            this.NumericUpDown_ScaleZ.DecimalPlaces = 4;
            this.NumericUpDown_ScaleZ.Enabled = false;
            this.NumericUpDown_ScaleZ.Location = new System.Drawing.Point(199, 128);
            this.NumericUpDown_ScaleZ.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_ScaleZ.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_ScaleZ.Name = "NumericUpDown_ScaleZ";
            this.NumericUpDown_ScaleZ.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_ScaleZ.TabIndex = 15;
            // 
            // NumericUpDown_ScaleY
            // 
            this.NumericUpDown_ScaleY.DecimalPlaces = 4;
            this.NumericUpDown_ScaleY.Enabled = false;
            this.NumericUpDown_ScaleY.Location = new System.Drawing.Point(104, 128);
            this.NumericUpDown_ScaleY.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_ScaleY.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_ScaleY.Name = "NumericUpDown_ScaleY";
            this.NumericUpDown_ScaleY.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_ScaleY.TabIndex = 14;
            // 
            // NumericUpDown_ScaleX
            // 
            this.NumericUpDown_ScaleX.DecimalPlaces = 4;
            this.NumericUpDown_ScaleX.Enabled = false;
            this.NumericUpDown_ScaleX.Location = new System.Drawing.Point(9, 128);
            this.NumericUpDown_ScaleX.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_ScaleX.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_ScaleX.Name = "NumericUpDown_ScaleX";
            this.NumericUpDown_ScaleX.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_ScaleX.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale (X, Y, Z)";
            // 
            // Button_Add_Transform
            // 
            this.Button_Add_Transform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Add_Transform.Location = new System.Drawing.Point(145, 158);
            this.Button_Add_Transform.Name = "Button_Add_Transform";
            this.Button_Add_Transform.Size = new System.Drawing.Size(41, 23);
            this.Button_Add_Transform.TabIndex = 11;
            this.Button_Add_Transform.Text = "Add";
            this.Button_Add_Transform.UseVisualStyleBackColor = true;
            this.Button_Add_Transform.Click += new System.EventHandler(this.Button_Add_Transform_Click);
            // 
            // Button_RemoveTransform
            // 
            this.Button_RemoveTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RemoveTransform.Enabled = false;
            this.Button_RemoveTransform.Location = new System.Drawing.Point(191, 158);
            this.Button_RemoveTransform.Name = "Button_RemoveTransform";
            this.Button_RemoveTransform.Size = new System.Drawing.Size(55, 23);
            this.Button_RemoveTransform.TabIndex = 10;
            this.Button_RemoveTransform.Text = "Remove";
            this.Button_RemoveTransform.UseVisualStyleBackColor = true;
            this.Button_RemoveTransform.Click += new System.EventHandler(this.Button_RemoveTransform_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transform ID: ";
            // 
            // NumericUpDown_TransIndex
            // 
            this.NumericUpDown_TransIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumericUpDown_TransIndex.Location = new System.Drawing.Point(86, 160);
            this.NumericUpDown_TransIndex.Name = "NumericUpDown_TransIndex";
            this.NumericUpDown_TransIndex.Size = new System.Drawing.Size(53, 20);
            this.NumericUpDown_TransIndex.TabIndex = 8;
            this.NumericUpDown_TransIndex.ValueChanged += new System.EventHandler(this.NumericUpDown_TransIndex_ValueChanged);
            // 
            // NumericUpDown_Roll
            // 
            this.NumericUpDown_Roll.DecimalPlaces = 4;
            this.NumericUpDown_Roll.Location = new System.Drawing.Point(199, 80);
            this.NumericUpDown_Roll.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_Roll.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Roll.Name = "NumericUpDown_Roll";
            this.NumericUpDown_Roll.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_Roll.TabIndex = 7;
            // 
            // NumericUpDown_Yaw
            // 
            this.NumericUpDown_Yaw.DecimalPlaces = 4;
            this.NumericUpDown_Yaw.Location = new System.Drawing.Point(104, 80);
            this.NumericUpDown_Yaw.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_Yaw.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Yaw.Name = "NumericUpDown_Yaw";
            this.NumericUpDown_Yaw.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_Yaw.TabIndex = 6;
            // 
            // NumericUpDown_Pitch
            // 
            this.NumericUpDown_Pitch.DecimalPlaces = 4;
            this.NumericUpDown_Pitch.Location = new System.Drawing.Point(9, 80);
            this.NumericUpDown_Pitch.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_Pitch.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Pitch.Name = "NumericUpDown_Pitch";
            this.NumericUpDown_Pitch.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_Pitch.TabIndex = 5;
            // 
            // Button_TransformApply
            // 
            this.Button_TransformApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TransformApply.Location = new System.Drawing.Point(252, 158);
            this.Button_TransformApply.Name = "Button_TransformApply";
            this.Button_TransformApply.Size = new System.Drawing.Size(43, 23);
            this.Button_TransformApply.TabIndex = 2;
            this.Button_TransformApply.Text = "Apply";
            this.Button_TransformApply.UseVisualStyleBackColor = true;
            this.Button_TransformApply.Click += new System.EventHandler(this.Button_TransformApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rotation (Degrees) (Pitch, Yaw, Roll)";
            // 
            // NumericUpDown_Z
            // 
            this.NumericUpDown_Z.DecimalPlaces = 4;
            this.NumericUpDown_Z.Location = new System.Drawing.Point(199, 35);
            this.NumericUpDown_Z.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_Z.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Z.Name = "NumericUpDown_Z";
            this.NumericUpDown_Z.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_Z.TabIndex = 3;
            // 
            // NumericUpDown_Y
            // 
            this.NumericUpDown_Y.DecimalPlaces = 4;
            this.NumericUpDown_Y.Location = new System.Drawing.Point(104, 35);
            this.NumericUpDown_Y.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_Y.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_Y.Name = "NumericUpDown_Y";
            this.NumericUpDown_Y.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_Y.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position (X, Y, Z)";
            // 
            // NumericUpDown_X
            // 
            this.NumericUpDown_X.DecimalPlaces = 4;
            this.NumericUpDown_X.Location = new System.Drawing.Point(9, 35);
            this.NumericUpDown_X.Maximum = new decimal(new int[] {
            800000,
            0,
            0,
            0});
            this.NumericUpDown_X.Minimum = new decimal(new int[] {
            800000,
            0,
            0,
            -2147483648});
            this.NumericUpDown_X.Name = "NumericUpDown_X";
            this.NumericUpDown_X.Size = new System.Drawing.Size(89, 20);
            this.NumericUpDown_X.TabIndex = 0;
            // 
            // Button_AddObject
            // 
            this.Button_AddObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_AddObject.Location = new System.Drawing.Point(13, 400);
            this.Button_AddObject.Name = "Button_AddObject";
            this.Button_AddObject.Size = new System.Drawing.Size(88, 23);
            this.Button_AddObject.TabIndex = 4;
            this.Button_AddObject.Text = "Add Object";
            this.Button_AddObject.UseVisualStyleBackColor = true;
            this.Button_AddObject.Click += new System.EventHandler(this.Button_AddObject_Click);
            // 
            // Button_RemoveObject
            // 
            this.Button_RemoveObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_RemoveObject.Location = new System.Drawing.Point(107, 400);
            this.Button_RemoveObject.Name = "Button_RemoveObject";
            this.Button_RemoveObject.Size = new System.Drawing.Size(91, 23);
            this.Button_RemoveObject.TabIndex = 5;
            this.Button_RemoveObject.Text = "Remove Object";
            this.Button_RemoveObject.UseVisualStyleBackColor = true;
            this.Button_RemoveObject.Click += new System.EventHandler(this.Button_RemoveObject_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStrip_Label
            // 
            this.ToolStrip_Label.BackColor = System.Drawing.SystemColors.Control;
            this.ToolStrip_Label.Name = "ToolStrip_Label";
            this.ToolStrip_Label.Size = new System.Drawing.Size(0, 17);
            // 
            // ReloadSetData_ToolStripMenuItem
            // 
            this.ReloadSetData_ToolStripMenuItem.Enabled = false;
            this.ReloadSetData_ToolStripMenuItem.Name = "ReloadSetData_ToolStripMenuItem";
            this.ReloadSetData_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReloadSetData_ToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.ReloadSetData_ToolStripMenuItem.Text = "Reload SetData";
            this.ReloadSetData_ToolStripMenuItem.Click += new System.EventHandler(this.ReloadSetData_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Button_RemoveObject);
            this.Controls.Add(this.Button_AddObject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView_Objects);
            this.Controls.Add(this.Label_Objects);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ObjectID)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.GroupBox_Transform.ResumeLayout(false);
            this.GroupBox_Transform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_TransIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_X)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Objects;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenExtractedCPK;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView ListView_Objects;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox GroupBox_Transform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDown_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Z;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Y;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Roll;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Yaw;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Pitch;
        private System.Windows.Forms.Button Button_TransformApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView ListView_Param;
        private System.Windows.Forms.Button Button_AddObject;
        private System.Windows.Forms.Button Button_RemoveObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_ObjectType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_RemoveParam;
        private System.Windows.Forms.Button Button_AddParam;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView ListView_CustomData;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericUpDown_TransIndex;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenFile;
        private System.Windows.Forms.Button Button_MainApply;
        private System.Windows.Forms.Button Button_Add_Transform;
        private System.Windows.Forms.Button Button_RemoveTransform;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ScaleZ;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ScaleY;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ScaleX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_BuildCPK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAndBuildCPK;
        private System.Windows.Forms.ToolStripStatusLabel ToolStrip_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ObjectID;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ExtractCPK;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAndLaunchSC;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem ReloadTemplates_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadSetData_ToolStripMenuItem;
    }
}

