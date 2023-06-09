﻿#region Imports

using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#endregion

namespace CBH.Controls
{
    #region CrEaTiiOn_ModernTabPage

    public class CrEaTiiOn_ModernTabPage : TabControl
    {
        private SmoothingMode _SmoothingType = SmoothingMode.HighSpeed;
        public SmoothingMode SmoothingType
        {
            get => _SmoothingType;
            set
            {
                _SmoothingType = value;
                Invalidate();
            }
        }

        private CompositingQuality _CompositingQualityType = CompositingQuality.HighSpeed;
        public CompositingQuality CompositingQualityType
        {
            get => _CompositingQualityType;
            set
            {
                _CompositingQualityType = value;
                Invalidate();
            }
        }

        private CompositingMode _CompositingType = CompositingMode.SourceOver;
        public CompositingMode CompositingType
        {
            get => _CompositingType;
            set
            {
                _CompositingType = value;
                Invalidate();
            }
        }

        private InterpolationMode _InterpolationType = InterpolationMode.HighQualityBicubic;
        public InterpolationMode InterpolationType
        {
            get => _InterpolationType;
            set
            {
                _InterpolationType = value;
                Invalidate();
            }
        }

        private StringAlignment _StringType = StringAlignment.Near;
        public StringAlignment StringType
        {
            get => _StringType;
            set
            {
                _StringType = value;
                Invalidate();
            }
        }

        private Color _FrameColor = Color.FromArgb(20, 20, 20);
        public Color FrameColor
        {
            get => _FrameColor;
            set
            {
                _FrameColor = value;
                Invalidate();
            }
        }

        private Color _PageColor = Color.FromArgb(20, 20, 20);
        public Color PageColor
        {
            get => _PageColor;
            set
            {
                _PageColor = value;
                Invalidate();
            }
        }

        private Color _ActiveForeColor = Color.FromArgb(250, 36, 38);
        public Color ActiveForeColor
        {
            get => _ActiveForeColor;
            set
            {
                _ActiveForeColor = value;
                Invalidate();
            }
        }

        private Color _NormalForeColor = Color.White;
        public Color NormalForeColor
        {
            get => _NormalForeColor;
            set
            {
                _NormalForeColor = value;
                Invalidate();
            }
        }

        private Color _ControlBackColor = Color.FromArgb(15, 15, 15);
        public Color ControlBackColor
        {
            get => _ControlBackColor;
            set
            {
                _ControlBackColor = value;
                Invalidate();
            }
        }

        private Color _LineColor = Color.FromArgb(250, 36, 38);
        public Color LineColor
        {
            get => _LineColor;
            set
            {
                _LineColor = value;
                Invalidate();
            }
        }

        private Color _ActiveTabColor = Color.FromArgb(15, 15, 15);
        public Color ActiveTabColor
        {
            get => _ActiveTabColor;
            set
            {
                _ActiveTabColor = value;
                Invalidate();
            }
        }

        private Color _TabColor = Color.FromArgb(20, 20, 20);
        public Color TabColor
        {
            get => _TabColor;
            set
            {
                _TabColor = value;
                Invalidate();
            }
        }

        private Color _ActiveLineTabColor = Color.FromArgb(250, 36, 38);
        public Color ActiveLineTabColor
        {
            get => _ActiveLineTabColor;
            set
            {
                _ActiveLineTabColor = value;
                Invalidate();
            }
        }

        private Color _LineTabColor = Color.FromArgb(20, 20, 20);
        public Color LineTabColor
        {
            get => _LineTabColor;
            set
            {
                _LineTabColor = value;
                Invalidate();
            }
        }

        public CrEaTiiOn_ModernTabPage()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer, true);

            DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            ItemSize = new(44, 135);
            DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        protected override void CreateHandle()
        {
            base.CreateHandle();

            base.DoubleBuffered = true;
            SizeMode = TabSizeMode.Fixed;
            Appearance = TabAppearance.Normal;
            Alignment = TabAlignment.Left;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            if (e.Control is CrEaTiiOn_ModernTabPage)
            {
                IEnumerator Enumerator;
                try
                {
                    Enumerator = Controls.GetEnumerator();
                    while (Enumerator.MoveNext())
                    {
                        CrEaTiiOn_ModernTabPage Current = (CrEaTiiOn_ModernTabPage)Enumerator.Current;
                        Current = new CrEaTiiOn_ModernTabPage();
                    }
                }
                finally
                {
                    e.Control.BackColor = FrameColor;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Bitmap B = new(Width, Height);
            Graphics G = Graphics.FromImage(B);

            Graphics _Graphics = G;

            _Graphics.Clear(FrameColor);
            _Graphics.SmoothingMode = SmoothingType;
            _Graphics.CompositingQuality = CompositingQualityType;
            _Graphics.CompositingMode = CompositingType;

            // Draw tab selector background
            _Graphics.FillRectangle(new SolidBrush(ControlBackColor), new Rectangle(-5, 0, ItemSize.Height + 4, Height));
            // Draw vertical line at the end of the tab selector rectangle
            _Graphics.DrawLine(new(LineColor), ItemSize.Height - 1, 0, ItemSize.Height - 1, Height);

            for (int TabIndex = 0; TabIndex <= TabCount - 1; TabIndex++)
            {
                if (TabIndex == SelectedIndex)
                {
                    Rectangle TabRect = new(new Point(GetTabRect(TabIndex).Location.X - 2, GetTabRect(TabIndex).Location.Y - 2), new Size(GetTabRect(TabIndex).Width + 3, GetTabRect(TabIndex).Height - 8));

                    // Draw background of the selected tab
                    _Graphics.FillRectangle(new SolidBrush(ActiveTabColor), TabRect.X, TabRect.Y, TabRect.Width - 4, TabRect.Height + 3);
                    // Draw a tab highlighter on the background of the selected tab
                    Rectangle TabHighlighter = new(new Point(GetTabRect(TabIndex).X - 2, GetTabRect(TabIndex).Location.Y - (TabIndex == 0 ? 1 : 1)), new Size(4, GetTabRect(TabIndex).Height - 7));
                    _Graphics.FillRectangle(new SolidBrush(ActiveLineTabColor), TabHighlighter);
                    // Draw tab text
                    _Graphics.DrawString(TabPages[TabIndex].Text, new Font(Font.FontFamily, Font.Size, Font.Style), new SolidBrush(ActiveForeColor), new Rectangle(TabRect.Left + 40, TabRect.Top + 8, TabRect.Width - 40, TabRect.Height), new StringFormat { Alignment = StringType });

                    if (ImageList != null)
                    {
                        int Index = TabPages[TabIndex].ImageIndex;
                        if (!(Index == -1))
                        {
                            _Graphics.DrawImage(ImageList.Images[TabPages[TabIndex].ImageIndex], TabRect.X + 9, TabRect.Y + 6, 24, 24);
                        }
                    }
                }
                else
                {
                    Rectangle TabRect = new(new Point(GetTabRect(TabIndex).Location.X - 2, GetTabRect(TabIndex).Location.Y - 2), new Size(GetTabRect(TabIndex).Width + 3, GetTabRect(TabIndex).Height - 8));

                    // Draw background of the tab
                    _Graphics.FillRectangle(new SolidBrush(TabColor), TabRect.X, TabRect.Y, TabRect.Width - 4, TabRect.Height + 3);
                    // Draw a tab highlighter on the background of the tab
                    Rectangle TabHighlighter = new(new Point(GetTabRect(TabIndex).X - 2, GetTabRect(TabIndex).Location.Y - (TabIndex == 0 ? 1 : 1)), new Size(4, GetTabRect(TabIndex).Height - 7));
                    _Graphics.FillRectangle(new SolidBrush(LineTabColor), TabHighlighter);

                    _Graphics.DrawString(TabPages[TabIndex].Text, new Font(Font.FontFamily, Font.Size, Font.Style), new SolidBrush(NormalForeColor), new Rectangle(TabRect.Left + 40, TabRect.Top + 8, TabRect.Width - 40, TabRect.Height), new StringFormat { Alignment = StringType });

                    if (ImageList != null)
                    {
                        int Index = TabPages[TabIndex].ImageIndex;
                        if (!(Index == -1))
                        {
                            _Graphics.DrawImage(ImageList.Images[TabPages[TabIndex].ImageIndex], TabRect.X + 9, TabRect.Y + 6, 24, 24);
                        }
                    }

                }
            }
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationType;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();

            foreach (System.Windows.Forms.TabPage Page in TabPages)
            {
                Page.BackColor = PageColor;
            }
        }
    }

    #endregion
}