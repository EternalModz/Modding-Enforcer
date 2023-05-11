namespace FUI_Enforcer.Forms
{
    partial class ImageColorationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageColorationForm));
            this.PreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelBrightness = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TrackbarBrightness = new System.Windows.Forms.NumericUpDown();
            this.TrackbarContrast = new System.Windows.Forms.NumericUpDown();
            this.TrackbarGamma = new System.Windows.Forms.NumericUpDown();
            this.TrackbarSaturation = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.PreviewButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSaturation)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewPictureBox
            // 
            this.PreviewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPictureBox.Location = new System.Drawing.Point(17, 15);
            this.PreviewPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PreviewPictureBox.Name = "PreviewPictureBox";
            this.PreviewPictureBox.Size = new System.Drawing.Size(324, 177);
            this.PreviewPictureBox.TabIndex = 0;
            this.PreviewPictureBox.TabStop = false;
            // 
            // LabelBrightness
            // 
            this.LabelBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBrightness.AutoSize = true;
            this.LabelBrightness.Location = new System.Drawing.Point(20, 208);
            this.LabelBrightness.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBrightness.Name = "LabelBrightness";
            this.LabelBrightness.Size = new System.Drawing.Size(65, 15);
            this.LabelBrightness.TabIndex = 4;
            this.LabelBrightness.Text = "Brightness:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contrast:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gamma:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saturation:";
            // 
            // TrackbarBrightness
            // 
            this.TrackbarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackbarBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TrackbarBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrackbarBrightness.DecimalPlaces = 6;
            this.TrackbarBrightness.ForeColor = System.Drawing.Color.White;
            this.TrackbarBrightness.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.TrackbarBrightness.Location = new System.Drawing.Point(95, 208);
            this.TrackbarBrightness.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackbarBrightness.Name = "TrackbarBrightness";
            this.TrackbarBrightness.Size = new System.Drawing.Size(244, 23);
            this.TrackbarBrightness.TabIndex = 11;
            // 
            // TrackbarContrast
            // 
            this.TrackbarContrast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackbarContrast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TrackbarContrast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrackbarContrast.DecimalPlaces = 6;
            this.TrackbarContrast.ForeColor = System.Drawing.Color.White;
            this.TrackbarContrast.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.TrackbarContrast.Location = new System.Drawing.Point(95, 238);
            this.TrackbarContrast.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackbarContrast.Name = "TrackbarContrast";
            this.TrackbarContrast.Size = new System.Drawing.Size(244, 23);
            this.TrackbarContrast.TabIndex = 12;
            // 
            // TrackbarGamma
            // 
            this.TrackbarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackbarGamma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TrackbarGamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrackbarGamma.DecimalPlaces = 6;
            this.TrackbarGamma.ForeColor = System.Drawing.Color.White;
            this.TrackbarGamma.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.TrackbarGamma.Location = new System.Drawing.Point(95, 268);
            this.TrackbarGamma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackbarGamma.Name = "TrackbarGamma";
            this.TrackbarGamma.Size = new System.Drawing.Size(244, 23);
            this.TrackbarGamma.TabIndex = 13;
            // 
            // TrackbarSaturation
            // 
            this.TrackbarSaturation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackbarSaturation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TrackbarSaturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TrackbarSaturation.DecimalPlaces = 6;
            this.TrackbarSaturation.ForeColor = System.Drawing.Color.White;
            this.TrackbarSaturation.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.TrackbarSaturation.Location = new System.Drawing.Point(95, 298);
            this.TrackbarSaturation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TrackbarSaturation.Name = "TrackbarSaturation";
            this.TrackbarSaturation.Size = new System.Drawing.Size(244, 23);
            this.TrackbarSaturation.TabIndex = 14;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ResetButton.BorderRadius = 10;
            this.ResetButton.BorderSize = 1;
            this.ResetButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.ResetButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ResetButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ResetButton.Location = new System.Drawing.Point(53, 341);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(123, 40);
            this.ResetButton.TabIndex = 15;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextColor = System.Drawing.Color.White;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PreviewButton
            // 
            this.PreviewButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviewButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.PreviewButton.BorderRadius = 10;
            this.PreviewButton.BorderSize = 1;
            this.PreviewButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PreviewButton.FlatAppearance.BorderSize = 0;
            this.PreviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewButton.ForeColor = System.Drawing.Color.White;
            this.PreviewButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PreviewButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.PreviewButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PreviewButton.Location = new System.Drawing.Point(182, 341);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(123, 40);
            this.PreviewButton.TabIndex = 16;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.TextColor = System.Drawing.Color.White;
            this.PreviewButton.UseVisualStyleBackColor = false;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // ImageColorationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(358, 393);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TrackbarSaturation);
            this.Controls.Add(this.TrackbarGamma);
            this.Controls.Add(this.TrackbarContrast);
            this.Controls.Add(this.TrackbarBrightness);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelBrightness);
            this.Controls.Add(this.PreviewPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ImageColorationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Coloration Editor";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackbarSaturation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewPictureBox;
        private System.Windows.Forms.Label LabelBrightness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown TrackbarBrightness;
        private System.Windows.Forms.NumericUpDown TrackbarContrast;
        private System.Windows.Forms.NumericUpDown TrackbarGamma;
        private System.Windows.Forms.NumericUpDown TrackbarSaturation;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton ResetButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton PreviewButton;
    }
}