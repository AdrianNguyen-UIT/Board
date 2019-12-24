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
        private System.Windows.Forms.TextBox CardNameTB;
        private MyCustomControl.RoundedButton deleteButton;
        public Card()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.deleteButton = new MyCustomControl.RoundedButton();
            this.SuspendLayout();
            // 
            // CardNameTB
            // 
            this.CardNameTB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameTB.Location = new System.Drawing.Point(3, 3);
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(164, 26);
            this.CardNameTB.TabIndex = 1;
            this.CardNameTB.Text = "Card Name";
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.ButtonColor = System.Drawing.Color.Transparent;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Image = global::Board.Properties.Resources.DeleteIcon;
            this.deleteButton.Location = new System.Drawing.Point(108, 35);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.deleteButton.RoundedRadius = 2;
            this.deleteButton.Size = new System.Drawing.Size(59, 26);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.CardNameTB);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(170, 67);
            this.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();


        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                DataObject dragData = new DataObject("Object", this);
                this.DoDragDrop(dragData, DragDropEffects.Move);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Card Form");
        }
    }
}
