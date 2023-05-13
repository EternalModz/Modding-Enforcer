
namespace FUI_Enforcer.Forms
{
    partial class PicViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicViewerForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CopyButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.CloseButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.ExtractButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.InvertImageColorButton = new CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(204, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.CopyButton.BorderRadius = 10;
            this.CopyButton.BorderSize = 1;
            this.CopyButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.ForeColor = System.Drawing.Color.White;
            this.CopyButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.CopyButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.CopyButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CopyButton.Location = new System.Drawing.Point(14, 224);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(166, 40);
            this.CopyButton.TabIndex = 19;
            this.CopyButton.Text = "Copy";
            this.CopyButton.TextColor = System.Drawing.Color.White;
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderRadius = 10;
            this.CloseButton.BorderSize = 1;
            this.CloseButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.CloseButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.CloseButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseButton.Location = new System.Drawing.Point(14, 270);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(166, 40);
            this.CloseButton.TabIndex = 18;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextColor = System.Drawing.Color.White;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExtractButton
            // 
            this.ExtractButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExtractButton.BackColor = System.Drawing.Color.Transparent;
            this.ExtractButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.ExtractButton.BorderRadius = 10;
            this.ExtractButton.BorderSize = 1;
            this.ExtractButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExtractButton.FlatAppearance.BorderSize = 0;
            this.ExtractButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExtractButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtractButton.ForeColor = System.Drawing.Color.White;
            this.ExtractButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExtractButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ExtractButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExtractButton.Location = new System.Drawing.Point(14, 178);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(166, 40);
            this.ExtractButton.TabIndex = 17;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.TextColor = System.Drawing.Color.White;
            this.ExtractButton.UseVisualStyleBackColor = false;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // InvertImageColorButton
            // 
            this.InvertImageColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InvertImageColorButton.BackColor = System.Drawing.Color.Transparent;
            this.InvertImageColorButton.BackgroundColor = System.Drawing.Color.Transparent;
            this.InvertImageColorButton.BorderRadius = 10;
            this.InvertImageColorButton.BorderSize = 1;
            this.InvertImageColorButton.ClickedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InvertImageColorButton.FlatAppearance.BorderSize = 0;
            this.InvertImageColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InvertImageColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InvertImageColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvertImageColorButton.ForeColor = System.Drawing.Color.White;
            this.InvertImageColorButton.GradientColorPrimary = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.InvertImageColorButton.GradientColorSecondary = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.InvertImageColorButton.HoverOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.InvertImageColorButton.Location = new System.Drawing.Point(14, 132);
            this.InvertImageColorButton.Name = "InvertImageColorButton";
            this.InvertImageColorButton.Size = new System.Drawing.Size(166, 40);
            this.InvertImageColorButton.TabIndex = 16;
            this.InvertImageColorButton.Text = "Invert Image Color";
            this.InvertImageColorButton.TextColor = System.Drawing.Color.White;
            this.InvertImageColorButton.UseVisualStyleBackColor = false;
            this.InvertImageColorButton.Click += new System.EventHandler(this.InvertImageColorButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.InvertImageColorButton);
            this.panel1.Controls.Add(this.CopyButton);
            this.panel1.Controls.Add(this.ExtractButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 443);
            this.panel1.TabIndex = 20;
            // 
            // PicViewerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(789, 482);
            this.Name = "PicViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.ResizeEnd += new System.EventHandler(this.PicViewer_ResizeEnd);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PicViewer_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton InvertImageColorButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton ExtractButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton CopyButton;
        private CBH.Ultimate.Controls.CrEaTiiOn_Ultimate_GradientButton CloseButton;
        private System.Windows.Forms.Panel panel1;
    }
}