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
        public System.Windows.Forms.Button DeleteListButton;
        private System.Windows.Forms.Button ButtonAddCard;
        private System.Windows.Forms.FlowLayoutPanel CardListPanel;
        private void Init()
        {
            this.TextboxListName = new System.Windows.Forms.TextBox();
            this.DeleteListButton = new System.Windows.Forms.Button();
            this.ButtonAddCard = new System.Windows.Forms.Button();
            this.CardListPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            // DeleteListButton
            // 
            this.DeleteListButton.Location = new System.Drawing.Point(134, 6);
            this.DeleteListButton.Name = "DeleteListButton";
            this.DeleteListButton.Size = new System.Drawing.Size(63, 23);
            this.DeleteListButton.TabIndex = 1;
            this.DeleteListButton.Text = "Del";
            this.DeleteListButton.UseVisualStyleBackColor = true;
            this.DeleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click);
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
            this.CardListPanel.Size = new System.Drawing.Size(197, 467);
            this.CardListPanel.TabIndex = 4;
            this.CardListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragDrop);
            this.CardListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragEnter);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.CardListPanel);
            this.Controls.Add(this.DeleteListButton);
            this.Controls.Add(this.TextboxListName);
            this.Name = "Lists";
            this.Size = new System.Drawing.Size(200, 500);
            this.CardListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        List<Card> listCard = new List<Card>();
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Lists()
        {
            Init();
        }

        private void DeleteListButton_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
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
            if (CardListPanel == (element.Parent as FlowLayoutPanel)) return;
            CardListPanel.Controls.Remove(ButtonAddCard);
            CardListPanel.Controls.Add(element);
            CardListPanel.Controls.Add(ButtonAddCard);
            listCard.Add(element);
            element.Deleted += Card_Deleted;
        }
    }
}
