﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace MyCustomControl
{
    class RoundedLabel : Label
    {
        private int roundedRadius = 10;
        Color labelColor = Color.Gray;

        public RoundedLabel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Brush brush = new SolidBrush(labelColor);

            RoundedDrawing.FillRoundedRectangle(g, brush, new Rectangle(0, 0, Width, Height), roundedRadius);

            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, new SolidBrush(ForeColor), (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);

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

        public Color LabelColor
        {
            get => labelColor;
            set
            {
                labelColor = value;
                Invalidate();
            }
        }
    }
}