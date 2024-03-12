using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EvolveSettings.Controls
{
    public sealed class EvolveListView : ListBox
    {
        private int radius = 0;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
        public EvolveListView()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.BorderStyle = BorderStyle.None;

            this.MeasureItem += EvolveListBox_MeasureItem;
            this.DrawItem += EvolveListBox_DrawItem;
        }

        private void EvolveListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            if (this.Items.Count <= 0) return;

            e.DrawBackground();

            Brush myBrush = new SolidBrush(Color.White);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
            }

            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), e.Bounds);

            }

            e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void EvolveListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = this.Font.Height;
        }
    }
}