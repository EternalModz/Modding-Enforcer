
namespace MSSCMP_Studio.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.AboutMSSCMPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Location = new System.Drawing.Point(52, 51);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(281, 135);
            this.CreditsLabel.TabIndex = 18;
            this.CreditsLabel.Text = resources.GetString("CreditsLabel.Text");
            // 
            // AboutMSSCMPLabel
            // 
            this.AboutMSSCMPLabel.AutoSize = true;
            this.AboutMSSCMPLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AboutMSSCMPLabel.Location = new System.Drawing.Point(85, 9);
            this.AboutMSSCMPLabel.Name = "AboutMSSCMPLabel";
            this.AboutMSSCMPLabel.Size = new System.Drawing.Size(215, 28);
            this.AboutMSSCMPLabel.TabIndex = 19;
            this.AboutMSSCMPLabel.Text = "About MSSCMP Studio";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.AboutMSSCMPLabel);
            this.Controls.Add(this.CreditsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MSSCMP Studio - Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Label AboutMSSCMPLabel;
    }
}