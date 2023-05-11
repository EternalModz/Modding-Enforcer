using FUI_Enforcer.Classes;
using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace FUI_Enforcer.Forms
{
    public partial class PicViewerForm : ThemeForm
    {
        public PicViewerForm(Image Image)
        {
            InitializeComponent();
            MainImage = Image;
            pictureBox1.Image = Image;
            var x = MainImage.Width;
            var y = MainImage.Height;
            bool comp = false;
            if (y > 70 && x > 70)
            {
                this.Size = new Size(x, y);
            }
            if (x < 70)
            {
                comp = true;
            }
            else if (y < 70)
            {
                comp = true;
            }
            if (comp == true)
            {
                this.Size = new Size(190, 190);
            }
        }

        readonly Image MainImage;

        private void PicViewer_ResizeEnd(object sender, EventArgs e)
        {
            if (this.Size.Height < 90 || this.Size.Width < 90)
            {
                this.Size = new Size(150, 150);
                throw new Exception("Cant resize windows below 90x90. Minimum size fetched.");
            }
        }

        private void ButtonZoomPlus_Click(object sender, EventArgs e)
        {
            EffectZoom(false);
        }
        int ImgZoomLevel = 1;

        private void EffectZoom(bool down)
        {
            if (down)
            {
                ImgZoomLevel--;
            }
            else if (down is false)
            {
                ImgZoomLevel++;
            }
            if (ImgZoomLevel < 1)
            {
                ImgZoomLevel = 1;

                return;
            }
            if (ImgZoomLevel == 1)
            {
                return;
            }
            else if (ImgZoomLevel > 1)
            {
                var img = Mistycal.UpscaleGraphic(MainImage as Bitmap, ImgZoomLevel, false);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                var x = img.Size.Width;
                var y = img.Height;
                int xx = x + 200;
                int yy = y + 200;
                this.Size = new Size(xx, yy);

            }
        }

        private void PicViewer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Oemplus)
            {
                EffectZoom(false);
            }
            else if (e.KeyChar == (char)Keys.OemMinus)
            {
                EffectZoom(true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZoomMinus_Click(object sender, EventArgs e)
        {
            EffectZoom(true);
        }

        private void InvertImageColorButton_Click(object sender, EventArgs e)
        {
            ImageUtils.ReverseColorRB((Bitmap)MainImage);
            pictureBox1.Image = MainImage;
            ImgZoomLevel = 1;
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            CommonFileDialogCheckBox correctColorCb = new CommonFileDialogCheckBox("correctColorCb",
  "", false);

            ImageFormat[] imageFormats =
            {
                ImageFormat.Png,
                ImageFormat.Jpeg
            };

            CommonSaveFileDialog fileDialog = new CommonSaveFileDialog("")
            {
                Filters =
                {
                    new CommonFileDialogFilter("PNG", "*.png"),
                    new CommonFileDialogFilter("JPEG", "*.jpg;*.jpeg")
                },
                Controls =
                {
                    correctColorCb
                },
                RestoreDirectory = true
            };
            if (fileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (correctColorCb.IsChecked)
                {
                    ImageUtils.ReverseColorRB((Bitmap)MainImage);
                }
                ImageFormat saveFormat = imageFormats[fileDialog.SelectedFileTypeIndex - 1];
                MainImage.Save(fileDialog.FileName, saveFormat);
                //File.WriteAllBytes();
            }

            fileDialog.Dispose();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(MainImage);
        }
    }
}