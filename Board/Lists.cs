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
    public partial class Lists : UserControl
    {
        private System.Windows.Forms.TextBox TextboxListName;
        private void Init()
        {
            this.TextboxListName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextboxListName
            // 
            this.TextboxListName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxListName.Location = new System.Drawing.Point(16, 3);
            this.TextboxListName.Name = "TextboxListName";
            this.TextboxListName.Size = new System.Drawing.Size(156, 26);
            this.TextboxListName.TabIndex = 0;
            this.TextboxListName.Text = "List Name";
            this.TextboxListName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TextboxListName);
            this.Name = "Lists";
            this.Size = new System.Drawing.Size(200, 500);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public Lists()
        {
            Init();
        }
    }
}
