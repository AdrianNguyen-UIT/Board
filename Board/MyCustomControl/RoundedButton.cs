using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace MyCustomControl
{
    class RoundedButton : Button
    {
        private bool isHovering = false;
        private Color buttonColor = Color.White;
        private Color onHoverButtonColor = Color.Gray;
        private int roundedRadius = 10;

        public RoundedButton()
        {
            DoubleBuffered = true;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            MouseEnter += RoundedButton_MouseEnter;
            MouseLeave += RoundedButton_MouseLeave;

        }

        private void RoundedButton_MouseLeave(object sender, EventArgs e)
        {
            isHovering = false;
            Invalidate();
        }

        private void RoundedButton_MouseEnter(object sender, EventArgs e)
        {
            isHovering = true;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Brush brush = new SolidBrush(isHovering ? onHoverButtonColor : buttonColor);
            RoundedDrawing.FillRoundedRectangle(g, brush, new Rectangle(0, 0, Width, Height), roundedRadius);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);

        }

        public Color ButtonColor
        {
            get => buttonColor;
            set
            {
                buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => onHoverButtonColor;
            set
            {
                onHoverButtonColor = value;
                Invalidate();
            }
        }

        public int RoundedRadius
        {
            get => roundedRadius;
            set
            {
                roundedRadius = value;
                Invalidate();
            }
        }
    }
}
