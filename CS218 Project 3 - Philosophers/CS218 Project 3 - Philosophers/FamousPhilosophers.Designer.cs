namespace CS218_Project_3___Philosophers
{
    partial class LearnPhilosophy
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
            this.lstSelector = new System.Windows.Forms.ListBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSort = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortZA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSortBornFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortBornLast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSortDiedFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSortDiedLast = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchName = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchNationality = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtDied = new System.Windows.Forms.TextBox();
            this.lblDied = new System.Windows.Forms.Label();
            this.txtBorn = new System.Windows.Forms.TextBox();
            this.lblBorn = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.txtWorks = new System.Windows.Forms.TextBox();
            this.lblWorks = new System.Windows.Forms.Label();
            this.rtxURL = new System.Windows.Forms.RichTextBox();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.picShowImage = new System.Windows.Forms.PictureBox();
            this.btnView = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSelector
            // 
            this.lstSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelector.FormattingEnabled = true;
            this.lstSelector.ItemHeight = 20;
            this.lstSelector.Location = new System.Drawing.Point(18, 54);
            this.lstSelector.Name = "lstSelector";
            this.lstSelector.Size = new System.Drawing.Size(242, 324);
            this.lstSelector.TabIndex = 1;
            this.lstSelector.SelectedIndexChanged += new System.EventHandler(this.lstSelector_SelectedIndexChanged);
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuSort,
            this.modifyDataToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(802, 24);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.toolStripSeparator1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(103, 22);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(103, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuSort
            // 
            this.mnuSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSortAZ,
            this.mnuSortZA,
            this.toolStripSeparator2,
            this.mnuSortBornFirst,
            this.mnuSortBornLast,
            this.toolStripSeparator3,
            this.mnuSortDiedFirst,
            this.mnuSortDiedLast});
            this.mnuSort.Name = "mnuSort";
            this.mnuSort.Size = new System.Drawing.Size(67, 20);
            this.mnuSort.Text = "&Sort Data";
            // 
            // mnuSortAZ
            // 
            this.mnuSortAZ.Name = "mnuSortAZ";
            this.mnuSortAZ.Size = new System.Drawing.Size(163, 22);
            this.mnuSortAZ.Text = "&A-Z Alphabetical";
            this.mnuSortAZ.Click += new System.EventHandler(this.mnuSortAZ_Click);
            // 
            // mnuSortZA
            // 
            this.mnuSortZA.Name = "mnuSortZA";
            this.mnuSortZA.Size = new System.Drawing.Size(163, 22);
            this.mnuSortZA.Text = "&Z-A Alphabetical";
            this.mnuSortZA.Click += new System.EventHandler(this.mnuSortZA_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuSortBornFirst
            // 
            this.mnuSortBornFirst.Name = "mnuSortBornFirst";
            this.mnuSortBornFirst.Size = new System.Drawing.Size(163, 22);
            this.mnuSortBornFirst.Text = "&Born First";
            this.mnuSortBornFirst.Click += new System.EventHandler(this.mnuSortBornFirst_Click);
            // 
            // mnuSortBornLast
            // 
            this.mnuSortBornLast.Name = "mnuSortBornLast";
            this.mnuSortBornLast.Size = new System.Drawing.Size(163, 22);
            this.mnuSortBornLast.Text = "Born &Last";
            this.mnuSortBornLast.Click += new System.EventHandler(this.mnuSortBornLast_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // mnuSortDiedFirst
            // 
            this.mnuSortDiedFirst.Name = "mnuSortDiedFirst";
            this.mnuSortDiedFirst.Size = new System.Drawing.Size(163, 22);
            this.mnuSortDiedFirst.Text = "&Died First";
            this.mnuSortDiedFirst.Click += new System.EventHandler(this.mnuSortDiedFirst_Click);
            // 
            // mnuSortDiedLast
            // 
            this.mnuSortDiedLast.Name = "mnuSortDiedLast";
            this.mnuSortDiedLast.Size = new System.Drawing.Size(163, 22);
            this.mnuSortDiedLast.Text = "Died L&ast";
            this.mnuSortDiedLast.Click += new System.EventHandler(this.mnuSortDiedLast_Click);
            // 
            // modifyDataToolStripMenuItem
            // 
            this.modifyDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd,
            this.mnuEdit,
            this.mnuDelete});
            this.modifyDataToolStripMenuItem.Name = "modifyDataToolStripMenuItem";
            this.modifyDataToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.modifyDataToolStripMenuItem.Text = "&Modify Data";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(173, 22);
            this.mnuAdd.Text = "&Add Philosopher";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(173, 22);
            this.mnuEdit.Text = "&Edit Philosopher";
            this.mnuEdit.Click += new System.EventHandler(this.mnuEdit_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(173, 22);
            this.mnuDelete.Text = "&Delete Philosopher";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchName,
            this.mnuSearchNationality});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "S&earch";
            // 
            // mnuSearchName
            // 
            this.mnuSearchName.Name = "mnuSearchName";
            this.mnuSearchName.Size = new System.Drawing.Size(148, 22);
            this.mnuSearchName.Text = "By &Name";
            this.mnuSearchName.Click += new System.EventHandler(this.mnuSearchName_Click);
            // 
            // mnuSearchNationality
            // 
            this.mnuSearchNationality.Name = "mnuSearchNationality";
            this.mnuSearchNationality.Size = new System.Drawing.Size(148, 22);
            this.mnuSearchNationality.Text = "By N&ationality";
            this.mnuSearchNationality.Click += new System.EventHandler(this.mnuSearchNationality_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(171, 393);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 48);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(477, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(630, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(144, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(353, 54);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(413, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(364, 26);
            this.txtName.TabIndex = 9;
            // 
            // txtNation
            // 
            this.txtNation.Enabled = false;
            this.txtNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.Location = new System.Drawing.Point(413, 85);
            this.txtNation.Margin = new System.Windows.Forms.Padding(2);
            this.txtNation.Name = "txtNation";
            this.txtNation.ReadOnly = true;
            this.txtNation.Size = new System.Drawing.Size(364, 26);
            this.txtNation.TabIndex = 11;
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNation.Location = new System.Drawing.Point(278, 88);
            this.lblNation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(131, 20);
            this.lblNation.TabIndex = 10;
            this.lblNation.Text = "Country of Origin:";
            this.lblNation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDied
            // 
            this.txtDied.Enabled = false;
            this.txtDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDied.Location = new System.Drawing.Point(413, 151);
            this.txtDied.Margin = new System.Windows.Forms.Padding(2);
            this.txtDied.Name = "txtDied";
            this.txtDied.ReadOnly = true;
            this.txtDied.Size = new System.Drawing.Size(364, 26);
            this.txtDied.TabIndex = 15;
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDied.Location = new System.Drawing.Point(362, 153);
            this.lblDied.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(46, 20);
            this.lblDied.TabIndex = 14;
            this.lblDied.Text = "Died:";
            this.lblDied.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBorn
            // 
            this.txtBorn.Enabled = false;
            this.txtBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorn.Location = new System.Drawing.Point(413, 118);
            this.txtBorn.Margin = new System.Windows.Forms.Padding(2);
            this.txtBorn.Name = "txtBorn";
            this.txtBorn.ReadOnly = true;
            this.txtBorn.Size = new System.Drawing.Size(364, 26);
            this.txtBorn.TabIndex = 13;
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorn.Location = new System.Drawing.Point(362, 120);
            this.lblBorn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(47, 20);
            this.lblBorn.TabIndex = 12;
            this.lblBorn.Text = "Born:";
            this.lblBorn.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.Location = new System.Drawing.Point(261, 339);
            this.lblURL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(150, 20);
            this.lblURL.TabIndex = 20;
            this.lblURL.Text = "Further Information:";
            this.lblURL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtBio
            // 
            this.txtBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBio.Location = new System.Drawing.Point(413, 218);
            this.txtBio.Margin = new System.Windows.Forms.Padding(2);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.ReadOnly = true;
            this.txtBio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBio.Size = new System.Drawing.Size(364, 110);
            this.txtBio.TabIndex = 19;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(323, 220);
            this.lblBio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(84, 20);
            this.lblBio.TabIndex = 18;
            this.lblBio.Text = "Biography:";
            this.lblBio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtWorks
            // 
            this.txtWorks.Enabled = false;
            this.txtWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorks.Location = new System.Drawing.Point(413, 185);
            this.txtWorks.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorks.Name = "txtWorks";
            this.txtWorks.ReadOnly = true;
            this.txtWorks.Size = new System.Drawing.Size(364, 26);
            this.txtWorks.TabIndex = 17;
            // 
            // lblWorks
            // 
            this.lblWorks.AutoSize = true;
            this.lblWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorks.Location = new System.Drawing.Point(291, 187);
            this.lblWorks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorks.Name = "lblWorks";
            this.lblWorks.Size = new System.Drawing.Size(120, 20);
            this.lblWorks.TabIndex = 16;
            this.lblWorks.Text = "Famous Works:";
            this.lblWorks.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtxURL
            // 
            this.rtxURL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rtxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxURL.Location = new System.Drawing.Point(413, 337);
            this.rtxURL.Margin = new System.Windows.Forms.Padding(2);
            this.rtxURL.Multiline = false;
            this.rtxURL.Name = "rtxURL";
            this.rtxURL.ReadOnly = true;
            this.rtxURL.Size = new System.Drawing.Size(364, 31);
            this.rtxURL.TabIndex = 21;
            this.rtxURL.Text = "";
            this.rtxURL.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxURL_LinkClicked);
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdSaveFile_FileOk);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            this.ofdOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenFile_FileOk);
            // 
            // picShowImage
            // 
            this.picShowImage.Location = new System.Drawing.Point(18, 52);
            this.picShowImage.Name = "picShowImage";
            this.picShowImage.Size = new System.Drawing.Size(242, 326);
            this.picShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShowImage.TabIndex = 22;
            this.picShowImage.TabStop = false;
            this.picShowImage.Visible = false;
            this.picShowImage.Click += new System.EventHandler(this.picShowImage_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(324, 393);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(144, 48);
            this.btnView.TabIndex = 23;
            this.btnView.Text = "&View Image";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // LearnPhilosophy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(802, 462);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.rtxURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.txtWorks);
            this.Controls.Add(this.lblWorks);
            this.Controls.Add(this.txtDied);
            this.Controls.Add(this.lblDied);
            this.Controls.Add(this.txtBorn);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstSelector);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.picShowImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "LearnPhilosophy";
            this.Text = "Philosopher Teacher 9,000!";
            this.Load += new System.EventHandler(this.LearnPhilosophy_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstSelector;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.TextBox txtDied;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.TextBox txtWorks;
        private System.Windows.Forms.Label lblWorks;
        private System.Windows.Forms.RichTextBox rtxURL;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSort;
        private System.Windows.Forms.ToolStripMenuItem mnuSortAZ;
        private System.Windows.Forms.ToolStripMenuItem mnuSortZA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuSortBornFirst;
        private System.Windows.Forms.ToolStripMenuItem mnuSortBornLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuSortDiedFirst;
        private System.Windows.Forms.ToolStripMenuItem mnuSortDiedLast;
        private System.Windows.Forms.ToolStripMenuItem modifyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchName;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchNationality;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.PictureBox picShowImage;
        private System.Windows.Forms.Button btnView;
    }
}

