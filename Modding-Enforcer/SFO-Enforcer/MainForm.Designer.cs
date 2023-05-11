namespace PARAM.SFO_Enforcer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitleID = new System.Windows.Forms.Label();
            this.txtTitleId = new System.Windows.Forms.TextBox();
            this.txtCATEGORY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAddonData = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxParent = new System.Windows.Forms.ComboBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAppVersion = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxAddon = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbSystemVersion = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtSFOpath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSFOEnforcerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleID
            // 
            this.lblTitleID.AutoSize = true;
            this.lblTitleID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleID.Location = new System.Drawing.Point(15, 37);
            this.lblTitleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleID.Name = "lblTitleID";
            this.lblTitleID.Size = new System.Drawing.Size(109, 16);
            this.lblTitleID.TabIndex = 7;
            this.lblTitleID.Text = "TitleID / Region:";
            // 
            // txtTitleId
            // 
            this.txtTitleId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTitleId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitleId.ForeColor = System.Drawing.Color.White;
            this.txtTitleId.Location = new System.Drawing.Point(18, 56);
            this.txtTitleId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitleId.Name = "txtTitleId";
            this.txtTitleId.Size = new System.Drawing.Size(464, 23);
            this.txtTitleId.TabIndex = 8;
            this.txtTitleId.TextChanged += new System.EventHandler(this.txtTitleId_TextChanged);
            // 
            // txtCATEGORY
            // 
            this.txtCATEGORY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCATEGORY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCATEGORY.ForeColor = System.Drawing.Color.White;
            this.txtCATEGORY.Location = new System.Drawing.Point(150, 323);
            this.txtCATEGORY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCATEGORY.Name = "txtCATEGORY";
            this.txtCATEGORY.Size = new System.Drawing.Size(270, 23);
            this.txtCATEGORY.TabIndex = 9;
            this.txtCATEGORY.TextChanged += new System.EventHandler(this.txtCATEGORY_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 327);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Category:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(75, 357);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "System Version:";
            // 
            // txtAddonData
            // 
            this.txtAddonData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtAddonData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddonData.ForeColor = System.Drawing.Color.White;
            this.txtAddonData.Location = new System.Drawing.Point(16, 250);
            this.txtAddonData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAddonData.Multiline = true;
            this.txtAddonData.Name = "txtAddonData";
            this.txtAddonData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddonData.Size = new System.Drawing.Size(466, 67);
            this.txtAddonData.TabIndex = 19;
            this.txtAddonData.Leave += new System.EventHandler(this.txtAddonData_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(252, 357);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Parental Lock Level:";
            // 
            // cbxParent
            // 
            this.cbxParent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbxParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxParent.ForeColor = System.Drawing.Color.White;
            this.cbxParent.FormattingEnabled = true;
            this.cbxParent.Items.AddRange(new object[] {
            "0 - Unlocked",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11 - Full Lock"});
            this.cbxParent.Location = new System.Drawing.Point(255, 376);
            this.cbxParent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxParent.Name = "cbxParent";
            this.cbxParent.Size = new System.Drawing.Size(169, 23);
            this.cbxParent.TabIndex = 21;
            this.cbxParent.SelectedIndexChanged += new System.EventHandler(this.cbxParent_SelectedIndexChanged);
            this.cbxParent.TextChanged += new System.EventHandler(this.cbxParent_TextChanged);
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVersion.ForeColor = System.Drawing.Color.White;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(378, 135);
            this.cbVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(106, 23);
            this.cbVersion.TabIndex = 23;
            this.cbVersion.SelectedIndexChanged += new System.EventHandler(this.cbVersion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Version:";
            // 
            // cbxAppVersion
            // 
            this.cbxAppVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbxAppVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAppVersion.ForeColor = System.Drawing.Color.White;
            this.cbxAppVersion.FormattingEnabled = true;
            this.cbxAppVersion.Location = new System.Drawing.Point(378, 106);
            this.cbxAppVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxAppVersion.Name = "cbxAppVersion";
            this.cbxAppVersion.Size = new System.Drawing.Size(106, 23);
            this.cbxAppVersion.TabIndex = 25;
            this.cbxAppVersion.SelectedIndexChanged += new System.EventHandler(this.cbxAppVersion_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(288, 110);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "App Version:";
            // 
            // cbxAddon
            // 
            this.cbxAddon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbxAddon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAddon.ForeColor = System.Drawing.Color.White;
            this.cbxAddon.FormattingEnabled = true;
            this.cbxAddon.Location = new System.Drawing.Point(18, 135);
            this.cbxAddon.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAddon.Name = "cbxAddon";
            this.cbxAddon.Size = new System.Drawing.Size(256, 23);
            this.cbxAddon.TabIndex = 26;
            this.cbxAddon.SelectedIndexChanged += new System.EventHandler(this.cbxAddon_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(18, 107);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(256, 23);
            this.txtTitle.TabIndex = 29;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(15, 88);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 16);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Title:";
            // 
            // cbSystemVersion
            // 
            this.cbSystemVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbSystemVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSystemVersion.ForeColor = System.Drawing.Color.White;
            this.cbSystemVersion.FormattingEnabled = true;
            this.cbSystemVersion.Location = new System.Drawing.Point(78, 376);
            this.cbSystemVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSystemVersion.Name = "cbSystemVersion";
            this.cbSystemVersion.Size = new System.Drawing.Size(169, 23);
            this.cbSystemVersion.TabIndex = 31;
            this.cbSystemVersion.TextChanged += new System.EventHandler(this.cbSystemVersion_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // txtSFOpath
            // 
            this.txtSFOpath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtSFOpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSFOpath.ForeColor = System.Drawing.Color.White;
            this.txtSFOpath.Location = new System.Drawing.Point(16, 181);
            this.txtSFOpath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSFOpath.Multiline = true;
            this.txtSFOpath.Name = "txtSFOpath";
            this.txtSFOpath.Size = new System.Drawing.Size(466, 63);
            this.txtSFOpath.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "SFO Path:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Image = global::SFO_Enforcer.Properties.Resources.file_32px;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSFOEnforcerToolStripMenuItem});
            this.moreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moreToolStripMenuItem.Image = global::SFO_Enforcer.Properties.Resources.menu_50px;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // aboutSFOEnforcerToolStripMenuItem
            // 
            this.aboutSFOEnforcerToolStripMenuItem.Name = "aboutSFOEnforcerToolStripMenuItem";
            this.aboutSFOEnforcerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutSFOEnforcerToolStripMenuItem.Text = "About SFO Enforcer";
            this.aboutSFOEnforcerToolStripMenuItem.Click += new System.EventHandler(this.aboutSFOEnforcerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(498, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbxParent);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxAppVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddonData);
            this.Controls.Add(this.lblTitleID);
            this.Controls.Add(this.cbxAddon);
            this.Controls.Add(this.txtSFOpath);
            this.Controls.Add(this.txtTitleId);
            this.Controls.Add(this.txtCATEGORY);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cbSystemVersion);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SFO Enforcer | By EternalModz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleID;
        private System.Windows.Forms.TextBox txtTitleId;
        private System.Windows.Forms.TextBox txtCATEGORY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddonData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxParent;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAppVersion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxAddon;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbSystemVersion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtSFOpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSFOEnforcerToolStripMenuItem;
    }
}