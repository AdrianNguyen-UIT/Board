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
    public partial class Card: UserControl
    {
        public string NameCard = "Card Name";
        string temp;
        public System.Windows.Forms.TextBox CardNameTB;
        private MyCustomControl.RoundedButton deleteButton;
        public System.Windows.Forms.Panel PanelCardName;
        private MyCustomControl.RoundedButton saveButton;
        private MyCustomControl.RoundedButton cancelButton;
        public Card()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.PanelCardName = new System.Windows.Forms.Panel();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.deleteButton = new MyCustomControl.RoundedButton();
            this.PanelCardName.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardNameTB
            // 
            this.CardNameTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNameTB.Location = new System.Drawing.Point(3, 3);
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.ReadOnly = true;
            this.CardNameTB.Size = new System.Drawing.Size(164, 29);
            this.CardNameTB.TabIndex = 1;
            this.CardNameTB.Text = "Card Name";
            this.CardNameTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CardNameTB_MouseClick);
            this.CardNameTB.Validated += new System.EventHandler(this.CardNameTB_Validated);
            // 
            // PanelCardName
            // 
            this.PanelCardName.Controls.Add(this.cancelButton);
            this.PanelCardName.Controls.Add(this.saveButton);
            this.PanelCardName.Controls.Add(this.CardNameTB);
            this.PanelCardName.Location = new System.Drawing.Point(0, 3);
            this.PanelCardName.Name = "PanelCardName";
            this.PanelCardName.Size = new System.Drawing.Size(176, 32);
            this.PanelCardName.TabIndex = 8;
            this.PanelCardName.Validated += new System.EventHandler(this.PanelCardName_Validated);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(80, 32);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.cancelButton.RoundedRadius = 10;
            this.cancelButton.Size = new System.Drawing.Size(71, 25);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(13, 32);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.RoundedRadius = 10;
            this.saveButton.Size = new System.Drawing.Size(52, 25);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.deleteButton.Location = new System.Drawing.Point(184, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.deleteButton.RoundedRadius = 2;
            this.deleteButton.Size = new System.Drawing.Size(43, 29);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCardName);
            this.Controls.Add(this.deleteButton);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(230, 67);
            this.DoubleClick += new System.EventHandler(this.Card_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Card_MouseDown);
            this.PanelCardName.ResumeLayout(false);
            this.PanelCardName.PerformLayout();
            this.ResumeLayout(false);

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

        private void CardNameTB_MouseClick(object sender, MouseEventArgs e)
        {
            PanelCardName.Size = new Size(176, 61);
            CardNameTB.ReadOnly = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            PanelCardName.Size = new Size(176, 32);
            NameCard = temp;
            CardNameTB.Text = NameCard;
            CardNameTB.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            PanelCardName.Size = new Size(176, 32);
            CardNameTB.Text = NameCard;
            CardNameTB.ReadOnly = true;
        }

        private void CardNameTB_Validated(object sender, EventArgs e)
        {
            temp = CardNameTB.Text;
            CardNameTB.Text = NameCard;
            CardNameTB.ReadOnly = true;
        }

        private void PanelCardName_Validated(object sender, EventArgs e)
        {
            CardNameTB.ReadOnly = true;
            PanelCardName.Size = new Size(176, 32);
        }
    }

}
