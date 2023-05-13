namespace Modding_Enforcer
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
            this.VersionLabel = new System.Windows.Forms.Label();
            this.CheckForUpdateLabel = new System.Windows.Forms.LinkLabel();
            this.ViewSourceCodeBtn = new System.Windows.Forms.LinkLabel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainGroupBox = new CBH.Controls.CrEaTiiOn_ModernGroupBox();
            this.MoreOnTheyWayLabel = new System.Windows.Forms.Label();
            this.ARCEnforcerBtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.SFOEnforcerBtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.FUIEnforcerBtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.MSSCMPStudioBtn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(346, 507);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(224, 15);
            this.VersionLabel.TabIndex = 5;
            this.VersionLabel.Text = "Modding Enforcer Version: 1.1.0 (#0001A)";
            // 
            // CheckForUpdateLabel
            // 
            this.CheckForUpdateLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.CheckForUpdateLabel.AutoSize = true;
            this.CheckForUpdateLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.CheckForUpdateLabel.Location = new System.Drawing.Point(401, 488);
            this.CheckForUpdateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CheckForUpdateLabel.Name = "CheckForUpdateLabel";
            this.CheckForUpdateLabel.Size = new System.Drawing.Size(114, 15);
            this.CheckForUpdateLabel.TabIndex = 6;
            this.CheckForUpdateLabel.TabStop = true;
            this.CheckForUpdateLabel.Text = "Check for an update";
            this.CheckForUpdateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckForUpdateLabel_LinkClicked);
            // 
            // ViewSourceCodeBtn
            // 
            this.ViewSourceCodeBtn.ActiveLinkColor = System.Drawing.Color.Blue;
            this.ViewSourceCodeBtn.AutoSize = true;
            this.ViewSourceCodeBtn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ViewSourceCodeBtn.Location = new System.Drawing.Point(399, 470);
            this.ViewSourceCodeBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewSourceCodeBtn.Name = "ViewSourceCodeBtn";
            this.ViewSourceCodeBtn.Size = new System.Drawing.Size(119, 15);
            this.ViewSourceCodeBtn.TabIndex = 7;
            this.ViewSourceCodeBtn.TabStop = true;
            this.ViewSourceCodeBtn.Text = "View the source code";
            this.ViewSourceCodeBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewSourceCodeBtn_LinkClicked);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("MV Boli", 45F);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.TitleLabel.Location = new System.Drawing.Point(196, 54);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(525, 79);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Modding Enforcer";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainGroupBox.Colors = new CBH_Ultimate_Theme_Library.Bloom[0];
            this.MainGroupBox.Controls.Add(this.MoreOnTheyWayLabel);
            this.MainGroupBox.Controls.Add(this.ARCEnforcerBtn);
            this.MainGroupBox.Controls.Add(this.SFOEnforcerBtn);
            this.MainGroupBox.Controls.Add(this.FUIEnforcerBtn);
            this.MainGroupBox.Controls.Add(this.MSSCMPStudioBtn);
            this.MainGroupBox.CornerRadius = 15;
            this.MainGroupBox.Customization = "";
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MainGroupBox.GroupBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MainGroupBox.Image = null;
            this.MainGroupBox.LBlendColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.MainGroupBox.Location = new System.Drawing.Point(130, 219);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainGroupBox.Movable = true;
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.NoRounding = false;
            this.MainGroupBox.Sizable = true;
            this.MainGroupBox.Size = new System.Drawing.Size(656, 228);
            this.MainGroupBox.SmartBounds = true;
            this.MainGroupBox.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.MainGroupBox.TabIndex = 4;
            this.MainGroupBox.Text = "Select A Tool To Launch!";
            this.MainGroupBox.TextColor = System.Drawing.Color.White;
            this.MainGroupBox.TransparencyKey = System.Drawing.Color.Empty;
            this.MainGroupBox.Transparent = false;
            // 
            // MoreOnTheyWayLabel
            // 
            this.MoreOnTheyWayLabel.AutoSize = true;
            this.MoreOnTheyWayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MoreOnTheyWayLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MoreOnTheyWayLabel.ForeColor = System.Drawing.Color.White;
            this.MoreOnTheyWayLabel.Location = new System.Drawing.Point(205, 143);
            this.MoreOnTheyWayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoreOnTheyWayLabel.Name = "MoreOnTheyWayLabel";
            this.MoreOnTheyWayLabel.Size = new System.Drawing.Size(210, 21);
            this.MoreOnTheyWayLabel.TabIndex = 4;
            this.MoreOnTheyWayLabel.Text = "More tools are coming soon!";
            // 
            // ARCEnforcerBtn
            // 
            this.ARCEnforcerBtn.BackColor = System.Drawing.Color.Transparent;
            this.ARCEnforcerBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.ARCEnforcerBtn.BorderRadius = 10;
            this.ARCEnforcerBtn.BorderSize = 1;
            this.ARCEnforcerBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ARCEnforcerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ARCEnforcerBtn.FlatAppearance.BorderSize = 0;
            this.ARCEnforcerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ARCEnforcerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ARCEnforcerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ARCEnforcerBtn.ForeColor = System.Drawing.Color.White;
            this.ARCEnforcerBtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ARCEnforcerBtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ARCEnforcerBtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ARCEnforcerBtn.Location = new System.Drawing.Point(6, 35);
            this.ARCEnforcerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ARCEnforcerBtn.Name = "ARCEnforcerBtn";
            this.ARCEnforcerBtn.Size = new System.Drawing.Size(155, 45);
            this.ARCEnforcerBtn.TabIndex = 0;
            this.ARCEnforcerBtn.Text = "ARC Enforcer";
            this.ARCEnforcerBtn.TextColor = System.Drawing.Color.White;
            this.ARCEnforcerBtn.UseVisualStyleBackColor = false;
            this.ARCEnforcerBtn.Click += new System.EventHandler(this.ARCEnforcerBtn_Click);
            // 
            // SFOEnforcerBtn
            // 
            this.SFOEnforcerBtn.BackColor = System.Drawing.Color.Transparent;
            this.SFOEnforcerBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.SFOEnforcerBtn.BorderRadius = 10;
            this.SFOEnforcerBtn.BorderSize = 1;
            this.SFOEnforcerBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SFOEnforcerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SFOEnforcerBtn.FlatAppearance.BorderSize = 0;
            this.SFOEnforcerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SFOEnforcerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SFOEnforcerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SFOEnforcerBtn.ForeColor = System.Drawing.Color.White;
            this.SFOEnforcerBtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.SFOEnforcerBtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.SFOEnforcerBtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SFOEnforcerBtn.Location = new System.Drawing.Point(495, 35);
            this.SFOEnforcerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SFOEnforcerBtn.Name = "SFOEnforcerBtn";
            this.SFOEnforcerBtn.Size = new System.Drawing.Size(155, 45);
            this.SFOEnforcerBtn.TabIndex = 3;
            this.SFOEnforcerBtn.Text = "SFO Enforcer";
            this.SFOEnforcerBtn.TextColor = System.Drawing.Color.White;
            this.SFOEnforcerBtn.UseVisualStyleBackColor = false;
            this.SFOEnforcerBtn.Click += new System.EventHandler(this.SFOEnforcerBtn_Click);
            // 
            // FUIEnforcerBtn
            // 
            this.FUIEnforcerBtn.BackColor = System.Drawing.Color.Transparent;
            this.FUIEnforcerBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.FUIEnforcerBtn.BorderRadius = 10;
            this.FUIEnforcerBtn.BorderSize = 1;
            this.FUIEnforcerBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FUIEnforcerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FUIEnforcerBtn.FlatAppearance.BorderSize = 0;
            this.FUIEnforcerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FUIEnforcerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FUIEnforcerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FUIEnforcerBtn.ForeColor = System.Drawing.Color.White;
            this.FUIEnforcerBtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.FUIEnforcerBtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.FUIEnforcerBtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FUIEnforcerBtn.Location = new System.Drawing.Point(169, 35);
            this.FUIEnforcerBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FUIEnforcerBtn.Name = "FUIEnforcerBtn";
            this.FUIEnforcerBtn.Size = new System.Drawing.Size(155, 45);
            this.FUIEnforcerBtn.TabIndex = 1;
            this.FUIEnforcerBtn.Text = "FUI Enforcer";
            this.FUIEnforcerBtn.TextColor = System.Drawing.Color.White;
            this.FUIEnforcerBtn.UseVisualStyleBackColor = false;
            this.FUIEnforcerBtn.Click += new System.EventHandler(this.FUIEnforcerBtn_Click);
            // 
            // MSSCMPStudioBtn
            // 
            this.MSSCMPStudioBtn.BackColor = System.Drawing.Color.Transparent;
            this.MSSCMPStudioBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.MSSCMPStudioBtn.BorderRadius = 10;
            this.MSSCMPStudioBtn.BorderSize = 1;
            this.MSSCMPStudioBtn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MSSCMPStudioBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSSCMPStudioBtn.FlatAppearance.BorderSize = 0;
            this.MSSCMPStudioBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MSSCMPStudioBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MSSCMPStudioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MSSCMPStudioBtn.ForeColor = System.Drawing.Color.White;
            this.MSSCMPStudioBtn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.MSSCMPStudioBtn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.MSSCMPStudioBtn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MSSCMPStudioBtn.Location = new System.Drawing.Point(332, 35);
            this.MSSCMPStudioBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MSSCMPStudioBtn.Name = "MSSCMPStudioBtn";
            this.MSSCMPStudioBtn.Size = new System.Drawing.Size(155, 45);
            this.MSSCMPStudioBtn.TabIndex = 2;
            this.MSSCMPStudioBtn.Text = "MSSCMP Studio";
            this.MSSCMPStudioBtn.TextColor = System.Drawing.Color.White;
            this.MSSCMPStudioBtn.UseVisualStyleBackColor = false;
            this.MSSCMPStudioBtn.Click += new System.EventHandler(this.MSSCMPStudioBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(917, 547);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ViewSourceCodeBtn);
            this.Controls.Add(this.CheckForUpdateLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.MainGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modding Enforcer | By EternalModz";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton ARCEnforcerBtn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton FUIEnforcerBtn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton SFOEnforcerBtn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton MSSCMPStudioBtn;
        private CBH.Controls.CrEaTiiOn_ModernGroupBox MainGroupBox;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.LinkLabel CheckForUpdateLabel;
        private System.Windows.Forms.LinkLabel ViewSourceCodeBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MoreOnTheyWayLabel;
    }
}

