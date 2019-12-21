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
    public partial class Card : UserControl
    {
        private System.Windows.Forms.Button CardColorButton;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.Button DeleteCardButton;
        private System.Windows.Forms.Button EditButton;
        private void Init()
        {
            this.CardColorButton = new System.Windows.Forms.Button();
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.DeleteCardButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CardColorButton
            // 
            this.CardColorButton.Location = new System.Drawing.Point(108, 3);
            this.CardColorButton.Name = "CardColorButton";
            this.CardColorButton.Size = new System.Drawing.Size(55, 32);
            this.CardColorButton.TabIndex = 0;
            this.CardColorButton.Text = "Color";
            this.CardColorButton.UseVisualStyleBackColor = true;
            this.CardColorButton.Click += new System.EventHandler(this.CardColorButton_Click);
            // 
            // CardNameTB
            // 
            this.CardNameTB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameTB.Location = new System.Drawing.Point(3, 3);
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(99, 32);
            this.CardNameTB.TabIndex = 1;
            // 
            // DeleteCardButton
            // 
            this.DeleteCardButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCardButton.Location = new System.Drawing.Point(108, 41);
            this.DeleteCardButton.Name = "DeleteCardButton";
            this.DeleteCardButton.Size = new System.Drawing.Size(55, 23);
            this.DeleteCardButton.TabIndex = 2;
            this.DeleteCardButton.Text = "Delete";
            this.DeleteCardButton.UseVisualStyleBackColor = true;
            this.DeleteCardButton.Click += new System.EventHandler(this.DeleteCardButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(60, 40);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(42, 23);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteCardButton);
            this.Controls.Add(this.CardNameTB);
            this.Controls.Add(this.CardColorButton);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(168, 69);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public Card()
        {
            Init();
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void CardColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = dlg.Color;
            }
        }

        private void DeleteCardButton_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject dragData = new DataObject("Object", this);
            this.DoDragDrop(dragData, DragDropEffects.Move);
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey");
        }
    }
}

