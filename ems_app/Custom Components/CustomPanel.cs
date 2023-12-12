using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ems_app.Custom_Components
{
    public class CustomPanel : Panel
    {
        private int cornerRadius = 10;
        private Color startColor = Color.Blue;
        private Color endColor = Color.Green;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                Invalidate();
            }
        }

        public Color StartColor
        {
            get { return startColor; }
            set
            {
                startColor = value;
                Invalidate();
            }
        }

        public Color EndColor
        {
            get { return endColor; }
            set
            {
                endColor = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = GetRoundRectPath(ClientRectangle, cornerRadius))
            using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, startColor, endColor, LinearGradientMode.Vertical))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
            }
        }

        private GraphicsPath GetRoundRectPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Rectangle arc = new Rectangle(bounds.Location, new Size(diameter, diameter));

            // Top left corner
            path.AddArc(arc, 180, 90);
            path.AddLine(arc.Right, bounds.Top, bounds.Right - radius, bounds.Top);

            // Top right corner
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            path.AddLine(bounds.Right, arc.Bottom, bounds.Right, bounds.Bottom - radius);

            // Bottom right corner
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            path.AddLine(arc.Right, bounds.Bottom, bounds.Left + radius, bounds.Bottom);

            // Bottom left corner
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.AddLine(bounds.Left, arc.Bottom, bounds.Left, bounds.Top + radius);

            path.CloseFigure();
            return path;
        }
    }
}
