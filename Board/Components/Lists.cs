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

namespace Board.Components
{
    public partial class Lists : UserControl
    {

        public Data.ListProp listProp;
        List<Data.CardProp> cardProps;

        bool IsObserve = false;
        public string NameLists = "List Name";
        string temp;
        List<Card> listCard = new List<Card>();
        public System.Windows.Forms.TextBox TextboxListName;
        private System.Windows.Forms.FlowLayoutPanel CardListPanel;
        private MyCustomControl.CircularButton DeleteListButton;
        private MyCustomControl.RoundedButton ButtonAddCard;
        private MyCustomControl.RoundedButton saveButton;
        private MyCustomControl.RoundedButton cancelButton;
        private System.Windows.Forms.Panel PanelSetting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Lists()

        {
            this.TextboxListName = new System.Windows.Forms.TextBox();
            this.CardListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddCard = new MyCustomControl.RoundedButton();
            this.PanelSetting = new System.Windows.Forms.Panel();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteListButton = new MyCustomControl.CircularButton();
            this.CardListPanel.SuspendLayout();
            this.PanelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxListName
            // 
            this.TextboxListName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxListName.Location = new System.Drawing.Point(3, 3);
            this.TextboxListName.Name = "TextboxListName";
            this.TextboxListName.ReadOnly = true;
            this.TextboxListName.Size = new System.Drawing.Size(134, 29);
            this.TextboxListName.TabIndex = 0;
            this.TextboxListName.Text = "List Name";
            this.TextboxListName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxListName.Click += new System.EventHandler(this.TextboxListName_Click);
            this.TextboxListName.Validated += new System.EventHandler(this.TextboxListName_Validated);
            // 
            // CardListPanel
            // 
            this.CardListPanel.AllowDrop = true;
            this.CardListPanel.AutoScroll = true;
            this.CardListPanel.Controls.Add(this.ButtonAddCard);
            this.CardListPanel.Location = new System.Drawing.Point(0, 36);
            this.CardListPanel.Name = "CardListPanel";
            this.CardListPanel.Size = new System.Drawing.Size(263, 731);
            this.CardListPanel.TabIndex = 4;
            this.CardListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragDrop);
            this.CardListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.CardListPanel_DragEnter);
            // 
            // ButtonAddCard
            // 
            this.ButtonAddCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddCard.ButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddCard.FlatAppearance.BorderSize = 0;
            this.ButtonAddCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.ButtonAddCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.ButtonAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddCard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddCard.Image = global::Board.Properties.Resources.AddIcon;
            this.ButtonAddCard.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddCard.Name = "ButtonAddCard";
            this.ButtonAddCard.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddCard.RoundedRadius = 2;
            this.ButtonAddCard.Size = new System.Drawing.Size(230, 29);
            this.ButtonAddCard.TabIndex = 9;
            this.ButtonAddCard.UseVisualStyleBackColor = false;
            this.ButtonAddCard.Click += new System.EventHandler(this.ButtonAddBoard_Click);
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.TextboxListName);
            this.PanelSetting.Controls.Add(this.cancelButton);
            this.PanelSetting.Controls.Add(this.saveButton);
            this.PanelSetting.Location = new System.Drawing.Point(3, 3);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.Size = new System.Drawing.Size(142, 32);
            this.PanelSetting.TabIndex = 10;
            this.PanelSetting.Validated += new System.EventHandler(this.PanelSetting_Validated);
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
            this.cancelButton.Location = new System.Drawing.Point(60, 36);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.cancelButton.RoundedRadius = 10;
            this.cancelButton.Size = new System.Drawing.Size(77, 28);
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
            this.saveButton.Location = new System.Drawing.Point(3, 36);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.RoundedRadius = 10;
            this.saveButton.Size = new System.Drawing.Size(55, 28);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Location = new Point(160, 8);
            this.pictureBox1.Image = Properties.Resources.ObservationIcon24;
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteListButton
            // 
            this.DeleteListButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteListButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteListButton.FlatAppearance.BorderSize = 0;
            this.DeleteListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.DeleteListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.DeleteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteListButton.Image = global::Board.Properties.Resources.CloseIcon16;
            this.DeleteListButton.Location = new System.Drawing.Point(229, 4);
            this.DeleteListButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.DeleteListButton.Name = "DeleteListButton";
            this.DeleteListButton.Size = new System.Drawing.Size(34, 26);
            this.DeleteListButton.TabIndex = 5;
            this.DeleteListButton.UseVisualStyleBackColor = true;
            this.DeleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click_1);
            // 
            // Lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PanelSetting);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteListButton);
            this.Controls.Add(this.CardListPanel);
            this.Name = "Lists";
            this.Size = new System.Drawing.Size(266, 830);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lists_MouseDown);
            this.CardListPanel.ResumeLayout(false);
            this.PanelSetting.ResumeLayout(false);
            this.PanelSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public void LoadData(Data.ListProp _listProp)
        {
            listProp = new Data.ListProp();
            listProp = _listProp;
            NameLists = listProp.List_Name;
            TextboxListName.Text = NameLists;
            IsObserve = listProp.List_Observing;

            if(IsObserve == true)
            {
                pictureBox1.BackColor = Color.Yellow;
                for (int i = 0; i < listCard.Count; i++)
                {
                    listCard[i].BackColor = Color.Yellow;
                }
            }
            else
            {
                pictureBox1.BackColor = Color.FromArgb(192, 255, 255);
                for (int i = 0; i < listCard.Count; i++)
                {
                    listCard[i].BackColor = Color.White;
                }
            }

            cardProps = new List<Data.CardProp>();
            cardProps = Data.DataService.GetCardByListID(listProp.List_ID);
            foreach (Data.CardProp cardProp in cardProps)
            {
                Card card = new Card();
                card.Deleted += Card_Deleted;
                card.SecondFormShowed += Card_SecondFormShowed;
                card.SecondFormClosed += Card_SecondFormClosed;
                card.LoadData(cardProp);
                listCard.Add(card);
                if (IsObserve == true) card.BackColor = Color.Yellow;
                CardListPanel.Controls.Remove(ButtonAddCard);
                CardListPanel.Controls.Add(card);
                CardListPanel.Controls.Add(ButtonAddCard);
            }
        }

        public delegate void SecondFormClosedEventHandler(object sender, EventArgs e);
        public event SecondFormShowedEventHandler SecondFormClosed;

        protected virtual void OnSecondFormClosed()
        {
            if (SecondFormClosed != null)
            {
                SecondFormClosed(this, EventArgs.Empty);
            }
        }

        private void Card_SecondFormClosed(object sender, EventArgs e)
        {
            OnSecondFormClosed();
        }

        public delegate void SecondFormShowedEventHandler(object sender, EventArgs e);
        public event SecondFormShowedEventHandler SecondFormShowed;

        protected virtual void OnSecondFormShowed()
        {
            if (SecondFormShowed != null)
            {
                SecondFormShowed(this, EventArgs.Empty);
            }
        }

        public void SetListPosition(int index)
        {
            listProp.List_Position = index;
            Data.DataService.UpdateList(listProp);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path = MyCustomControl.RoundedDrawing.RoundedRect(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), 10);
            Region = new Region(path);
            base.OnPaint(pevent);
        }

        private void Card_SecondFormShowed(object sender, EventArgs e)
        {
            OnSecondFormShowed();
        }

        private void ButtonAddBoard_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            card.Deleted += Card_Deleted;
            card.NameCard = "Card (" + (listCard.Count + 1) + ")";
            card.CardNameTB.Text = card.NameCard;
            card.SecondFormShowed += Card_SecondFormShowed;
            card.SecondFormClosed += Card_SecondFormClosed;
            listCard.Add(card);
            if (IsObserve == true) card.BackColor = Color.Yellow;
            CardListPanel.Controls.Remove(ButtonAddCard);
            CardListPanel.Controls.Add(card);
            CardListPanel.Controls.Add(ButtonAddCard);

            Data.CardProp cardProp = new Data.CardProp();
            cardProp.Card_Name = card.NameCard;
            cardProp.Card_Description = "";
            cardProp.Card_Observing = listProp.List_Observing;
            cardProp.Card_Position = listCard.Count - 1;
            cardProp.List_ID = listProp.List_ID;
            Data.DataService.InsertCard(cardProp);
            cardProps = Data.DataService.GetCardByListID(listProp.List_ID);
            card.cardProp = cardProps[cardProps.Count - 1];
            card.CheckContent();
            
        }
        private void Card_Deleted(object sender, EventArgs e)
        {
            Card uc = sender as Card;
            CardListPanel.Controls.Remove(uc);
            listCard.Remove(uc);
            cardProps = Data.DataService.GetCardByListID(listProp.List_ID);
        }

        private void CardListPanel_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetData("Object") as Card) == null)
                e.Effect = DragDropEffects.None;
            else
                e.Effect = e.AllowedEffect;
        }

        private void CardListPanel_DragDrop(object sender, DragEventArgs e)
        {
            Card element = e.Data.GetData("Object") as Card;
            Point p = CardListPanel.PointToClient(new Point(e.X, e.Y));
            Card item = CardListPanel.GetChildAtPoint(p) as Card;
            if (element == null) return;
            if (element == item) return;
            if (element.Parent as FlowLayoutPanel == CardListPanel)
            {
                if (item == null)
                    item = listCard[listCard.Count - 1];
                int indexi = CardListPanel.Controls.GetChildIndex(item, false);
                int indexe = CardListPanel.Controls.GetChildIndex(element, false);
                CardListPanel.Controls.SetChildIndex(element, indexi);
                CardListPanel.Controls.SetChildIndex(item, indexe);
                indexi = listCard.IndexOf(item);
                indexe = listCard.IndexOf(element);
                Card temp = listCard[indexi];
                listCard[indexi] = listCard[indexe];
                listCard[indexe] = temp;
                ResetCardPosition();
            }
            else
            {
                if (IsObserve == true)
                {
                    element.BackColor = Color.Yellow;
                }
                else
                    element.BackColor = Color.White;
                if (item == null)
                {
                    Data.CardProp _cardProp = new Data.CardProp();
                    _cardProp.Card_Name = element.cardProp.Card_Name;
                    _cardProp.Card_Observing = IsObserve;
                    _cardProp.Card_Description = element.cardProp.Card_Description;
                    _cardProp.List_ID = listProp.List_ID;
                    _cardProp.Card_ID = element.cardProp.Card_ID;



                    ((element.Parent as FlowLayoutPanel).Parent as Lists).listCard.Remove(element);
                    listCard.Add(element);
                    CardListPanel.Controls.Clear();
                    for (int i = 0; i < listCard.Count; i++)
                    {
                        CardListPanel.Controls.Add(listCard[i]);
                        listCard[i].Deleted += Card_Deleted;
                    }
                    CardListPanel.Controls.Add(ButtonAddCard);
                    _cardProp.Card_Position = CardListPanel.Controls.GetChildIndex(listCard[listCard.Count - 1]);

                    Data.DataService.UpdateCard(_cardProp);

                }
                else
                {

                    listCard.Add(element);
                    element.Deleted += Card_Deleted;
                    ((element.Parent as FlowLayoutPanel).Parent as Lists).listCard.Remove(element);
                    List<Card> temp = new List<Card>();
                    for (int i = 0; i < listCard.Count; i++)
                    {
                        if (i < listCard.IndexOf(item)) temp.Add(listCard[i]);
                        else if (i > listCard.IndexOf(item)) temp.Add(listCard[i - 1]);
                        else temp.Add(element);
                    }
                    listCard.Clear();
                    listCard = temp;
                    CardListPanel.Controls.Remove(ButtonAddCard);
                    CardListPanel.Controls.Clear();
                    for (int i = 0; i < listCard.Count; i++)
                    {
                        CardListPanel.Controls.Add(listCard[i]);
                    }
                    CardListPanel.Controls.Add(ButtonAddCard);


                }
            }


        }

        private void ResetCardPosition()
        {
            foreach(Card card in listCard)
            {
                card.SetCardPosition(CardListPanel.Controls.GetChildIndex(card));
            }
        }

        private void DeleteListButton_Click_1(object sender, EventArgs e)
        {
            const string message = "Do you really want to delete this List?\n" +
                "Once deleted, this List cannot be retrieved";
            const string caption = "Alert";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Data.DataService.DeleteList(listProp);
                if (deleted != null)
                    deleted(this, new EventArgs());
            }
        }

        private void Lists_MouseDown(object sender, MouseEventArgs e)
        {
            DataObject dragData = new DataObject("Object", this);
            this.DoDragDrop(dragData, DragDropEffects.Move);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            NameLists = temp;
            TextboxListName.Text = NameLists;
            TextboxListName.ReadOnly = true;
            PanelSetting.Size = new Size(155, 32);
            CardListPanel.Location = new Point(0, 36);
            CardListPanel.Size = new Size(263, 791);

            listProp.List_Name = TextboxListName.Text;
            Data.DataService.UpdateList(listProp);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            TextboxListName.Text = NameLists;
            TextboxListName.ReadOnly = true;
            PanelSetting.Size = new Size(155, 32);
            CardListPanel.Location = new Point(0, 36);
            CardListPanel.Size = new Size(263, 791);
        }

        private void TextboxListName_Validated(object sender, EventArgs e)
        {
            temp = TextboxListName.Text;
            TextboxListName.Text = NameLists;
            TextboxListName.ReadOnly = true;
        }

        private void TextboxListName_Click(object sender, EventArgs e)
        {
            TextboxListName.ReadOnly = false;
            PanelSetting.Size = new Size(155, 66);
            CardListPanel.Location = new Point(0, 71);
            CardListPanel.Size = new Size(263, 756);
        }

        private void PanelSetting_Validated(object sender, EventArgs e)
        {
            TextboxListName.ReadOnly = true;
            PanelSetting.Size = new Size(155, 32);
            CardListPanel.Location = new Point(0, 36);
            CardListPanel.Size = new Size(263, 791);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (IsObserve == false)
            {
                IsObserve = true;
                pictureBox1.BackColor = Color.Yellow;
                for (int i = 0; i < listCard.Count; i++)
                {
                    listCard[i].BackColor = Color.Yellow;
                }
            }
            else
            {
                IsObserve = false;
                pictureBox1.BackColor = Color.FromArgb(192, 255, 255);
                for (int i = 0; i < listCard.Count; i++)
                {
                    listCard[i].BackColor = Color.White;
                }
            }

            listProp.List_Observing = IsObserve;
            Data.DataService.UpdateList(listProp);

            foreach (Data.CardProp cardProp in cardProps)
            {
                cardProp.Card_Observing = true;
                Data.DataService.UpdateCard(cardProp);
            }
        }

    }
}
