using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EvolveSettings.Controls
{
    public class EvolveExtendedPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        public EvolveExtendedPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                     ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            DoubleBuffered = false;
        }

        private int opacity = 1;

        [DefaultValue(1)]
        public int Opacity
        {
            get => opacity;
            set
            {
                if (value < 0 || value > 255) throw new ArgumentException("value must be between 0 and 255");
                opacity = value;
                if (DesignMode) FindForm().Refresh();
                Invalidate();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (var brush = new SolidBrush(Color.FromArgb(opacity, BackColor)))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);

            }
        }
    }
}