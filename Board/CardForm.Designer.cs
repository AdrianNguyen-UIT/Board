using System.Windows;
using System.Drawing;

namespace Board
{
    partial class CardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.cardNameTextBox = new System.Windows.Forms.TextBox();
            this.cardNamePictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new MyCustomControl.RoundedButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.descriptionUserControl1 = new Board.DescriptionUserControl();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardNamePictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cardNameTextBox);
            this.topPanel.Controls.Add(this.cardNamePictureBox);
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Location = new System.Drawing.Point(3, 3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(824, 51);
            this.topPanel.TabIndex = 1;
            // 
            // cardNameTextBox
            // 
            this.cardNameTextBox.BackColor = System.Drawing.Color.White;
            this.cardNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardNameTextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNameTextBox.Location = new System.Drawing.Point(62, 20);
            this.cardNameTextBox.Name = "cardNameTextBox";
            this.cardNameTextBox.Size = new System.Drawing.Size(717, 28);
            this.cardNameTextBox.TabIndex = 2;
            // 
            // cardNamePictureBox
            // 
            this.cardNamePictureBox.BackColor = System.Drawing.Color.Aqua;
            this.cardNamePictureBox.Location = new System.Drawing.Point(3, 12);
            this.cardNamePictureBox.Name = "cardNamePictureBox";
            this.cardNamePictureBox.Size = new System.Drawing.Size(38, 36);
            this.cardNamePictureBox.TabIndex = 1;
            this.cardNamePictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.ButtonColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.IsEllipse = true;
            this.exitButton.Location = new System.Drawing.Point(784, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverButtonColor = System.Drawing.Color.LightGray;
            this.exitButton.RoundedRadius = 21;
            this.exitButton.Size = new System.Drawing.Size(39, 37);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.BodyPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(830, 600);
            this.mainPanel.TabIndex = 3;
            // 
            // BodyPanel
            // 
            this.BodyPanel.AutoScroll = true;
            this.BodyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BodyPanel.Controls.Add(this.descriptionUserControl1);
            this.BodyPanel.Location = new System.Drawing.Point(3, 60);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(824, 537);
            this.BodyPanel.TabIndex = 3;
            // 
            // descriptionUserControl1
            // 
            this.descriptionUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionUserControl1.Location = new System.Drawing.Point(2, 58);
            this.descriptionUserControl1.Name = "descriptionUserControl1";
            this.descriptionUserControl1.Size = new System.Drawing.Size(676, 122);
            this.descriptionUserControl1.TabIndex = 0;
            // 
            // CardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(830, 600);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardNamePictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.RoundedButton exitButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.PictureBox cardNamePictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private DescriptionUserControl descriptionUserControl1;
    }
}

