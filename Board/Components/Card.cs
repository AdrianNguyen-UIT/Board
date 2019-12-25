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
    public partial class Card: UserControl
    {
        public Data.CardProp cardProp;
        List<Data.DueDateProp> dueDateProps;
        List<Data.CheckListProp> checkListProps;

        public string NameCard = "Card Name";
        string temp;
        public System.Windows.Forms.TextBox CardNameTB;
        private MyCustomControl.RoundedButton deleteButton;
        public System.Windows.Forms.Panel PanelCardName;
        private MyCustomControl.RoundedButton saveButton;
        private MyCustomControl.RoundedButton cancelButton;
        private PictureBox descriptionPictureBox;
        private PictureBox dueDatePictureBox;
        private PictureBox checkListPictureBox;


        public delegate void SecondFormShowedEventHandler(object sender, EventArgs e);
        public event SecondFormShowedEventHandler SecondFormShowed;

        protected virtual void OnSecondFormShowed()
        {
            if(SecondFormShowed != null)
            {
                SecondFormShowed(this, EventArgs.Empty);
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
        public Card()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.PanelCardName = new System.Windows.Forms.Panel();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.deleteButton = new MyCustomControl.RoundedButton();
            this.descriptionPictureBox = new PictureBox();
            this.dueDatePictureBox = new PictureBox();
            this.checkListPictureBox = new PictureBox();
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
            //descriptionPictureBox
            //
            this.descriptionPictureBox.Location = new System.Drawing.Point(30, 41);
            this.descriptionPictureBox.Name = "descriptionPictureBox";
            this.descriptionPictureBox.Size = new System.Drawing.Size(35, 35);
            this.descriptionPictureBox.TabIndex = 11;
            this.descriptionPictureBox.TabStop = false;
            this.descriptionPictureBox.BackColor = Color.MediumSeaGreen;
            this.descriptionPictureBox.Image = Properties.Resources.DescriptionIcon24;
            this.descriptionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;



            this.dueDatePictureBox.Location = new System.Drawing.Point(60, 41);
            this.dueDatePictureBox.Name = "dueDatePictureBox";
            this.dueDatePictureBox.Size = new System.Drawing.Size(35, 35);
            this.dueDatePictureBox.TabIndex = 11;
            this.dueDatePictureBox.TabStop = false;
            this.dueDatePictureBox.BackColor = Color.MediumPurple;
            this.dueDatePictureBox.Image = Properties.Resources.DueDateIcon24;
            this.dueDatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;



            this.checkListPictureBox.Location = new System.Drawing.Point(90, 41);
            this.checkListPictureBox.Name = "checkListPictureBox";
            this.checkListPictureBox.Size = new System.Drawing.Size(35, 35);
            this.checkListPictureBox.TabIndex = 11;
            this.checkListPictureBox.TabStop = false;
            this.checkListPictureBox.BackColor = Color.Teal;
            this.checkListPictureBox.Image = Properties.Resources.CheckListIcon24;
            this.checkListPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCardName);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.descriptionPictureBox);
            this.Controls.Add(this.dueDatePictureBox);
            this.Controls.Add(this.checkListPictureBox);
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

        public void SetCardPosition(int index)
        {
            cardProp.Card_Position = index;
            Data.DataService.UpdateCard(cardProp);
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            const string message = "Do you really want to delete this Card?\n" +
                "Once deleted, this Card cannot be retrieved";
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
                Data.DataService.DeleteCard(cardProp);
                if (deleted != null)
                    deleted(this, new EventArgs());
            }
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            OnSecondFormShowed();

            CardForm cardForm = new CardForm(cardProp);
            cardForm.ShowDialog();

            OnSecondFormClosed();
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

            cardProp.Card_Name = CardNameTB.Text;
            Data.DataService.UpdateCard(cardProp);
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

        public void LoadData(Data.CardProp _cardProp)
        {
            cardProp = new Data.CardProp();
            cardProp = _cardProp;
            NameCard = cardProp.Card_Name;
            CardNameTB.Text = NameCard;
            CheckContent();
        }

        public void CheckContent()
        {
            if (cardProp.Card_Description == "" || cardProp.Card_Description == null)
            {
                descriptionPictureBox.Visible = false;
            }
            else
            {
                descriptionPictureBox.Visible = true;
            }

            dueDateProps = new List<Data.DueDateProp>();
            dueDateProps = Data.DataService.GetDueDateByCardID(cardProp.Card_ID);
            if (dueDateProps.Count == 0)
            {
                dueDatePictureBox.Visible = false;
            }
            else
            {
                dueDatePictureBox.Visible = true;
            }

            checkListProps = new List<Data.CheckListProp>();
            checkListProps = Data.DataService.GetCheckListByCardID(cardProp.Card_ID);
            if (checkListProps.Count == 0)
            {
                checkListPictureBox.Visible = false;
            }
            else
            {
                checkListPictureBox.Visible = true;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath path = new GraphicsPath();
            path = MyCustomControl.RoundedDrawing.RoundedRect(new Rectangle(0, 0, ClientSize.Width, ClientSize.Height), 10);
            Region = new Region(path);
            base.OnPaint(pevent);
        }
    }

}
