namespace PegasusExportPlugin
{
    partial class frmPegasusExport
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
            this.btnExport = new System.Windows.Forms.Button();
            this.fbdExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chkMetaData = new System.Windows.Forms.CheckBox();
            this.chkApplication = new System.Windows.Forms.CheckBox();
            this.chkAssets = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.lbImagePriority = new System.Windows.Forms.ListBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.radChoose = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpExternalMedia = new System.Windows.Forms.GroupBox();
            this.txtMediaPath = new System.Windows.Forms.MaskedTextBox();
            this.chkUseExternalMedia = new System.Windows.Forms.CheckBox();
            this.btnBrowseExternalMedia = new System.Windows.Forms.Button();
            this.gbAssetPath = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radAssetsBackslashWindows = new System.Windows.Forms.RadioButton();
            this.radAssetsBackslashLinux = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radAbsoluteAssets = new System.Windows.Forms.RadioButton();
            this.radLinkAssets = new System.Windows.Forms.RadioButton();
            this.radCopyAssets = new System.Windows.Forms.RadioButton();
            this.clbAssetList = new System.Windows.Forms.CheckedListBox();
            this.radAutoChoose = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSingleExport = new System.Windows.Forms.CheckBox();
            this.dgvPlatforms = new System.Windows.Forms.DataGridView();
            this.colSelected = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.colPlatform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMetaData = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAssets = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colApplication = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvPlaylists = new System.Windows.Forms.DataGridView();
            this.colSelected2 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gbApplicationPath = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.radApplicationBackslashWindows = new System.Windows.Forms.RadioButton();
            this.radApplicationBackslashLinux = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radAbsoluteApplication = new System.Windows.Forms.RadioButton();
            this.radLinkApplication = new System.Windows.Forms.RadioButton();
            this.radCopyApplication = new System.Windows.Forms.RadioButton();
            this.txtExportPath = new System.Windows.Forms.MaskedTextBox();
            this.fdbExportExternalMedia = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridViewHeaderCheckBoxColumn1 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewHeaderCheckBoxColumn2 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSelected21 = new PegasusExportPlugin.Controls.DataGridViewHeaderCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpExternalMedia.SuspendLayout();
            this.gbAssetPath.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.gbApplicationPath.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(12, 748);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(775, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "&Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Export Folder:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(712, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 719);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(775, 23);
            this.progressBar.TabIndex = 4;
            // 
            // chkMetaData
            // 
            this.chkMetaData.AutoSize = true;
            this.chkMetaData.Checked = true;
            this.chkMetaData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMetaData.Location = new System.Drawing.Point(6, 19);
            this.chkMetaData.Name = "chkMetaData";
            this.chkMetaData.Size = new System.Drawing.Size(104, 17);
            this.chkMetaData.TabIndex = 5;
            this.chkMetaData.Text = "Export Metadata";
            this.chkMetaData.UseVisualStyleBackColor = true;
            // 
            // chkApplication
            // 
            this.chkApplication.AutoSize = true;
            this.chkApplication.Checked = true;
            this.chkApplication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplication.Location = new System.Drawing.Point(212, 19);
            this.chkApplication.Name = "chkApplication";
            this.chkApplication.Size = new System.Drawing.Size(111, 17);
            this.chkApplication.TabIndex = 6;
            this.chkApplication.Text = "Export Application";
            this.chkApplication.UseVisualStyleBackColor = true;
            // 
            // chkAssets
            // 
            this.chkAssets.AutoSize = true;
            this.chkAssets.Checked = true;
            this.chkAssets.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAssets.Location = new System.Drawing.Point(116, 19);
            this.chkAssets.Name = "chkAssets";
            this.chkAssets.Size = new System.Drawing.Size(90, 17);
            this.chkAssets.TabIndex = 7;
            this.chkAssets.Text = "Export Assets";
            this.chkAssets.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.lbImagePriority);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Location = new System.Drawing.Point(438, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 314);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Art Priority";
            // 
            // btnUp
            // 
            this.btnUp.Enabled = false;
            this.btnUp.Location = new System.Drawing.Point(140, 19);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 23);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // lbImagePriority
            // 
            this.lbImagePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbImagePriority.Enabled = false;
            this.lbImagePriority.FormattingEnabled = true;
            this.lbImagePriority.Items.AddRange(new object[] {
            "Aspect Ratio (MODE)",
            "Smaller File Size",
            "Lossless",
            "Larger File Size"});
            this.lbImagePriority.Location = new System.Drawing.Point(12, 48);
            this.lbImagePriority.Name = "lbImagePriority";
            this.lbImagePriority.Size = new System.Drawing.Size(188, 238);
            this.lbImagePriority.TabIndex = 10;
            // 
            // btnDown
            // 
            this.btnDown.Enabled = false;
            this.btnDown.Location = new System.Drawing.Point(173, 19);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(27, 23);
            this.btnDown.TabIndex = 11;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // radChoose
            // 
            this.radChoose.AutoSize = true;
            this.radChoose.Enabled = false;
            this.radChoose.Location = new System.Drawing.Point(8, 42);
            this.radChoose.Name = "radChoose";
            this.radChoose.Size = new System.Drawing.Size(95, 17);
            this.radChoose.TabIndex = 10;
            this.radChoose.Text = "Let me choose";
            this.radChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.grpExternalMedia);
            this.groupBox2.Controls.Add(this.gbAssetPath);
            this.groupBox2.Controls.Add(this.radLinkAssets);
            this.groupBox2.Controls.Add(this.radCopyAssets);
            this.groupBox2.Controls.Add(this.clbAssetList);
            this.groupBox2.Location = new System.Drawing.Point(9, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 314);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asset Export";
            // 
            // grpExternalMedia
            // 
            this.grpExternalMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExternalMedia.Controls.Add(this.txtMediaPath);
            this.grpExternalMedia.Controls.Add(this.chkUseExternalMedia);
            this.grpExternalMedia.Controls.Add(this.btnBrowseExternalMedia);
            this.grpExternalMedia.Location = new System.Drawing.Point(6, 217);
            this.grpExternalMedia.Name = "grpExternalMedia";
            this.grpExternalMedia.Size = new System.Drawing.Size(278, 78);
            this.grpExternalMedia.TabIndex = 18;
            this.grpExternalMedia.TabStop = false;
            this.grpExternalMedia.Text = "External media";
            // 
            // txtMediaPath
            // 
            this.txtMediaPath.BackColor = System.Drawing.SystemColors.Control;
            this.txtMediaPath.Enabled = false;
            this.txtMediaPath.Location = new System.Drawing.Point(5, 48);
            this.txtMediaPath.Name = "txtMediaPath";
            this.txtMediaPath.Size = new System.Drawing.Size(270, 20);
            this.txtMediaPath.TabIndex = 20;
            // 
            // chkUseExternalMedia
            // 
            this.chkUseExternalMedia.AutoSize = true;
            this.chkUseExternalMedia.Location = new System.Drawing.Point(6, 23);
            this.chkUseExternalMedia.Name = "chkUseExternalMedia";
            this.chkUseExternalMedia.Size = new System.Drawing.Size(118, 17);
            this.chkUseExternalMedia.TabIndex = 19;
            this.chkUseExternalMedia.Text = "Use External Media";
            this.chkUseExternalMedia.UseVisualStyleBackColor = true;
            this.chkUseExternalMedia.CheckedChanged += new System.EventHandler(this.chkUseExternalMedia_CheckedChanged);
            // 
            // btnBrowseExternalMedia
            // 
            this.btnBrowseExternalMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExternalMedia.Enabled = false;
            this.btnBrowseExternalMedia.Location = new System.Drawing.Point(197, 19);
            this.btnBrowseExternalMedia.Name = "btnBrowseExternalMedia";
            this.btnBrowseExternalMedia.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExternalMedia.TabIndex = 18;
            this.btnBrowseExternalMedia.Text = "&Browse";
            this.btnBrowseExternalMedia.UseVisualStyleBackColor = true;
            this.btnBrowseExternalMedia.Click += new System.EventHandler(this.btnBrowseExternalMedia_Click);
            // 
            // gbAssetPath
            // 
            this.gbAssetPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAssetPath.Controls.Add(this.groupBox9);
            this.gbAssetPath.Controls.Add(this.radioButton3);
            this.gbAssetPath.Controls.Add(this.radAbsoluteAssets);
            this.gbAssetPath.Location = new System.Drawing.Point(177, 62);
            this.gbAssetPath.Name = "gbAssetPath";
            this.gbAssetPath.Size = new System.Drawing.Size(107, 145);
            this.gbAssetPath.TabIndex = 6;
            this.gbAssetPath.TabStop = false;
            this.gbAssetPath.Text = "Path";
            // 
            // groupBox9
            // 
            this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox9.Controls.Add(this.radAssetsBackslashWindows);
            this.groupBox9.Controls.Add(this.radAssetsBackslashLinux);
            this.groupBox9.Location = new System.Drawing.Point(7, 65);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(94, 74);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Backslash";
            // 
            // radAssetsBackslashWindows
            // 
            this.radAssetsBackslashWindows.AutoSize = true;
            this.radAssetsBackslashWindows.Checked = true;
            this.radAssetsBackslashWindows.Enabled = false;
            this.radAssetsBackslashWindows.Location = new System.Drawing.Point(8, 19);
            this.radAssetsBackslashWindows.Name = "radAssetsBackslashWindows";
            this.radAssetsBackslashWindows.Size = new System.Drawing.Size(69, 17);
            this.radAssetsBackslashWindows.TabIndex = 13;
            this.radAssetsBackslashWindows.TabStop = true;
            this.radAssetsBackslashWindows.Text = "Windows";
            this.radAssetsBackslashWindows.UseVisualStyleBackColor = true;
            // 
            // radAssetsBackslashLinux
            // 
            this.radAssetsBackslashLinux.AutoSize = true;
            this.radAssetsBackslashLinux.Enabled = false;
            this.radAssetsBackslashLinux.Location = new System.Drawing.Point(8, 42);
            this.radAssetsBackslashLinux.Name = "radAssetsBackslashLinux";
            this.radAssetsBackslashLinux.Size = new System.Drawing.Size(50, 17);
            this.radAssetsBackslashLinux.TabIndex = 10;
            this.radAssetsBackslashLinux.Text = "Linux";
            this.radAssetsBackslashLinux.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(16, 42);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "Relative";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radAbsoluteAssets
            // 
            this.radAbsoluteAssets.AutoSize = true;
            this.radAbsoluteAssets.Checked = true;
            this.radAbsoluteAssets.Enabled = false;
            this.radAbsoluteAssets.Location = new System.Drawing.Point(16, 19);
            this.radAbsoluteAssets.Name = "radAbsoluteAssets";
            this.radAbsoluteAssets.Size = new System.Drawing.Size(66, 17);
            this.radAbsoluteAssets.TabIndex = 4;
            this.radAbsoluteAssets.TabStop = true;
            this.radAbsoluteAssets.Text = "Absolute";
            this.radAbsoluteAssets.UseVisualStyleBackColor = true;
            this.radAbsoluteAssets.CheckedChanged += new System.EventHandler(this.radAbsoluteAssets_CheckedChanged);
            // 
            // radLinkAssets
            // 
            this.radLinkAssets.AutoSize = true;
            this.radLinkAssets.Location = new System.Drawing.Point(177, 39);
            this.radLinkAssets.Name = "radLinkAssets";
            this.radLinkAssets.Size = new System.Drawing.Size(91, 17);
            this.radLinkAssets.TabIndex = 2;
            this.radLinkAssets.Text = "Link to Assets";
            this.radLinkAssets.UseVisualStyleBackColor = true;
            this.radLinkAssets.CheckedChanged += new System.EventHandler(this.RadLinkAssets_CheckedChanged);
            // 
            // radCopyAssets
            // 
            this.radCopyAssets.AutoSize = true;
            this.radCopyAssets.Checked = true;
            this.radCopyAssets.Location = new System.Drawing.Point(177, 16);
            this.radCopyAssets.Name = "radCopyAssets";
            this.radCopyAssets.Size = new System.Drawing.Size(83, 17);
            this.radCopyAssets.TabIndex = 1;
            this.radCopyAssets.TabStop = true;
            this.radCopyAssets.Text = "Copy Assets";
            this.radCopyAssets.UseVisualStyleBackColor = true;
            this.radCopyAssets.CheckedChanged += new System.EventHandler(this.radCopyAssets_CheckedChanged);
            // 
            // clbAssetList
            // 
            this.clbAssetList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbAssetList.CheckOnClick = true;
            this.clbAssetList.FormattingEnabled = true;
            this.clbAssetList.Location = new System.Drawing.Point(3, 22);
            this.clbAssetList.Name = "clbAssetList";
            this.clbAssetList.Size = new System.Drawing.Size(168, 184);
            this.clbAssetList.TabIndex = 0;
            // 
            // radAutoChoose
            // 
            this.radAutoChoose.AutoSize = true;
            this.radAutoChoose.Checked = true;
            this.radAutoChoose.Location = new System.Drawing.Point(8, 19);
            this.radAutoChoose.Name = "radAutoChoose";
            this.radAutoChoose.Size = new System.Drawing.Size(93, 17);
            this.radAutoChoose.TabIndex = 13;
            this.radAutoChoose.TabStop = true;
            this.radAutoChoose.Text = "Choose for me";
            this.radAutoChoose.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSingleExport);
            this.groupBox3.Controls.Add(this.radAutoChoose);
            this.groupBox3.Controls.Add(this.radChoose);
            this.groupBox3.Location = new System.Drawing.Point(655, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duplicate Assets";
            // 
            // chkSingleExport
            // 
            this.chkSingleExport.AutoSize = true;
            this.chkSingleExport.Checked = true;
            this.chkSingleExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSingleExport.Location = new System.Drawing.Point(6, 65);
            this.chkSingleExport.Name = "chkSingleExport";
            this.chkSingleExport.Size = new System.Drawing.Size(88, 17);
            this.chkSingleExport.TabIndex = 14;
            this.chkSingleExport.Text = "Single Export";
            this.chkSingleExport.UseVisualStyleBackColor = true;
            // 
            // dgvPlatforms
            // 
            this.dgvPlatforms.AllowUserToAddRows = false;
            this.dgvPlatforms.AllowUserToDeleteRows = false;
            this.dgvPlatforms.AllowUserToResizeRows = false;
            this.dgvPlatforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlatforms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlatforms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatforms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colPlatform,
            this.colMetaData,
            this.colAssets,
            this.colApplication});
            this.dgvPlatforms.Location = new System.Drawing.Point(8, 19);
            this.dgvPlatforms.Name = "dgvPlatforms";
            this.dgvPlatforms.RowHeadersVisible = false;
            this.dgvPlatforms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlatforms.ShowEditingIcon = false;
            this.dgvPlatforms.Size = new System.Drawing.Size(755, 119);
            this.dgvPlatforms.TabIndex = 13;
            // 
            // colSelected
            // 
            this.colSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected.DataPropertyName = "Selected";
            this.colSelected.HeaderCheckBox = true;
            this.colSelected.HeaderText = "";
            this.colSelected.MinimumWidth = 20;
            this.colSelected.Name = "colSelected";
            this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected.Width = 20;
            // 
            // colPlatform
            // 
            this.colPlatform.DataPropertyName = "Name";
            this.colPlatform.HeaderText = "Platform";
            this.colPlatform.Name = "colPlatform";
            this.colPlatform.ReadOnly = true;
            this.colPlatform.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colMetaData
            // 
            this.colMetaData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMetaData.DataPropertyName = "ExportMetadata";
            this.colMetaData.HeaderText = "Metadata";
            this.colMetaData.Name = "colMetaData";
            this.colMetaData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMetaData.Width = 58;
            // 
            // colAssets
            // 
            this.colAssets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colAssets.DataPropertyName = "ExportAssets";
            this.colAssets.HeaderText = "Assets";
            this.colAssets.Name = "colAssets";
            this.colAssets.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAssets.Width = 44;
            // 
            // colApplication
            // 
            this.colApplication.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colApplication.DataPropertyName = "ExportApplication";
            this.colApplication.HeaderText = "Application";
            this.colApplication.Name = "colApplication";
            this.colApplication.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colApplication.Width = 65;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.dgvPlatforms);
            this.groupBox4.Location = new System.Drawing.Point(3, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(769, 149);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Platform Export Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkMetaData);
            this.groupBox5.Controls.Add(this.chkAssets);
            this.groupBox5.Controls.Add(this.chkApplication);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(764, 44);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Global Override Settings";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 674);
            this.panel1.TabIndex = 14;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.dgvPlaylists);
            this.groupBox7.Location = new System.Drawing.Point(3, 191);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(769, 149);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Playlist Export Options";
            // 
            // dgvPlaylists
            // 
            this.dgvPlaylists.AllowUserToAddRows = false;
            this.dgvPlaylists.AllowUserToDeleteRows = false;
            this.dgvPlaylists.AllowUserToResizeRows = false;
            this.dgvPlaylists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlaylists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaylists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12});
            this.dgvPlaylists.Location = new System.Drawing.Point(7, 15);
            this.dgvPlaylists.Name = "dgvPlaylists";
            this.dgvPlaylists.RowHeadersVisible = false;
            this.dgvPlaylists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.dgvPlaylists.ShowEditingIcon = false;
            this.dgvPlaylists.Size = new System.Drawing.Size(755, 119);
            this.dgvPlaylists.TabIndex = 15;
            // 
            // colSelected2
            // 
            this.colSelected2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected2.DataPropertyName = "Selected";
            this.colSelected2.HeaderCheckBox = true;
            this.colSelected2.HeaderText = "";
            this.colSelected2.MinimumWidth = 20;
            this.colSelected2.Name = "colSelected2";
            this.colSelected2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected2.Width = 20;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Playlist";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "ExportMetadata";
            this.dataGridViewCheckBoxColumn10.HeaderText = "Metadata";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn10.Width = 58;
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "ExportAssets";
            this.dataGridViewCheckBoxColumn11.HeaderText = "Assets";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            this.dataGridViewCheckBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn11.Width = 44;
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "ExportApplication";
            this.dataGridViewCheckBoxColumn12.HeaderText = "Application";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            this.dataGridViewCheckBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn12.Width = 65;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.gbApplicationPath);
            this.groupBox6.Controls.Add(this.radLinkApplication);
            this.groupBox6.Controls.Add(this.radCopyApplication);
            this.groupBox6.Location = new System.Drawing.Point(305, 352);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 314);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Application Export";
            // 
            // gbApplicationPath
            // 
            this.gbApplicationPath.Controls.Add(this.groupBox10);
            this.gbApplicationPath.Controls.Add(this.radioButton2);
            this.gbApplicationPath.Controls.Add(this.radAbsoluteApplication);
            this.gbApplicationPath.Location = new System.Drawing.Point(6, 62);
            this.gbApplicationPath.Name = "gbApplicationPath";
            this.gbApplicationPath.Size = new System.Drawing.Size(115, 222);
            this.gbApplicationPath.TabIndex = 5;
            this.gbApplicationPath.TabStop = false;
            this.gbApplicationPath.Text = "Path";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.radApplicationBackslashWindows);
            this.groupBox10.Controls.Add(this.radApplicationBackslashLinux);
            this.groupBox10.Location = new System.Drawing.Point(10, 67);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(94, 65);
            this.groupBox10.TabIndex = 18;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Backslash";
            // 
            // radApplicationBackslashWindows
            // 
            this.radApplicationBackslashWindows.AutoSize = true;
            this.radApplicationBackslashWindows.Checked = true;
            this.radApplicationBackslashWindows.Enabled = false;
            this.radApplicationBackslashWindows.Location = new System.Drawing.Point(8, 19);
            this.radApplicationBackslashWindows.Name = "radApplicationBackslashWindows";
            this.radApplicationBackslashWindows.Size = new System.Drawing.Size(69, 17);
            this.radApplicationBackslashWindows.TabIndex = 13;
            this.radApplicationBackslashWindows.TabStop = true;
            this.radApplicationBackslashWindows.Text = "Windows";
            this.radApplicationBackslashWindows.UseVisualStyleBackColor = true;
            // 
            // radApplicationBackslashLinux
            // 
            this.radApplicationBackslashLinux.AutoSize = true;
            this.radApplicationBackslashLinux.Enabled = false;
            this.radApplicationBackslashLinux.Location = new System.Drawing.Point(8, 42);
            this.radApplicationBackslashLinux.Name = "radApplicationBackslashLinux";
            this.radApplicationBackslashLinux.Size = new System.Drawing.Size(50, 17);
            this.radApplicationBackslashLinux.TabIndex = 10;
            this.radApplicationBackslashLinux.Text = "Linux";
            this.radApplicationBackslashLinux.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(16, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Relative";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radAbsoluteApplication
            // 
            this.radAbsoluteApplication.AutoSize = true;
            this.radAbsoluteApplication.Checked = true;
            this.radAbsoluteApplication.Enabled = false;
            this.radAbsoluteApplication.Location = new System.Drawing.Point(16, 19);
            this.radAbsoluteApplication.Name = "radAbsoluteApplication";
            this.radAbsoluteApplication.Size = new System.Drawing.Size(69, 17);
            this.radAbsoluteApplication.TabIndex = 4;
            this.radAbsoluteApplication.TabStop = true;
            this.radAbsoluteApplication.Text = "Absolute.";
            this.radAbsoluteApplication.UseVisualStyleBackColor = true;
            this.radAbsoluteApplication.CheckedChanged += new System.EventHandler(this.radAbsoluteApplication_CheckedChanged);
            // 
            // radLinkApplication
            // 
            this.radLinkApplication.AutoSize = true;
            this.radLinkApplication.Location = new System.Drawing.Point(6, 39);
            this.radLinkApplication.Name = "radLinkApplication";
            this.radLinkApplication.Size = new System.Drawing.Size(112, 17);
            this.radLinkApplication.TabIndex = 4;
            this.radLinkApplication.Text = "Link to Application";
            this.radLinkApplication.UseVisualStyleBackColor = true;
            this.radLinkApplication.CheckedChanged += new System.EventHandler(this.RadLinkApplication_CheckedChanged);
            // 
            // radCopyApplication
            // 
            this.radCopyApplication.AutoSize = true;
            this.radCopyApplication.Checked = true;
            this.radCopyApplication.Location = new System.Drawing.Point(6, 16);
            this.radCopyApplication.Name = "radCopyApplication";
            this.radCopyApplication.Size = new System.Drawing.Size(104, 17);
            this.radCopyApplication.TabIndex = 3;
            this.radCopyApplication.TabStop = true;
            this.radCopyApplication.Text = "Copy Application";
            this.radCopyApplication.UseVisualStyleBackColor = true;
            // 
            // txtExportPath
            // 
            this.txtExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExportPath.Location = new System.Drawing.Point(90, 12);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(616, 20);
            this.txtExportPath.TabIndex = 1;
            // 
            // dataGridViewHeaderCheckBoxColumn1
            // 
            this.dataGridViewHeaderCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewHeaderCheckBoxColumn1.DataPropertyName = "Selected";
            this.dataGridViewHeaderCheckBoxColumn1.HeaderCheckBox = true;
            this.dataGridViewHeaderCheckBoxColumn1.HeaderText = "";
            this.dataGridViewHeaderCheckBoxColumn1.MinimumWidth = 20;
            this.dataGridViewHeaderCheckBoxColumn1.Name = "dataGridViewHeaderCheckBoxColumn1";
            this.dataGridViewHeaderCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaderCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Platform";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 560;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ExportMetadata";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Metadata";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "ExportAssets";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Assets";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "ExportApplication";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Application";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewHeaderCheckBoxColumn2
            // 
            this.dataGridViewHeaderCheckBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewHeaderCheckBoxColumn2.DataPropertyName = "Selected";
            this.dataGridViewHeaderCheckBoxColumn2.HeaderCheckBox = true;
            this.dataGridViewHeaderCheckBoxColumn2.HeaderText = "";
            this.dataGridViewHeaderCheckBoxColumn2.MinimumWidth = 20;
            this.dataGridViewHeaderCheckBoxColumn2.Name = "dataGridViewHeaderCheckBoxColumn2";
            this.dataGridViewHeaderCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHeaderCheckBoxColumn2.Width = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Playlist";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 560;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "ExportMetadata";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Metadata";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "ExportAssets";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Assets";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "ExportApplication";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Application";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSelected21
            // 
            this.colSelected21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colSelected21.DataPropertyName = "Selected";
            this.colSelected21.HeaderCheckBox = true;
            this.colSelected21.HeaderText = "";
            this.colSelected21.MinimumWidth = 20;
            this.colSelected21.Name = "colSelected21";
            this.colSelected21.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelected21.Width = 20;
            // 
            // frmPegasusExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 783);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.btnExport);
            this.MinimumSize = new System.Drawing.Size(514, 300);
            this.Name = "frmPegasusExport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pegasus Export";
            this.Load += new System.EventHandler(this.FrmPegasusExport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpExternalMedia.ResumeLayout(false);
            this.grpExternalMedia.PerformLayout();
            this.gbAssetPath.ResumeLayout(false);
            this.gbAssetPath.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatforms)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylists)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbApplicationPath.ResumeLayout(false);
            this.gbApplicationPath.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.FolderBrowserDialog fbdExportFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox chkMetaData;
        private System.Windows.Forms.CheckBox chkApplication;
        private System.Windows.Forms.CheckBox chkAssets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbImagePriority;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.RadioButton radChoose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox clbAssetList;
        private System.Windows.Forms.RadioButton radAutoChoose;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPlatforms;
        private Controls.DataGridViewHeaderCheckBoxColumn dataGridViewHeaderCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlatform;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMetaData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAssets;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colApplication;
        private System.Windows.Forms.RadioButton radLinkAssets;
        private System.Windows.Forms.RadioButton radCopyAssets;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radLinkApplication;
        private System.Windows.Forms.RadioButton radCopyApplication;
        private System.Windows.Forms.GroupBox gbAssetPath;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radAbsoluteAssets;
        private System.Windows.Forms.GroupBox gbApplicationPath;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radAbsoluteApplication;
        private System.Windows.Forms.GroupBox groupBox7;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.CheckBox chkSingleExport;
        private System.Windows.Forms.MaskedTextBox txtExportPath;
        private System.Windows.Forms.GroupBox grpExternalMedia;
        private System.Windows.Forms.MaskedTextBox txtMediaPath;
        private System.Windows.Forms.CheckBox chkUseExternalMedia;
        private System.Windows.Forms.Button btnBrowseExternalMedia;
        private System.Windows.Forms.FolderBrowserDialog fdbExportExternalMedia;
        private Controls.DataGridViewHeaderCheckBoxColumn dataGridViewHeaderCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radAssetsBackslashWindows;
        private System.Windows.Forms.RadioButton radAssetsBackslashLinux;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton radApplicationBackslashWindows;
        private System.Windows.Forms.RadioButton radApplicationBackslashLinux;
        private System.Windows.Forms.DataGridView dgvPlaylists;
        private Controls.DataGridViewHeaderCheckBoxColumn colSelected2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
    }
}