using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomControls.EvolveControls
{
    public class EvolveButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point point);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0084)
            {

                Point screenPoint = new Point();
                GetCursorPos(ref screenPoint);
                m.Result = (IntPtr)9;

                return;
            }
            else if (m.Msg == 0x00a1)
            {
                Form form = FindForm();
                if (form.WindowState == FormWindowState.Maximized)
                {
                    form.WindowState = FormWindowState.Normal;
                }
                else
                {
                    form.WindowState = FormWindowState.Maximized;
                }
                return;
            }
            base.WndProc(ref m);
        }

        //Properties
        [Category("Evolve Code")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Evolve Code")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Evolve Code")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public EvolveButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
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
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}