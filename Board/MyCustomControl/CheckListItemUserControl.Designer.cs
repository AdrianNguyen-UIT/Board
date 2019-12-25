namespace MyCustomControl
{
    partial class CheckListItemUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckListItemUserControl));
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.customRichTextBox = new MyCustomControl.CustomRichTextBox();
            this.deleteButton = new MyCustomControl.RoundedButton();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(14, 3);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(18, 17);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // customRichTextBox
            // 
            this.customRichTextBox.AutoSize = true;
            this.customRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customRichTextBox.BackgroundColor = System.Drawing.Color.Empty;
            this.customRichTextBox.ContentText = null;
            this.customRichTextBox.FoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.customRichTextBox.Location = new System.Drawing.Point(53, 0);
            this.customRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.customRichTextBox.Name = "customRichTextBox";
            this.customRichTextBox.NonFoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.customRichTextBox.Size = new System.Drawing.Size(539, 44);
            this.customRichTextBox.TabIndex = 1;
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
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.Location = new System.Drawing.Point(462, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.deleteButton.RoundedRadius = 2;
            this.deleteButton.Size = new System.Drawing.Size(23, 25);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CheckListItemUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.customRichTextBox);
            this.Controls.Add(this.checkBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckListItemUserControl";
            this.Size = new System.Drawing.Size(592, 44);
            this.Load += new System.EventHandler(this.CheckListItemUserControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckListItemUserControl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.CheckListItemUserControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CheckListItemUserControl_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckListItemUserControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckListItemUserControl_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private CustomRichTextBox customRichTextBox;
        private RoundedButton deleteButton;
    }
}
