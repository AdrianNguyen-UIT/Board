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
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.BodyPanel = new System.Windows.Forms.Panel();
            this.roundedLabel1 = new MyCustomControl.RoundedLabel();
            this.exitButton = new MyCustomControl.RoundedButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardNamePictureBox)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).BeginInit();
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
            // descriptionPanel
            // 
            this.descriptionPanel.AutoSize = true;
            this.descriptionPanel.Controls.Add(this.roundedLabel1);
            this.descriptionPanel.Controls.Add(this.descriptionRichTextBox);
            this.descriptionPanel.Controls.Add(this.descriptionPictureBox);
            this.descriptionPanel.Location = new System.Drawing.Point(2, 109);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(673, 147);
            this.descriptionPanel.TabIndex = 2;
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(59, 43);
            this.descriptionRichTextBox.MaximumSize = new System.Drawing.Size(600, 500);
            this.descriptionRichTextBox.MinimumSize = new System.Drawing.Size(600, 79);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.RightMargin = 600;
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(600, 79);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "Describe this card...";
            this.descriptionRichTextBox.WordWrap = false;
            this.descriptionRichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox1_ContentsResized);
            this.descriptionRichTextBox.Enter += new System.EventHandler(this.descriptionRichTextBox_Enter);
            this.descriptionRichTextBox.Leave += new System.EventHandler(this.descriptionRichTextBox_Leave);
            // 
            // descriptionPictureBox
            // 
            this.descriptionPictureBox.BackColor = System.Drawing.Color.Aqua;
            this.descriptionPictureBox.Location = new System.Drawing.Point(6, 3);
            this.descriptionPictureBox.Name = "descriptionPictureBox";
            this.descriptionPictureBox.Size = new System.Drawing.Size(38, 37);
            this.descriptionPictureBox.TabIndex = 2;
            this.descriptionPictureBox.TabStop = false;
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
            this.BodyPanel.Controls.Add(this.descriptionPanel);
            this.BodyPanel.Location = new System.Drawing.Point(3, 60);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(824, 537);
            this.BodyPanel.TabIndex = 3;
            // 
            // roundedLabel1
            // 
            this.roundedLabel1.AutoSize = true;
            this.roundedLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundedLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedLabel1.LabelColor = System.Drawing.Color.Silver;
            this.roundedLabel1.Location = new System.Drawing.Point(57, 3);
            this.roundedLabel1.Name = "roundedLabel1";
            this.roundedLabel1.RoundedRadius = 9;
            this.roundedLabel1.Size = new System.Drawing.Size(125, 30);
            this.roundedLabel1.TabIndex = 5;
            this.roundedLabel1.Text = "Description";
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
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.RoundedButton exitButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox cardNameTextBox;
        private System.Windows.Forms.PictureBox cardNamePictureBox;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox descriptionPictureBox;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel BodyPanel;
        private MyCustomControl.RoundedLabel roundedLabel1;
    }
}

