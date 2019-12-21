using System;

namespace MyCustomControl
{
    partial class DescriptionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.hideButton = new MyCustomControl.RoundedButton();
            this.showButton = new MyCustomControl.RoundedButton();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.customRichTextBox = new MyCustomControl.CustomRichTextBox();
            this.flowLayoutPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.topPanel);
            this.flowLayoutPanel.Controls.Add(this.bottomPanel);
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(468, 79);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.topPanel.Controls.Add(this.hideButton);
            this.topPanel.Controls.Add(this.showButton);
            this.topPanel.Controls.Add(this.iconPictureBox);
            this.topPanel.Controls.Add(this.descriptionLabel);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(468, 38);
            this.topPanel.TabIndex = 0;
            // 
            // hideButton
            // 
            this.hideButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hideButton.ButtonColor = System.Drawing.Color.DarkGray;
            this.hideButton.FlatAppearance.BorderSize = 0;
            this.hideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.hideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.Location = new System.Drawing.Point(390, 8);
            this.hideButton.Name = "hideButton";
            this.hideButton.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.hideButton.RoundedRadius = 5;
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 3;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // showButton
            // 
            this.showButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.showButton.ButtonColor = System.Drawing.Color.DarkGray;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(390, 8);
            this.showButton.Name = "showButton";
            this.showButton.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.showButton.RoundedRadius = 5;
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconPictureBox.Image = global::Board.Properties.Resources.DescriptionIcon;
            this.iconPictureBox.Location = new System.Drawing.Point(15, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox.TabIndex = 1;
            this.iconPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(56, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(125, 30);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomPanel.Controls.Add(this.customRichTextBox);
            this.bottomPanel.Location = new System.Drawing.Point(2, 40);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(463, 37);
            this.bottomPanel.TabIndex = 1;
            // 
            // customRichTextBox
            // 
            this.customRichTextBox.AutoSize = true;
            this.customRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customRichTextBox.BackgroundColor = System.Drawing.Color.Empty;
            this.customRichTextBox.ContentText = null;
            this.customRichTextBox.FoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.customRichTextBox.Location = new System.Drawing.Point(57, 0);
            this.customRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.customRichTextBox.Name = "customRichTextBox";
            this.customRichTextBox.NonFoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.customRichTextBox.SaveButtonCommand = null;
            this.customRichTextBox.Size = new System.Drawing.Size(406, 37);
            this.customRichTextBox.TabIndex = 0;
            // 
            // DescriptionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "DescriptionUserControl";
            this.Size = new System.Drawing.Size(470, 81);
            this.Load += new System.EventHandler(this.DescriptionUserControl_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel bottomPanel;
        private RoundedButton showButton;
        private CustomRichTextBox customRichTextBox;
        private RoundedButton hideButton;
    }
}
