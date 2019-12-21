namespace MyCustomControl
{
    partial class CheckListUserControl
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
            this.percentagePanel = new System.Windows.Forms.Panel();
            this.percentageNumberLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.showButton = new MyCustomControl.RoundedButton();
            this.hideButton = new MyCustomControl.RoundedButton();
            this.checkListNameRichTextBox = new MyCustomControl.CustomRichTextBox();
            this.bottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addItemButtonPanel = new System.Windows.Forms.Panel();
            this.addItemButton = new MyCustomControl.RoundedButton();
            this.iscPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemRichTextBoxPanel = new System.Windows.Forms.Panel();
            this.itemRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveAndCancelPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.checkListPictureBox = new System.Windows.Forms.PictureBox();
            this.roundedProgressBar = new MyCustomControl.RoundedProgressBar();
            this.deleteButton = new MyCustomControl.CircularButton();
            this.percentagePanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.addItemButtonPanel.SuspendLayout();
            this.iscPanel.SuspendLayout();
            this.itemRichTextBoxPanel.SuspendLayout();
            this.saveAndCancelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkListPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedProgressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // percentagePanel
            // 
            this.percentagePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.percentagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.percentagePanel.Controls.Add(this.percentageNumberLabel);
            this.percentagePanel.Controls.Add(this.roundedProgressBar);
            this.percentagePanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentagePanel.Location = new System.Drawing.Point(2, 44);
            this.percentagePanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.percentagePanel.Name = "percentagePanel";
            this.percentagePanel.Size = new System.Drawing.Size(688, 18);
            this.percentagePanel.TabIndex = 4;
            // 
            // percentageNumberLabel
            // 
            this.percentageNumberLabel.AutoSize = true;
            this.percentageNumberLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageNumberLabel.Location = new System.Drawing.Point(16, 1);
            this.percentageNumberLabel.Name = "percentageNumberLabel";
            this.percentageNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.percentageNumberLabel.TabIndex = 3;
            this.percentageNumberLabel.Text = "0";
            this.percentageNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.percentagePanel);
            this.mainPanel.Controls.Add(this.bottomPanel);
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(1, 28);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(692, 178);
            this.mainPanel.TabIndex = 12;
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.SystemColors.Control;
            this.topPanel.Controls.Add(this.showButton);
            this.topPanel.Controls.Add(this.hideButton);
            this.topPanel.Controls.Add(this.checkListNameRichTextBox);
            this.topPanel.Controls.Add(this.checkListPictureBox);
            this.topPanel.Location = new System.Drawing.Point(2, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(688, 44);
            this.topPanel.TabIndex = 15;
            // 
            // showButton
            // 
            this.showButton.ButtonColor = System.Drawing.Color.DarkGray;
            this.showButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(596, 10);
            this.showButton.Margin = new System.Windows.Forms.Padding(1);
            this.showButton.Name = "showButton";
            this.showButton.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.showButton.RoundedRadius = 5;
            this.showButton.Size = new System.Drawing.Size(91, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.ButtonColor = System.Drawing.Color.DarkGray;
            this.hideButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.hideButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.hideButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.hideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideButton.Location = new System.Drawing.Point(596, 10);
            this.hideButton.Margin = new System.Windows.Forms.Padding(1);
            this.hideButton.Name = "hideButton";
            this.hideButton.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.hideButton.RoundedRadius = 5;
            this.hideButton.Size = new System.Drawing.Size(91, 23);
            this.hideButton.TabIndex = 11;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // checkListNameRichTextBox
            // 
            this.checkListNameRichTextBox.AutoSize = true;
            this.checkListNameRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkListNameRichTextBox.BackgroundColor = System.Drawing.Color.Empty;
            this.checkListNameRichTextBox.ContentText = null;
            this.checkListNameRichTextBox.FoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.checkListNameRichTextBox.Location = new System.Drawing.Point(60, 4);
            this.checkListNameRichTextBox.Name = "checkListNameRichTextBox";
            this.checkListNameRichTextBox.NonFoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.checkListNameRichTextBox.SaveButtonCommand = null;
            this.checkListNameRichTextBox.Size = new System.Drawing.Size(406, 37);
            this.checkListNameRichTextBox.TabIndex = 12;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bottomPanel.Controls.Add(this.itemListPanel);
            this.bottomPanel.Controls.Add(this.addItemButtonPanel);
            this.bottomPanel.Controls.Add(this.iscPanel);
            this.bottomPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bottomPanel.Location = new System.Drawing.Point(2, 62);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2, 0, 1, 2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(688, 114);
            this.bottomPanel.TabIndex = 14;
            // 
            // itemListPanel
            // 
            this.itemListPanel.AllowDrop = true;
            this.itemListPanel.AutoSize = true;
            this.itemListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemListPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.itemListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.itemListPanel.Location = new System.Drawing.Point(3, 1);
            this.itemListPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.itemListPanel.Name = "itemListPanel";
            this.itemListPanel.Size = new System.Drawing.Size(0, 0);
            this.itemListPanel.TabIndex = 1;
            this.itemListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.itemListPanel_DragDrop);
            this.itemListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.itemListLayoutPanel_DragEnter);
            // 
            // addItemButtonPanel
            // 
            this.addItemButtonPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addItemButtonPanel.BackColor = System.Drawing.SystemColors.Control;
            this.addItemButtonPanel.Controls.Add(this.addItemButton);
            this.addItemButtonPanel.Location = new System.Drawing.Point(0, 1);
            this.addItemButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addItemButtonPanel.Name = "addItemButtonPanel";
            this.addItemButtonPanel.Size = new System.Drawing.Size(688, 38);
            this.addItemButtonPanel.TabIndex = 2;
            // 
            // addItemButton
            // 
            this.addItemButton.ButtonColor = System.Drawing.Color.DarkGray;
            this.addItemButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.addItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(63, 6);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(1);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.OnHoverButtonColor = System.Drawing.Color.Gray;
            this.addItemButton.RoundedRadius = 5;
            this.addItemButton.Size = new System.Drawing.Size(91, 23);
            this.addItemButton.TabIndex = 15;
            this.addItemButton.Text = "Add item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // iscPanel
            // 
            this.iscPanel.AutoSize = true;
            this.iscPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.iscPanel.Controls.Add(this.itemRichTextBoxPanel);
            this.iscPanel.Controls.Add(this.saveAndCancelPanel);
            this.iscPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.iscPanel.Location = new System.Drawing.Point(0, 39);
            this.iscPanel.Margin = new System.Windows.Forms.Padding(0);
            this.iscPanel.Name = "iscPanel";
            this.iscPanel.Size = new System.Drawing.Size(687, 75);
            this.iscPanel.TabIndex = 1;
            this.iscPanel.Leave += new System.EventHandler(this.iscPanel_Leave);
            // 
            // itemRichTextBoxPanel
            // 
            this.itemRichTextBoxPanel.AllowDrop = true;
            this.itemRichTextBoxPanel.AutoSize = true;
            this.itemRichTextBoxPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemRichTextBoxPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.itemRichTextBoxPanel.Controls.Add(this.itemRichTextBox);
            this.itemRichTextBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.itemRichTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.itemRichTextBoxPanel.Name = "itemRichTextBoxPanel";
            this.itemRichTextBoxPanel.Size = new System.Drawing.Size(662, 40);
            this.itemRichTextBoxPanel.TabIndex = 0;
            // 
            // itemRichTextBox
            // 
            this.itemRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemRichTextBox.Location = new System.Drawing.Point(61, 1);
            this.itemRichTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.itemRichTextBox.MaximumSize = new System.Drawing.Size(600, 200);
            this.itemRichTextBox.MinimumSize = new System.Drawing.Size(600, 38);
            this.itemRichTextBox.Name = "itemRichTextBox";
            this.itemRichTextBox.RightMargin = 300;
            this.itemRichTextBox.Size = new System.Drawing.Size(600, 38);
            this.itemRichTextBox.TabIndex = 0;
            this.itemRichTextBox.Text = "";
            this.itemRichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.itemRichTextBox_ContentsResized);
            // 
            // saveAndCancelPanel
            // 
            this.saveAndCancelPanel.AllowDrop = true;
            this.saveAndCancelPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAndCancelPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveAndCancelPanel.Controls.Add(this.cancelButton);
            this.saveAndCancelPanel.Controls.Add(this.saveButton);
            this.saveAndCancelPanel.Location = new System.Drawing.Point(0, 40);
            this.saveAndCancelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.saveAndCancelPanel.Name = "saveAndCancelPanel";
            this.saveAndCancelPanel.Size = new System.Drawing.Size(687, 35);
            this.saveAndCancelPanel.TabIndex = 16;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(167, 1);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.cancelButton.RoundedRadius = 10;
            this.cancelButton.Size = new System.Drawing.Size(96, 33);
            this.cancelButton.TabIndex = 17;
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
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(60, 1);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.RoundedRadius = 10;
            this.saveButton.Size = new System.Drawing.Size(96, 33);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // checkListPictureBox
            // 
            this.checkListPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkListPictureBox.Image = global::Board.Properties.Resources.CheckListIcon;
            this.checkListPictureBox.Location = new System.Drawing.Point(15, 4);
            this.checkListPictureBox.Name = "checkListPictureBox";
            this.checkListPictureBox.Size = new System.Drawing.Size(32, 32);
            this.checkListPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.checkListPictureBox.TabIndex = 0;
            this.checkListPictureBox.TabStop = false;
            // 
            // roundedProgressBar
            // 
            this.roundedProgressBar.BackColor = System.Drawing.Color.LightGray;
            this.roundedProgressBar.CheckedCount = 0;
            this.roundedProgressBar.CompleteColor = System.Drawing.Color.LawnGreen;
            this.roundedProgressBar.CornerRadius = 5;
            this.roundedProgressBar.Denominator = 0;
            this.roundedProgressBar.Location = new System.Drawing.Point(60, 0);
            this.roundedProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.roundedProgressBar.Name = "roundedProgressBar";
            this.roundedProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundedProgressBar.Size = new System.Drawing.Size(618, 17);
            this.roundedProgressBar.TabIndex = 2;
            this.roundedProgressBar.TabStop = false;
            this.roundedProgressBar.Value = 0D;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Teal;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Image = global::Board.Properties.Resources.CloseIcon16;
            this.deleteButton.Location = new System.Drawing.Point(663, 0);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(28, 28);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // CheckListUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.mainPanel);
            this.Name = "CheckListUserControl";
            this.Size = new System.Drawing.Size(693, 206);
            this.Load += new System.EventHandler(this.CheckListUserControl_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckListUserControl_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckListUserControl_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CheckListUserControl_MouseUp);
            this.percentagePanel.ResumeLayout(false);
            this.percentagePanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.addItemButtonPanel.ResumeLayout(false);
            this.iscPanel.ResumeLayout(false);
            this.iscPanel.PerformLayout();
            this.itemRichTextBoxPanel.ResumeLayout(false);
            this.saveAndCancelPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkListPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedProgressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel percentagePanel;
        private System.Windows.Forms.Label percentageNumberLabel;
        private RoundedProgressBar roundedProgressBar;
        private System.Windows.Forms.PictureBox checkListPictureBox;
        private RoundedButton hideButton;
        private RoundedButton showButton;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private CustomRichTextBox checkListNameRichTextBox;
        private RoundedButton addItemButton;
        private System.Windows.Forms.FlowLayoutPanel bottomPanel;
        private System.Windows.Forms.FlowLayoutPanel itemListPanel;
        private System.Windows.Forms.RichTextBox itemRichTextBox;
        private System.Windows.Forms.Panel itemRichTextBoxPanel;
        private System.Windows.Forms.Panel addItemButtonPanel;
        private RoundedButton saveButton;
        private RoundedButton cancelButton;
        private System.Windows.Forms.Panel saveAndCancelPanel;
        private System.Windows.Forms.FlowLayoutPanel iscPanel;
        private System.Windows.Forms.Panel topPanel;
        private CircularButton deleteButton;
    }
}
