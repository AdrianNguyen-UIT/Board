using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class Boards : UserControl
    {
        public List<Lists> list = new List<Lists>();
        private System.Windows.Forms.TextBox Name;
        private void Init()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.Name.Location = new System.Drawing.Point(3, 3);
            this.Name.Name = "textBox1";
            this.Name.Size = new System.Drawing.Size(100, 20);
            this.Name.TabIndex = 0;
            // 
            // Boards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Name);
            this.Size = new System.Drawing.Size(190, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public Boards()
        {
            Init();
        }
    }
}
