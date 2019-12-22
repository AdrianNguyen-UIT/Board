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
        public System.Windows.Forms.TextBox TextboxListName;
        private System.Windows.Forms.Button ButtonAddCard;
        private System.Windows.Forms.FlowLayoutPanel CardListPanel;
        private MyCustomControl.CircularButton DeleteListButton;
        List<Card> listCard = new List<Card>();
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Lists()
        {
            this.TextboxListName = new System.Windows.Forms.TextBox();
            this.ButtonAddCard = new System.Windows.Forms.Button();
            this.CardListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteListButton = new MyCustomControl.CircularButton();
            this.CardListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxListName
            // 
            this.TextboxListName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxListName.Location = new System.Drawing.Point(3, 3);
            this.TextboxListName.Name = "TextboxListName";
            this.TextboxListName.Size = new System.Drawing.Size(125, 26);
            this.TextboxListName.TabIndex = 0;
            this.TextboxListName.Text = "List Name";
            this.TextboxListName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCard.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.Size = new System.Drawing.Size(170, 35);
            this.ButtonAddCard.TabIndex = 3;
            this.ButtonAddCard.Text = "+";
            this.ButtonAddCard.UseVisualStyleBackColor = true;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddList_Click);
            // 
            // CardListPanel
            // 
            this.CardListPanel.AllowDrop = true;
            this.CardListPanel.AutoScroll = true;
            this.CardListPanel.Controls.Add(this.ButtonAddCard);
            this.CardListPanel.Location = new System.Drawing.Point(0, 30);
            this.CardListPanel.Name = "CardListPanel";
            this.CardListPanel.Size = new System.Drawing.Size(197, 767);
            this.CardListPanel.TabIndex = 4;
            this.CardListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragDrop);
            this.CardListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragEnter);
            // 
            // DeleteListButton
            // 
            this.DeleteListButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteListButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.DeleteListButton.FlatAppearance.BorderSize = 0;
            this.DeleteListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.DeleteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteListButton.Image = global::Board.Properties.Resources.CloseIcon16;
            this.DeleteListButton.Location = new System.Drawing.Point(151, 1);
            this.DeleteListButton.Name = "DeleteListButton";
            this.DeleteListButton.Size = new System.Drawing.Size(46, 26);
            this.DeleteListButton.TabIndex = 5;
            this.DeleteListButton.UseVisualStyleBackColor = false;
            this.DeleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click_1);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.CardListPanel);
            this.Controls.Add(this.DeleteListButton);
            this.Controls.Add(this.TextboxListName);
            this.Name = "Lists";
            this.Size = new System.Drawing.Size(202, 800);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lists_MouseDown);
            this.CardListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ButtonAddList_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            listCard.Add(card);
            card.Deleted += Card_Deleted;
            CardListPanel.Controls.Remove(ButtonAddCard);
            CardListPanel.Controls.Add(card);
            CardListPanel.Controls.Add(ButtonAddCard);
        }

        private void Card_Deleted(object sender, EventArgs e)
        {
            Card uc = sender as Card;
            CardListPanel.Controls.Remove(uc);
            listCard.Remove(uc);
        }

        private void CardListPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void CardListPanel_DragDrop(object sender, DragEventArgs e)
        {
            Card element = e.Data.GetData("Object") as Card;
            if (element == null) return;
            if (CardListPanel == (element.Parent as FlowLayoutPanel))
            {
                MessageBox.Show("Here");
            }
            CardListPanel.Controls.Remove(ButtonAddCard);
            CardListPanel.Controls.Add(element);
            CardListPanel.Controls.Add(ButtonAddCard);
            listCard.Add(element);
            element.Deleted += Card_Deleted;
        }
        private void DeleteListButton_Click_1(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void Lists_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject dragData = new DataObject("Object", this);
            this.DoDragDrop(dragData, DragDropEffects.Move);
        }
    }
}
