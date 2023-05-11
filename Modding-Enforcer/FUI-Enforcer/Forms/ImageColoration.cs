using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace FUI_Enforcer.Forms
{
    public partial class ImageColorationForm : ThemeForm
    {
        Image _base = null;
        public ImageColorationForm(Image @base)
        {
            InitializeComponent();
            PreviewPictureBox.Image = _base = @base;

        }

        private Bitmap SetBitmapConfiguration(in Bitmap original, float brightness = 1.0f, float contrast = 2.0f, float gamma = 1.0f)
        {
            Bitmap originalImage = original, adjustedImage = original;

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
        new float[] {contrast, 0, 0, 0, 0}, // scale red
        new float[] {0, contrast, 0, 0, 0}, // scale green
        new float[] {0, 0, contrast, 0, 0}, // scale blue
        new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
        new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(adjustedImage);
            g.DrawImage(originalImage, new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                , 0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes);
            return adjustedImage;
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {

        }

        private void ImageColoration_Load(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.PreviewPictureBox.Image = _base;
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            Bitmap adjusted = (Bitmap)_base.Clone();

            SetBitmapConfiguration((Bitmap)(PreviewPictureBox.Image = adjusted),
                 (float)TrackbarBrightness.Value,
                 (float)TrackbarContrast.Value,
                 (float)TrackbarGamma.Value);
        }
    }
}
