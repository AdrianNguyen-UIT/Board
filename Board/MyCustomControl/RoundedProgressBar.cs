using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MyCustomControl
{
    public partial class RoundedProgressBar : PictureBox
    {
        private Timer timer = new Timer();

        double pbUnit;
        int pbWIDTH, pbHEIGHT, pbComplete;

        double val;
        Color progressBarColor;
        int cornerRadius;

        Color completeColor = Color.LawnGreen;
        Color progressColor;

        Bitmap bmp;
        Graphics g;

        int denominator = 0;
        int checkedCount = 0;



        public RoundedProgressBar()
        {
            InitializeComponent();
            DoubleBuffered = true;
            val = 0;
            cornerRadius = 10;
        }

        public int Denominator
        {
            get => denominator;
            set
            {
                denominator = value;
                CalculateValue();

                Invalidate();
            }
        }

        public int CheckedCount
        {
            get => checkedCount;
            set
            {
                checkedCount = value;
                CalculateValue();
                Invalidate();
            }
        }

        private void CalculateValue()
        {
            if (denominator != 0)
            {
                Value = checkedCount / (denominator * 1.0) * 100;
            }
            else
            {
                Value = 0;
            }
        }

        public double Value
        {
            get => val;
            set
            {
                val = value;
                if (Convert.ToInt32(val) >= 100)
                {
                    val = 100;
                    progressBarColor = completeColor;
                }
                else
                {
                    progressBarColor = progressColor;
                }
                Invalidate();
            }
        }

        public Color ProgressColor 
        { 
            get => progressColor;
            set
            {
                progressColor = value;
                Invalidate();
            }
        }

        public Color CompleteColor
        {
            get => completeColor;
            set
            {
                completeColor = value;
                Invalidate();
            }
        }

        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                Invalidate();
            }
        }

        private void RecreateRegion()
        {
            var bounds = new Rectangle(ClientRectangle.Location, ClientRectangle.Size);
            bounds.Inflate(-1, -1);
            Region = new Region(RoundedDrawing.RoundedRect(bounds, cornerRadius));
            Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RecreateRegion();
        }

        /// <summary>
        /// start the animation of filling the progress bar  
        /// </summary>
        public void Animate()
        {
            pbWIDTH = Width;
            pbHEIGHT = Height;
            pbUnit = pbWIDTH / 100.0;

            //% [min = 0 max = 100]
            pbComplete = 0;
            bmp = new Bitmap(pbWIDTH, pbHEIGHT);
            
            //timer
            this.timer.Interval = 5;
            this.timer.Tick += new EventHandler(this.t_Tick);
            this.timer.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            FillProgressBar();
            pbComplete += 10;
            if (pbComplete > Convert.ToInt32(Value))
            {
                //dispose
                pbComplete = 0;
                FillProgressBar();
                g.Dispose();
                this.timer.Stop();
            }

        }

        private void FillProgressBar()
        {
            //graphics
            g = Graphics.FromImage(bmp);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = SmoothingMode.HighQuality;


            Rectangle innerBounds = new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHEIGHT);
            Region r = new Region(RoundedDrawing.RoundedRect(innerBounds, cornerRadius));

            g.FillRegion(new SolidBrush(progressBarColor), r);

            //load bitmap in picturebox picboxPB
            this.Image = bmp;
        }

    }
}
