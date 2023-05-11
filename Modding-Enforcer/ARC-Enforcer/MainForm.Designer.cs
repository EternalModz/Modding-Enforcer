namespace ARC_Enforcer.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00003444 File Offset: 0x00001644
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000347C File Offset: 0x0000167C
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BrowseARCFolder_Btn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.BrowseARCFile_Btn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.Pack_Btn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.UnPack_Btn = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.SuspendLayout();
            // 
            // textBox_0
            // 
            this.textBox_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_0.ForeColor = System.Drawing.Color.White;
            this.textBox_0.Location = new System.Drawing.Point(12, 28);
            this.textBox_0.Name = "textBox_0";
            this.textBox_0.Size = new System.Drawing.Size(364, 22);
            this.textBox_0.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARC File";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ARC Folder";
            // 
            // textBox_1
            // 
            this.textBox_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_1.Enabled = false;
            this.textBox_1.ForeColor = System.Drawing.Color.White;
            this.textBox_1.Location = new System.Drawing.Point(12, 76);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(364, 22);
            this.textBox_1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 121);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Auto-Extract";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BrowseARCFolder_Btn
            // 
            this.BrowseARCFolder_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrowseARCFolder_Btn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseARCFolder_Btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BrowseARCFolder_Btn.BorderRadius = 10;
            this.BrowseARCFolder_Btn.BorderSize = 1;
            this.BrowseARCFolder_Btn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BrowseARCFolder_Btn.FlatAppearance.BorderSize = 0;
            this.BrowseARCFolder_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BrowseARCFolder_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BrowseARCFolder_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseARCFolder_Btn.ForeColor = System.Drawing.Color.White;
            this.BrowseARCFolder_Btn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BrowseARCFolder_Btn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.BrowseARCFolder_Btn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BrowseARCFolder_Btn.Location = new System.Drawing.Point(382, 76);
            this.BrowseARCFolder_Btn.Name = "BrowseARCFolder_Btn";
            this.BrowseARCFolder_Btn.Size = new System.Drawing.Size(75, 23);
            this.BrowseARCFolder_Btn.TabIndex = 12;
            this.BrowseARCFolder_Btn.Text = "Browse";
            this.BrowseARCFolder_Btn.TextColor = System.Drawing.Color.White;
            this.BrowseARCFolder_Btn.UseVisualStyleBackColor = false;
            this.BrowseARCFolder_Btn.Click += new System.EventHandler(this.BrowseARCFolder_Btn_Click);
            // 
            // BrowseARCFile_Btn
            // 
            this.BrowseARCFile_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrowseARCFile_Btn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseARCFile_Btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BrowseARCFile_Btn.BorderRadius = 10;
            this.BrowseARCFile_Btn.BorderSize = 1;
            this.BrowseARCFile_Btn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BrowseARCFile_Btn.FlatAppearance.BorderSize = 0;
            this.BrowseARCFile_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BrowseARCFile_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BrowseARCFile_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseARCFile_Btn.ForeColor = System.Drawing.Color.White;
            this.BrowseARCFile_Btn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.BrowseARCFile_Btn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.BrowseARCFile_Btn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BrowseARCFile_Btn.Location = new System.Drawing.Point(382, 28);
            this.BrowseARCFile_Btn.Name = "BrowseARCFile_Btn";
            this.BrowseARCFile_Btn.Size = new System.Drawing.Size(75, 23);
            this.BrowseARCFile_Btn.TabIndex = 11;
            this.BrowseARCFile_Btn.Text = "Browse";
            this.BrowseARCFile_Btn.TextColor = System.Drawing.Color.White;
            this.BrowseARCFile_Btn.UseVisualStyleBackColor = false;
            this.BrowseARCFile_Btn.Click += new System.EventHandler(this.BrowseARCFile_Btn_Click);
            // 
            // Pack_Btn
            // 
            this.Pack_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pack_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Pack_Btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.Pack_Btn.BorderRadius = 10;
            this.Pack_Btn.BorderSize = 1;
            this.Pack_Btn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Pack_Btn.FlatAppearance.BorderSize = 0;
            this.Pack_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Pack_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Pack_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pack_Btn.ForeColor = System.Drawing.Color.White;
            this.Pack_Btn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Pack_Btn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.Pack_Btn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Pack_Btn.Location = new System.Drawing.Point(380, 115);
            this.Pack_Btn.Name = "Pack_Btn";
            this.Pack_Btn.Size = new System.Drawing.Size(75, 23);
            this.Pack_Btn.TabIndex = 10;
            this.Pack_Btn.Text = "Pack";
            this.Pack_Btn.TextColor = System.Drawing.Color.White;
            this.Pack_Btn.UseVisualStyleBackColor = false;
            this.Pack_Btn.Click += new System.EventHandler(this.Pack_Btn_Click);
            // 
            // UnPack_Btn
            // 
            this.UnPack_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnPack_Btn.BackColor = System.Drawing.Color.Transparent;
            this.UnPack_Btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.UnPack_Btn.BorderRadius = 10;
            this.UnPack_Btn.BorderSize = 1;
            this.UnPack_Btn.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.UnPack_Btn.FlatAppearance.BorderSize = 0;
            this.UnPack_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.UnPack_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UnPack_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnPack_Btn.ForeColor = System.Drawing.Color.White;
            this.UnPack_Btn.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.UnPack_Btn.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.UnPack_Btn.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UnPack_Btn.Location = new System.Drawing.Point(299, 115);
            this.UnPack_Btn.Name = "UnPack_Btn";
            this.UnPack_Btn.Size = new System.Drawing.Size(75, 23);
            this.UnPack_Btn.TabIndex = 9;
            this.UnPack_Btn.Text = "Un-Pack";
            this.UnPack_Btn.TextColor = System.Drawing.Color.White;
            this.UnPack_Btn.UseVisualStyleBackColor = false;
            this.UnPack_Btn.Click += new System.EventHandler(this.UnPack_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(467, 149);
            this.Controls.Add(this.BrowseARCFolder_Btn);
            this.Controls.Add(this.BrowseARCFile_Btn);
            this.Controls.Add(this.Pack_Btn);
            this.Controls.Add(this.UnPack_Btn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_0);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARC-Enforcer By EternalModz | Version: 1.1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox textBox_0;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox textBox_1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.CheckBox checkBox1;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton UnPack_Btn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton Pack_Btn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton BrowseARCFile_Btn;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton BrowseARCFolder_Btn;
    }
}
