using FUI_Enforcer.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FUI_Enforcer.Forms
{
    public partial class RangeReplacementForm : ThemeForm
    {
        private int? _selectedFrom;
        private int? _selectedCount;
        private List<Bitmap> _repImages;
        private bool _correcting = false;
        public Pair<int> FromCountResult { get => new Pair<int>(_selectedFrom ?? 0, _selectedCount ?? 0); }

        public RangeReplacementForm(MainForm sender)
        {
            InitializeComponent();
            var selection = (sender).GetSelectedRange();
            this.nupd_fromIndex.Value = selection.X != -1 ? selection.X : 361;
            this.nupd_ToIndex.Value = selection.Y != -1 ? selection.Y + 1 : 361;
            this.Text = $"{sender.FileName.GetFileName()} | Replacing {_selectedCount} images.";

            _repImages = new List<Bitmap>();
        }
        public DialogResult ShowDialog(out Pair<int> FromCountResult, out Bitmap[] toReplace, out bool Correcting)
        {
            var dr = base.ShowDialog();
            FromCountResult = this.FromCountResult;
            toReplace = GetResultImages();
            Correcting = _correcting;
            return dr;
        }
        public Bitmap[] GetResultImages() => _repImages.ToArray();
        protected RangeReplacementForm() { }
        void CheckValues()
        {
            _selectedFrom = (int)nupd_fromIndex.Value;
            _selectedCount = (int)nupd_ToIndex.Value;
            nupd_fromIndex.Maximum = (int)nupd_fromIndex.Value;
            DeleteButton.Enabled = GetSelectedIndex() != -1;
            AddImageButton.Enabled = GetImagesCount() < _selectedCount;
            BtnLeft.Enabled = BtnRight.Enabled = GetSelectedIndex() != -1 & ReplacementImagesListView.Items.Count > 1;
            ReplaceButton.Enabled = _repImages?.Count == _selectedCount - 1 || _repImages?.Count == _selectedCount;
            LabelToIndex.Text = "To Index: " + (_selectedFrom + _selectedCount);
        }
        private int GetImagesCount() => ReplacementImagesListView.Items.Count;
        private int GetSelectedIndex()
        {
            return ReplacementImagesListView.SelectedItems.Count != 0 ?
                ReplacementImagesListView.SelectedIndices[0] : -1;
        }
        private void nupd_fromIndex_ValueChanged(object sender, EventArgs e) => CheckValues();
        private void nupd_ToIndex_ValueChanged(object sender, EventArgs e) => CheckValues();
        private string[] OfdRequest(string title, string filter, string ext, bool autoExt)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = filter;
            ofd.AddExtension = autoExt;
            ofd.DefaultExt = ext;
            ofd.Title = title;
            ofd.Multiselect = true;
            if (ofd.ShowDialog() is DialogResult.OK) return ofd.FileNames;
            else ofd.Dispose();
            return null;
        }
        private void ButtonAddImage_Click(object sender, EventArgs e)
        {

        }
        private void RemoveReplacementImage(int index)
        {
            _repImages.RemoveAt(index);
            RplcmImgPreviewIlist.Images.RemoveAt(index);
            ReplacementImagesListView.Items.RemoveAt(index);
            CheckValues();
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ReplacementImagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void ButtonReplace_Click(object sender, EventArgs e)
        {

        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {

        }

        private void BtnRight_Click(object sender, EventArgs e)
        {

        }

        private void CheckBoxCorrecting_CheckedChanged(object sender, EventArgs e)
        {
            _correcting = this.CheckBoxCorrecting.Checked;
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddImageButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
