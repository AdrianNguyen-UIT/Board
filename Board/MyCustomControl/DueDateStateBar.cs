using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomControl
{
    public partial class DueDateStateBar : UserControl
    {

        private Color onGoingColor;
        private Color dueSoonColor;
        private Color overDueColor;
        private Color completedColor;
        private int state;

        int cornerRadius = 5;

        public DueDateStateBar()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void SetState(int state)
        {
            if (state == 0)
            {
                SetDueDateBar(OngoingColor, "Ongoing");
                State = 0;
            }
            else if (state == 1)
            {
                SetDueDateBar(DueSoonColor, "DueSoon");
                State = 1;
            }
            else if (state == 2)
            {
                SetDueDateBar(OverDueColor, "Overdue");
                State = 2;
            }
            else if (state == 3)
            {
                SetDueDateBar(CompletedColor, "Completed");
                State = 3;
            }
        }

        public void SetDueDateBar(Color color, String str)
        {
            pictureBox.BackColor = color;
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.DrawString($"{str}",
                new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))),
                new SolidBrush(Color.White),
                new PointF(pictureBox.Width / 2 - pictureBox.Height, pictureBox.Height/ 2 - 14));
            pictureBox.Image = bmp;
        }

        private void RecreateRegion()
        {
            var bounds = new Rectangle(ClientRectangle.Location, ClientRectangle.Size);
            Region = new Region(RoundedDrawing.RoundedRect(bounds, cornerRadius));
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RecreateRegion();
        }

        public int State
        {
            get => state;
            set
            {
                state = value;
                Invalidate();
            }
        }

        public Color OngoingColor
        {
            get => onGoingColor;
            set
            {
                onGoingColor = value;
                Invalidate();
            }
        }

        public Color DueSoonColor
        {
            get => dueSoonColor;
            set
            {
                dueSoonColor = value;
                Invalidate();
            }
        }

        public Color OverDueColor
        {
            get => overDueColor;
            set
            {
                overDueColor = value;
                Invalidate();
            }
        }

        public Color CompletedColor
        {
            get => completedColor;
            set
            {
                completedColor= value;
                Invalidate();
            }
        }
        public int CornerRaius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                Invalidate();
            }
        }

    }
}
