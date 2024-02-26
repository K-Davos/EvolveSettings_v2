using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EvolveSettings.Controls
{
    public class EvolveToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;

        //Properties
        [Category("Evolve Code Advance")]
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code Advance")]
        public Color OnToggleColor
        {
            get
            {
                return onToggleColor;
            }

            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code Advance")]
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }

            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code Advance")]
        public Color OffToggleColor
        {
            get
            {
                return offToggleColor;
            }

            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }

        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {

            }
        }

        [Category("Evolve Code Advance")]
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }

            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        //Constructor
        public EvolveToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (Parent != null)
            {
                float
                    tx = -Left,
                    ty = -Top;

                // make adjustments to tx and ty here if your control
                // has a non-client area, borders or similar

                pevent.Graphics.TranslateTransform(tx, ty);

                using (PaintEventArgs pea = new PaintEventArgs(pevent.Graphics, pevent.ClipRectangle))
                {
                    InvokePaintBackground(Parent, pea);
                    InvokePaint(Parent, pea);
                }

                pevent.Graphics.TranslateTransform(-tx, -ty);

                // loop through children of parent which are under ourselves
                int start = Parent.Controls.GetChildIndex(this);
                Rectangle rect = new Rectangle(Left, Top, Width, Height);
                for (int i = Parent.Controls.Count - 1; i > start; i--)
                {
                    Control c = Parent.Controls[i];

                    // skip ...
                    // ... invisible controls
                    // ... or controls that have zero width/height (Autosize Labels without content!)
                    // ... or controls that don't intersect with ourselves
                    if (!c.Visible || c.Width == 0 || c.Height == 0 || !rect.IntersectsWith(new Rectangle(c.Left, c.Top, c.Width, c.Height)))
                        continue;

                    using (Bitmap b = new Bitmap(c.Width, c.Height, pevent.Graphics))
                    {
                        c.DrawToBitmap(b, new Rectangle(0, 0, c.Width, c.Height));

                        tx = c.Left - Left;
                        ty = c.Top - Top;

                        // make adjustments to tx and ty here if your control
                        // has a non-client area, borders or similar

                        pevent.Graphics.TranslateTransform(tx, ty);
                        pevent.Graphics.DrawImageUnscaled(b, new Point(0, 0));
                        pevent.Graphics.TranslateTransform(-tx, -ty);
                    }
                }
            }
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (this.Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}