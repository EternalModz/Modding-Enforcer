using FUI_Enforcer.Controls;

namespace FUI_Enforcer.Forms
{
    partial class RangeReplacementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeReplacementForm));
            this.LabelToIndex = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupd_ToIndex = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupd_fromIndex = new System.Windows.Forms.NumericUpDown();
            this.CheckBoxCorrecting = new System.Windows.Forms.CheckBox();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.ReplacementImagesListView = new FUI_Enforcer.Controls.ChangableMenuListView();
            this.RplcmImgPreviewIlist = new System.Windows.Forms.ImageList(this.components);
            this.ReplaceRangeGroupBox = new CBH.Controls.CrEaTiiOn_ModernGroupBox();
            this.NewImagesGroupBox = new CBH.Controls.CrEaTiiOn_ModernGroupBox();
            this.AddImageButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.DeleteButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.ReplaceButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.CancelButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_ToIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_fromIndex)).BeginInit();
            this.ReplaceRangeGroupBox.SuspendLayout();
            this.NewImagesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelToIndex
            // 
            this.LabelToIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelToIndex.AutoSize = true;
            this.LabelToIndex.BackColor = System.Drawing.Color.Transparent;
            this.LabelToIndex.ForeColor = System.Drawing.Color.White;
            this.LabelToIndex.Location = new System.Drawing.Point(140, 97);
            this.LabelToIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelToIndex.Name = "LabelToIndex";
            this.LabelToIndex.Size = new System.Drawing.Size(62, 13);
            this.LabelToIndex.TabIndex = 5;
            this.LabelToIndex.Text = "To Index: 0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Image Count:";
            // 
            // nupd_ToIndex
            // 
            this.nupd_ToIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupd_ToIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupd_ToIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupd_ToIndex.ForeColor = System.Drawing.Color.White;
            this.nupd_ToIndex.Location = new System.Drawing.Point(108, 65);
            this.nupd_ToIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nupd_ToIndex.Maximum = new decimal(new int[] {
            317,
            0,
            0,
            0});
            this.nupd_ToIndex.Name = "nupd_ToIndex";
            this.nupd_ToIndex.Size = new System.Drawing.Size(215, 22);
            this.nupd_ToIndex.TabIndex = 3;
            this.nupd_ToIndex.ValueChanged += new System.EventHandler(this.nupd_ToIndex_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Index: :";
            // 
            // nupd_fromIndex
            // 
            this.nupd_fromIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nupd_fromIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.nupd_fromIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nupd_fromIndex.ForeColor = System.Drawing.Color.White;
            this.nupd_fromIndex.Location = new System.Drawing.Point(108, 35);
            this.nupd_fromIndex.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nupd_fromIndex.Maximum = new decimal(new int[] {
            317,
            0,
            0,
            0});
            this.nupd_fromIndex.Name = "nupd_fromIndex";
            this.nupd_fromIndex.Size = new System.Drawing.Size(215, 22);
            this.nupd_fromIndex.TabIndex = 1;
            this.nupd_fromIndex.ValueChanged += new System.EventHandler(this.nupd_fromIndex_ValueChanged);
            // 
            // CheckBoxCorrecting
            // 
            this.CheckBoxCorrecting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxCorrecting.AutoSize = true;
            this.CheckBoxCorrecting.ForeColor = System.Drawing.Color.White;
            this.CheckBoxCorrecting.Location = new System.Drawing.Point(462, 171);
            this.CheckBoxCorrecting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CheckBoxCorrecting.Name = "CheckBoxCorrecting";
            this.CheckBoxCorrecting.Size = new System.Drawing.Size(111, 17);
            this.CheckBoxCorrecting.TabIndex = 5;
            this.CheckBoxCorrecting.Text = "Correcting Color";
            this.CheckBoxCorrecting.UseVisualStyleBackColor = true;
            this.CheckBoxCorrecting.CheckedChanged += new System.EventHandler(this.CheckBoxCorrecting_CheckedChanged);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLeft.Enabled = false;
            this.BtnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLeft.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.BtnLeft.ForeColor = System.Drawing.Color.White;
            this.BtnLeft.Location = new System.Drawing.Point(462, 194);
            this.BtnLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(123, 42);
            this.BtnLeft.TabIndex = 4;
            this.BtnLeft.Text = "<";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRight.Enabled = false;
            this.BtnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRight.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.BtnRight.ForeColor = System.Drawing.Color.White;
            this.BtnRight.Location = new System.Drawing.Point(591, 194);
            this.BtnRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(123, 42);
            this.BtnRight.TabIndex = 3;
            this.BtnRight.Text = ">";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // ReplacementImagesListView
            // 
            this.ReplacementImagesListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ReplacementImagesListView.ForeColor = System.Drawing.Color.White;
            this.ReplacementImagesListView.HideSelection = false;
            this.ReplacementImagesListView.Location = new System.Drawing.Point(28, 32);
            this.ReplacementImagesListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReplacementImagesListView.MultiSelectedContextMenuStrip = null;
            this.ReplacementImagesListView.Name = "ReplacementImagesListView";
            this.ReplacementImagesListView.SingleSelectedContextMenuStrip = null;
            this.ReplacementImagesListView.Size = new System.Drawing.Size(411, 147);
            this.ReplacementImagesListView.TabIndex = 0;
            this.ReplacementImagesListView.UseCompatibleStateImageBehavior = false;
            this.ReplacementImagesListView.SelectedIndexChanged += new System.EventHandler(this.ReplacementImagesListView_SelectedIndexChanged);
            // 
            // RplcmImgPreviewIlist
            // 
            this.RplcmImgPreviewIlist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.RplcmImgPreviewIlist.ImageSize = new System.Drawing.Size(32, 32);
            this.RplcmImgPreviewIlist.TransparentColor = System.Drawing.Color.Turquoise;
            // 
            // ReplaceRangeGroupBox
            // 
            this.ReplaceRangeGroupBox.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ReplaceRangeGroupBox.Colors = new CBH_Ultimate_Theme_Library.Bloom[0];
            this.ReplaceRangeGroupBox.Controls.Add(this.LabelToIndex);
            this.ReplaceRangeGroupBox.Controls.Add(this.nupd_fromIndex);
            this.ReplaceRangeGroupBox.Controls.Add(this.label2);
            this.ReplaceRangeGroupBox.Controls.Add(this.label1);
            this.ReplaceRangeGroupBox.Controls.Add(this.nupd_ToIndex);
            this.ReplaceRangeGroupBox.CornerRadius = 15;
            this.ReplaceRangeGroupBox.Customization = "";
            this.ReplaceRangeGroupBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ReplaceRangeGroupBox.GroupBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ReplaceRangeGroupBox.Image = null;
            this.ReplaceRangeGroupBox.LBlendColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ReplaceRangeGroupBox.Location = new System.Drawing.Point(28, 189);
            this.ReplaceRangeGroupBox.Movable = true;
            this.ReplaceRangeGroupBox.Name = "ReplaceRangeGroupBox";
            this.ReplaceRangeGroupBox.NoRounding = false;
            this.ReplaceRangeGroupBox.Sizable = true;
            this.ReplaceRangeGroupBox.Size = new System.Drawing.Size(343, 120);
            this.ReplaceRangeGroupBox.SmartBounds = true;
            this.ReplaceRangeGroupBox.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ReplaceRangeGroupBox.TabIndex = 7;
            this.ReplaceRangeGroupBox.Text = "Replace Range";
            this.ReplaceRangeGroupBox.TextColor = System.Drawing.Color.White;
            this.ReplaceRangeGroupBox.TransparencyKey = System.Drawing.Color.Empty;
            this.ReplaceRangeGroupBox.Transparent = false;
            // 
            // NewImagesGroupBox
            // 
            this.NewImagesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewImagesGroupBox.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.NewImagesGroupBox.Colors = new CBH_Ultimate_Theme_Library.Bloom[0];
            this.NewImagesGroupBox.Controls.Add(this.AddImageButton);
            this.NewImagesGroupBox.Controls.Add(this.CheckBoxCorrecting);
            this.NewImagesGroupBox.Controls.Add(this.DeleteButton);
            this.NewImagesGroupBox.Controls.Add(this.ReplaceRangeGroupBox);
            this.NewImagesGroupBox.Controls.Add(this.ReplacementImagesListView);
            this.NewImagesGroupBox.Controls.Add(this.BtnLeft);
            this.NewImagesGroupBox.Controls.Add(this.BtnRight);
            this.NewImagesGroupBox.CornerRadius = 15;
            this.NewImagesGroupBox.Customization = "";
            this.NewImagesGroupBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.NewImagesGroupBox.GroupBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NewImagesGroupBox.Image = null;
            this.NewImagesGroupBox.LBlendColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.NewImagesGroupBox.Location = new System.Drawing.Point(9, 12);
            this.NewImagesGroupBox.Movable = true;
            this.NewImagesGroupBox.Name = "NewImagesGroupBox";
            this.NewImagesGroupBox.NoRounding = false;
            this.NewImagesGroupBox.Sizable = true;
            this.NewImagesGroupBox.Size = new System.Drawing.Size(743, 318);
            this.NewImagesGroupBox.SmartBounds = true;
            this.NewImagesGroupBox.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.NewImagesGroupBox.TabIndex = 8;
            this.NewImagesGroupBox.Text = "New Images";
            this.NewImagesGroupBox.TextColor = System.Drawing.Color.White;
            this.NewImagesGroupBox.TransparencyKey = System.Drawing.Color.Empty;
            this.NewImagesGroupBox.Transparent = false;
            // 
            // AddImageButton
            // 
            this.AddImageButton.BackColor = System.Drawing.Color.Transparent;
            this.AddImageButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.AddImageButton.BorderRadius = 10;
            this.AddImageButton.BorderSize = 1;
            this.AddImageButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AddImageButton.FlatAppearance.BorderSize = 0;
            this.AddImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AddImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AddImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddImageButton.ForeColor = System.Drawing.Color.White;
            this.AddImageButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.AddImageButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.AddImageButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AddImageButton.Location = new System.Drawing.Point(591, 116);
            this.AddImageButton.Name = "AddImageButton";
            this.AddImageButton.Size = new System.Drawing.Size(123, 40);
            this.AddImageButton.TabIndex = 20;
            this.AddImageButton.Text = "Add Image";
            this.AddImageButton.TextColor = System.Drawing.Color.White;
            this.AddImageButton.UseVisualStyleBackColor = false;
            this.AddImageButton.Click += new System.EventHandler(this.AddImageButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BorderRadius = 10;
            this.DeleteButton.BorderSize = 1;
            this.DeleteButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.DeleteButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeleteButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DeleteButton.Location = new System.Drawing.Point(462, 116);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 40);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextColor = System.Drawing.Color.White;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.BackColor = System.Drawing.Color.Transparent;
            this.ReplaceButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ReplaceButton.BorderRadius = 10;
            this.ReplaceButton.BorderSize = 1;
            this.ReplaceButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ReplaceButton.FlatAppearance.BorderSize = 0;
            this.ReplaceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ReplaceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ReplaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReplaceButton.ForeColor = System.Drawing.Color.White;
            this.ReplaceButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ReplaceButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ReplaceButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ReplaceButton.Location = new System.Drawing.Point(383, 346);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(123, 40);
            this.ReplaceButton.TabIndex = 18;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.TextColor = System.Drawing.Color.White;
            this.ReplaceButton.UseVisualStyleBackColor = false;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.CancelButton.BorderRadius = 10;
            this.CancelButton.BorderSize = 1;
            this.CancelButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.CancelButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.CancelButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CancelButton.Location = new System.Drawing.Point(254, 346);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(123, 40);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextColor = System.Drawing.Color.White;
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RangeReplacementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(760, 398);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NewImagesGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "RangeReplacementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Range Replacement";
            ((System.ComponentModel.ISupportInitialize)(this.nupd_ToIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupd_fromIndex)).EndInit();
            this.ReplaceRangeGroupBox.ResumeLayout(false);
            this.ReplaceRangeGroupBox.PerformLayout();
            this.NewImagesGroupBox.ResumeLayout(false);
            this.NewImagesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupd_ToIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupd_fromIndex;
        private ChangableMenuListView ReplacementImagesListView;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.ImageList RplcmImgPreviewIlist;
        private System.Windows.Forms.CheckBox CheckBoxCorrecting;
        private System.Windows.Forms.Label LabelToIndex;
        private CBH.Controls.CrEaTiiOn_ModernGroupBox ReplaceRangeGroupBox;
        private CBH.Controls.CrEaTiiOn_ModernGroupBox NewImagesGroupBox;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton AddImageButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton DeleteButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton ReplaceButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton CancelButton;
    }
}