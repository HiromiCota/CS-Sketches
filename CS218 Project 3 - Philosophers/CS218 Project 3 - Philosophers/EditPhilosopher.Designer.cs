namespace CS218_Project_3___Philosophers
{
    partial class EditPhilosopher
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkDiedBCE = new System.Windows.Forms.CheckBox();
            this.chkBornBCE = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblBiography = new System.Windows.Forms.Label();
            this.txtBiography = new System.Windows.Forms.TextBox();
            this.lblFamousWorks = new System.Windows.Forms.Label();
            this.txtWorks = new System.Windows.Forms.TextBox();
            this.lblDied = new System.Windows.Forms.Label();
            this.txtDied = new System.Windows.Forms.TextBox();
            this.lblBorn = new System.Windows.Forms.Label();
            this.txtBorn = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ttpEdit = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(222, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(154, 66);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkDiedBCE
            // 
            this.chkDiedBCE.AutoSize = true;
            this.chkDiedBCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiedBCE.Location = new System.Drawing.Point(306, 126);
            this.chkDiedBCE.Name = "chkDiedBCE";
            this.chkDiedBCE.Size = new System.Drawing.Size(70, 24);
            this.chkDiedBCE.TabIndex = 52;
            this.chkDiedBCE.Text = "BCE?";
            this.chkDiedBCE.UseVisualStyleBackColor = true;
            // 
            // chkBornBCE
            // 
            this.chkBornBCE.AutoSize = true;
            this.chkBornBCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBornBCE.Location = new System.Drawing.Point(306, 87);
            this.chkBornBCE.Name = "chkBornBCE";
            this.chkBornBCE.Size = new System.Drawing.Size(70, 24);
            this.chkBornBCE.TabIndex = 51;
            this.chkBornBCE.Text = "BCE?";
            this.chkBornBCE.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 66);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "&Edit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(96, 297);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(46, 20);
            this.lblUrl.TabIndex = 49;
            this.lblUrl.Text = "URL:";
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(148, 294);
            this.txtURL.MaxLength = 128;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(148, 26);
            this.txtURL.TabIndex = 48;
            // 
            // lblBiography
            // 
            this.lblBiography.AutoSize = true;
            this.lblBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiography.Location = new System.Drawing.Point(58, 199);
            this.lblBiography.Name = "lblBiography";
            this.lblBiography.Size = new System.Drawing.Size(84, 20);
            this.lblBiography.TabIndex = 47;
            this.lblBiography.Text = "Biography:";
            // 
            // txtBiography
            // 
            this.txtBiography.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiography.Location = new System.Drawing.Point(148, 196);
            this.txtBiography.MaxLength = 512;
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.Size = new System.Drawing.Size(148, 81);
            this.txtBiography.TabIndex = 46;
            // 
            // lblFamousWorks
            // 
            this.lblFamousWorks.AutoSize = true;
            this.lblFamousWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamousWorks.Location = new System.Drawing.Point(26, 162);
            this.lblFamousWorks.Name = "lblFamousWorks";
            this.lblFamousWorks.Size = new System.Drawing.Size(116, 20);
            this.lblFamousWorks.TabIndex = 45;
            this.lblFamousWorks.Text = "Famous works:";
            // 
            // txtWorks
            // 
            this.txtWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorks.Location = new System.Drawing.Point(148, 159);
            this.txtWorks.MaxLength = 128;
            this.txtWorks.Name = "txtWorks";
            this.txtWorks.Size = new System.Drawing.Size(148, 26);
            this.txtWorks.TabIndex = 44;
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDied.Location = new System.Drawing.Point(29, 125);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(113, 20);
            this.lblDied.TabIndex = 43;
            this.lblDied.Text = "Year of Death:";
            // 
            // txtDied
            // 
            this.txtDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDied.Location = new System.Drawing.Point(148, 122);
            this.txtDied.Name = "txtDied";
            this.txtDied.Size = new System.Drawing.Size(148, 26);
            this.txtDied.TabIndex = 42;
            // 
            // lblBorn
            // 
            this.lblBorn.AutoSize = true;
            this.lblBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorn.Location = new System.Drawing.Point(40, 89);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(102, 20);
            this.lblBorn.TabIndex = 41;
            this.lblBorn.Text = "Year of Birth:";
            // 
            // txtBorn
            // 
            this.txtBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorn.Location = new System.Drawing.Point(148, 85);
            this.txtBorn.Name = "txtBorn";
            this.txtBorn.Size = new System.Drawing.Size(148, 26);
            this.txtBorn.TabIndex = 40;
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNation.Location = new System.Drawing.Point(12, 51);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(131, 20);
            this.lblNation.TabIndex = 39;
            this.lblNation.Text = "Country of Origin:";
            // 
            // txtNation
            // 
            this.txtNation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNation.Location = new System.Drawing.Point(148, 48);
            this.txtNation.MaxLength = 128;
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(148, 26);
            this.txtNation.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(148, 11);
            this.txtName.MaxLength = 128;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 26);
            this.txtName.TabIndex = 36;
            // 
            // EditPhilosopher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(397, 417);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkDiedBCE);
            this.Controls.Add(this.chkBornBCE);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblBiography);
            this.Controls.Add(this.txtBiography);
            this.Controls.Add(this.lblFamousWorks);
            this.Controls.Add(this.txtWorks);
            this.Controls.Add(this.lblDied);
            this.Controls.Add(this.txtDied);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.txtBorn);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPhilosopher";
            this.Text = "EditPhilosopher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPhilosopher_FormClosing);
            this.Load += new System.EventHandler(this.EditPhilosopher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkDiedBCE;
        private System.Windows.Forms.CheckBox chkBornBCE;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblBiography;
        private System.Windows.Forms.TextBox txtBiography;
        private System.Windows.Forms.Label lblFamousWorks;
        private System.Windows.Forms.TextBox txtWorks;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.TextBox txtDied;
        private System.Windows.Forms.Label lblBorn;
        private System.Windows.Forms.TextBox txtBorn;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip ttpEdit;
    }
}