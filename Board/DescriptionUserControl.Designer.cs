namespace Board
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
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.CancelDescriptionButton = new MyCustomControl.RoundedButton();
            this.SaveDescriptionButton = new MyCustomControl.RoundedButton();
            this.DiscriptionLabel = new MyCustomControl.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).BeginInit();
            this.descriptionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BackColor = System.Drawing.Color.LightGray;
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRichTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(63, 53);
            this.descriptionRichTextBox.MaximumSize = new System.Drawing.Size(600, 500);
            this.descriptionRichTextBox.MinimumSize = new System.Drawing.Size(600, 60);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.RightMargin = 600;
            this.descriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(600, 60);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.WordWrap = false;
            this.descriptionRichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.descriptionRichTextBox_ContentsResized);
            this.descriptionRichTextBox.Enter += new System.EventHandler(this.descriptionRichTextBox_Enter);
            this.descriptionRichTextBox.Leave += new System.EventHandler(this.descriptionRichTextBox_Leave);
            // 
            // descriptionPictureBox
            // 
            this.descriptionPictureBox.BackColor = System.Drawing.Color.Aqua;
            this.descriptionPictureBox.Location = new System.Drawing.Point(3, 5);
            this.descriptionPictureBox.Name = "descriptionPictureBox";
            this.descriptionPictureBox.Size = new System.Drawing.Size(38, 37);
            this.descriptionPictureBox.TabIndex = 2;
            this.descriptionPictureBox.TabStop = false;
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionPanel.Controls.Add(this.CancelDescriptionButton);
            this.descriptionPanel.Controls.Add(this.descriptionPictureBox);
            this.descriptionPanel.Controls.Add(this.SaveDescriptionButton);
            this.descriptionPanel.Controls.Add(this.DiscriptionLabel);
            this.descriptionPanel.Controls.Add(this.descriptionRichTextBox);
            this.descriptionPanel.Location = new System.Drawing.Point(3, 3);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(674, 155);
            this.descriptionPanel.TabIndex = 7;
            // 
            // CancelDescriptionButton
            // 
            this.CancelDescriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelDescriptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelDescriptionButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CancelDescriptionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CancelDescriptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CancelDescriptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CancelDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDescriptionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDescriptionButton.ForeColor = System.Drawing.Color.White;
            this.CancelDescriptionButton.IsEllipse = false;
            this.CancelDescriptionButton.Location = new System.Drawing.Point(179, 119);
            this.CancelDescriptionButton.Name = "CancelDescriptionButton";
            this.CancelDescriptionButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.CancelDescriptionButton.RoundedRadius = 10;
            this.CancelDescriptionButton.Size = new System.Drawing.Size(96, 33);
            this.CancelDescriptionButton.TabIndex = 8;
            this.CancelDescriptionButton.Text = "Cancel";
            this.CancelDescriptionButton.UseVisualStyleBackColor = true;
            this.CancelDescriptionButton.Click += new System.EventHandler(this.CancelDescriptionButton_Click);
            // 
            // SaveDescriptionButton
            // 
            this.SaveDescriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveDescriptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveDescriptionButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveDescriptionButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.SaveDescriptionButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.SaveDescriptionButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.SaveDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveDescriptionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDescriptionButton.ForeColor = System.Drawing.Color.White;
            this.SaveDescriptionButton.IsEllipse = false;
            this.SaveDescriptionButton.Location = new System.Drawing.Point(63, 119);
            this.SaveDescriptionButton.Name = "SaveDescriptionButton";
            this.SaveDescriptionButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveDescriptionButton.RoundedRadius = 10;
            this.SaveDescriptionButton.Size = new System.Drawing.Size(96, 33);
            this.SaveDescriptionButton.TabIndex = 6;
            this.SaveDescriptionButton.Text = "Save";
            this.SaveDescriptionButton.UseVisualStyleBackColor = true;
            this.SaveDescriptionButton.Click += new System.EventHandler(this.SaveDescriptionButton_Click);
            // 
            // DiscriptionLabel
            // 
            this.DiscriptionLabel.AutoSize = true;
            this.DiscriptionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DiscriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscriptionLabel.LabelColor = System.Drawing.Color.Silver;
            this.DiscriptionLabel.Location = new System.Drawing.Point(60, 12);
            this.DiscriptionLabel.Name = "DiscriptionLabel";
            this.DiscriptionLabel.RoundedRadius = 9;
            this.DiscriptionLabel.Size = new System.Drawing.Size(125, 30);
            this.DiscriptionLabel.TabIndex = 5;
            this.DiscriptionLabel.Text = "Description";
            // 
            // DescriptionUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.descriptionPanel);
            this.Name = "DescriptionUserControl";
            this.Size = new System.Drawing.Size(680, 161);
            this.Load += new System.EventHandler(this.DescriptionUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionPictureBox)).EndInit();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomControl.RoundedLabel DiscriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.PictureBox descriptionPictureBox;
        private MyCustomControl.RoundedButton SaveDescriptionButton;
        private System.Windows.Forms.Panel descriptionPanel;
        private MyCustomControl.RoundedButton CancelDescriptionButton;
    }
}
