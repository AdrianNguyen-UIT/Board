namespace MyCustomControl
{
    partial class DueDateUserControl
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new MyCustomControl.CircularButton();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.iconPicturebox = new System.Windows.Forms.PictureBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.setReminderPanel = new System.Windows.Forms.Panel();
            this.setReminderComboBox = new System.Windows.Forms.ComboBox();
            this.setReminderLabel = new MyCustomControl.RoundedLabel();
            this.timePanel = new System.Windows.Forms.Panel();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.colonLabel2 = new System.Windows.Forms.Label();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.colonLabel1 = new System.Windows.Forms.Label();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new MyCustomControl.RoundedLabel();
            this.datePanel = new System.Windows.Forms.Panel();
            this.dateLabel = new MyCustomControl.RoundedLabel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.dueDateStateBar = new MyCustomControl.DueDateStateBar();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveCancelPanel = new System.Windows.Forms.Panel();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturebox)).BeginInit();
            this.contentPanel.SuspendLayout();
            this.setReminderPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.datePanel.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.saveCancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.topPanel.Controls.Add(this.deleteButton);
            this.topPanel.Controls.Add(this.dueDateLabel);
            this.topPanel.Controls.Add(this.iconPicturebox);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(687, 38);
            this.topPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::Board.Properties.Resources.CloseIcon16;
            this.deleteButton.Location = new System.Drawing.Point(656, 3);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(31, 31);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(63, 3);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(94, 25);
            this.dueDateLabel.TabIndex = 1;
            this.dueDateLabel.Text = "Due Date";
            // 
            // iconPicturebox
            // 
            this.iconPicturebox.BackColor = System.Drawing.Color.MediumPurple;
            this.iconPicturebox.Image = global::Board.Properties.Resources.DueDateIcon32;
            this.iconPicturebox.Location = new System.Drawing.Point(15, 3);
            this.iconPicturebox.Margin = new System.Windows.Forms.Padding(3, 1, 1, 1);
            this.iconPicturebox.Name = "iconPicturebox";
            this.iconPicturebox.Size = new System.Drawing.Size(32, 32);
            this.iconPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPicturebox.TabIndex = 0;
            this.iconPicturebox.TabStop = false;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.contentPanel.Controls.Add(this.setReminderPanel);
            this.contentPanel.Controls.Add(this.timePanel);
            this.contentPanel.Controls.Add(this.datePanel);
            this.contentPanel.Controls.Add(this.checkBox);
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(686, 64);
            this.contentPanel.TabIndex = 1;
            // 
            // setReminderPanel
            // 
            this.setReminderPanel.AutoSize = true;
            this.setReminderPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setReminderPanel.Controls.Add(this.setReminderComboBox);
            this.setReminderPanel.Controls.Add(this.setReminderLabel);
            this.setReminderPanel.Location = new System.Drawing.Point(438, 3);
            this.setReminderPanel.Name = "setReminderPanel";
            this.setReminderPanel.Size = new System.Drawing.Size(245, 58);
            this.setReminderPanel.TabIndex = 3;
            // 
            // setReminderComboBox
            // 
            this.setReminderComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setReminderComboBox.FormattingEnabled = true;
            this.setReminderComboBox.Items.AddRange(new object[] {
            "At Time",
            "5 Minutes Before",
            "15 Minutes Before",
            "30 Minutes Befor",
            "1 Hour Before",
            "2 Hours Before",
            "1 Day Before"});
            this.setReminderComboBox.Location = new System.Drawing.Point(3, 29);
            this.setReminderComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.setReminderComboBox.Name = "setReminderComboBox";
            this.setReminderComboBox.Size = new System.Drawing.Size(241, 28);
            this.setReminderComboBox.TabIndex = 4;
            this.setReminderComboBox.Text = "At Time";
            this.setReminderComboBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setReminderComboBox_MouseDown);
            // 
            // setReminderLabel
            // 
            this.setReminderLabel.AutoSize = true;
            this.setReminderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setReminderLabel.LabelColor = System.Drawing.Color.Silver;
            this.setReminderLabel.Location = new System.Drawing.Point(0, 3);
            this.setReminderLabel.Margin = new System.Windows.Forms.Padding(0);
            this.setReminderLabel.Name = "setReminderLabel";
            this.setReminderLabel.RoundedRadius = 5;
            this.setReminderLabel.Size = new System.Drawing.Size(109, 21);
            this.setReminderLabel.TabIndex = 3;
            this.setReminderLabel.Text = "Set Reminder";
            // 
            // timePanel
            // 
            this.timePanel.AutoSize = true;
            this.timePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timePanel.Controls.Add(this.secondTextBox);
            this.timePanel.Controls.Add(this.colonLabel2);
            this.timePanel.Controls.Add(this.minuteTextBox);
            this.timePanel.Controls.Add(this.colonLabel1);
            this.timePanel.Controls.Add(this.hourTextBox);
            this.timePanel.Controls.Add(this.timeLabel);
            this.timePanel.Location = new System.Drawing.Point(266, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(129, 58);
            this.timePanel.TabIndex = 2;
            // 
            // secondTextBox
            // 
            this.secondTextBox.BackColor = System.Drawing.Color.White;
            this.secondTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(99, 30);
            this.secondTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.secondTextBox.MaxLength = 2;
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(29, 27);
            this.secondTextBox.TabIndex = 6;
            this.secondTextBox.Text = "59";
            this.secondTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondTextBox_MouseDown);
            // 
            // colonLabel2
            // 
            this.colonLabel2.AutoSize = true;
            this.colonLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel2.Location = new System.Drawing.Point(84, 37);
            this.colonLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.colonLabel2.Name = "colonLabel2";
            this.colonLabel2.Size = new System.Drawing.Size(11, 17);
            this.colonLabel2.TabIndex = 5;
            this.colonLabel2.Text = ":";
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.BackColor = System.Drawing.Color.White;
            this.minuteTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuteTextBox.Location = new System.Drawing.Point(51, 30);
            this.minuteTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.minuteTextBox.MaxLength = 2;
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(29, 27);
            this.minuteTextBox.TabIndex = 3;
            this.minuteTextBox.Text = "59";
            this.minuteTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minuteTextBox_MouseDown);
            // 
            // colonLabel1
            // 
            this.colonLabel1.AutoSize = true;
            this.colonLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colonLabel1.Location = new System.Drawing.Point(36, 35);
            this.colonLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.colonLabel1.Name = "colonLabel1";
            this.colonLabel1.Size = new System.Drawing.Size(11, 17);
            this.colonLabel1.TabIndex = 2;
            this.colonLabel1.Text = ":";
            // 
            // hourTextBox
            // 
            this.hourTextBox.BackColor = System.Drawing.Color.White;
            this.hourTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourTextBox.Location = new System.Drawing.Point(3, 30);
            this.hourTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.hourTextBox.MaxLength = 2;
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(29, 27);
            this.hourTextBox.TabIndex = 1;
            this.hourTextBox.Text = "23";
            this.hourTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hourTextBox_MouseDown);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.LabelColor = System.Drawing.Color.Silver;
            this.timeLabel.Location = new System.Drawing.Point(0, 3);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.RoundedRadius = 5;
            this.timeLabel.Size = new System.Drawing.Size(46, 21);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time";
            // 
            // datePanel
            // 
            this.datePanel.AutoSize = true;
            this.datePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datePanel.Controls.Add(this.dateLabel);
            this.datePanel.Controls.Add(this.dateTimePicker);
            this.datePanel.Location = new System.Drawing.Point(63, 3);
            this.datePanel.Name = "datePanel";
            this.datePanel.Size = new System.Drawing.Size(170, 58);
            this.datePanel.TabIndex = 2;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.LabelColor = System.Drawing.Color.Silver;
            this.dateLabel.Location = new System.Drawing.Point(0, 3);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RoundedRadius = 5;
            this.dateLabel.Size = new System.Drawing.Size(44, 21);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(3, 30);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(1);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(166, 27);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dateTimePicker_MouseDown);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(15, 23);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // statusPanel
            // 
            this.statusPanel.AutoSize = true;
            this.statusPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statusPanel.Controls.Add(this.dueDateStateBar);
            this.statusPanel.Location = new System.Drawing.Point(0, 101);
            this.statusPanel.Margin = new System.Windows.Forms.Padding(0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(672, 22);
            this.statusPanel.TabIndex = 2;
            // 
            // dueDateStateBar
            // 
            this.dueDateStateBar.AutoSize = true;
            this.dueDateStateBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dueDateStateBar.CompletedColor = System.Drawing.Color.Lime;
            this.dueDateStateBar.CornerRaius = 10;
            this.dueDateStateBar.DueSoonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dueDateStateBar.Location = new System.Drawing.Point(15, 1);
            this.dueDateStateBar.Margin = new System.Windows.Forms.Padding(1);
            this.dueDateStateBar.Name = "dueDateStateBar";
            this.dueDateStateBar.OngoingColor = System.Drawing.Color.Gray;
            this.dueDateStateBar.OverDueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dueDateStateBar.Size = new System.Drawing.Size(656, 20);
            this.dueDateStateBar.State = 0;
            this.dueDateStateBar.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bottomPanel.Controls.Add(this.contentPanel);
            this.bottomPanel.Controls.Add(this.saveCancelPanel);
            this.bottomPanel.Controls.Add(this.statusPanel);
            this.bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bottomPanel.Location = new System.Drawing.Point(2, 38);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(686, 123);
            this.bottomPanel.TabIndex = 2;
            // 
            // saveCancelPanel
            // 
            this.saveCancelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveCancelPanel.Controls.Add(this.saveButton);
            this.saveCancelPanel.Controls.Add(this.cancelButton);
            this.saveCancelPanel.Location = new System.Drawing.Point(0, 64);
            this.saveCancelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.saveCancelPanel.Name = "saveCancelPanel";
            this.saveCancelPanel.Size = new System.Drawing.Size(686, 37);
            this.saveCancelPanel.TabIndex = 3;
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
            this.saveButton.Location = new System.Drawing.Point(64, 1);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.RoundedRadius = 10;
            this.saveButton.Size = new System.Drawing.Size(96, 33);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.cancelButton.Location = new System.Drawing.Point(162, 1);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.cancelButton.RoundedRadius = 10;
            this.cancelButton.Size = new System.Drawing.Size(96, 33);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // DueDateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Name = "DueDateUserControl";
            this.Size = new System.Drawing.Size(690, 163);
            this.Leave += new System.EventHandler(this.DueDateUserControl_Leave);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicturebox)).EndInit();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.setReminderPanel.ResumeLayout(false);
            this.setReminderPanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            this.datePanel.ResumeLayout(false);
            this.datePanel.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.saveCancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.PictureBox iconPicturebox;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.CheckBox checkBox;
        private RoundedLabel timeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private RoundedLabel dateLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Panel datePanel;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label colonLabel2;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.Label colonLabel1;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.Panel setReminderPanel;
        private RoundedLabel setReminderLabel;
        private System.Windows.Forms.ComboBox setReminderComboBox;
        private System.Windows.Forms.Panel statusPanel;
        private DueDateStateBar dueDateStateBar;
        private System.Windows.Forms.FlowLayoutPanel bottomPanel;
        private System.Windows.Forms.Panel saveCancelPanel;
        private RoundedButton saveButton;
        private RoundedButton cancelButton;
        private CircularButton deleteButton;
    }
}
