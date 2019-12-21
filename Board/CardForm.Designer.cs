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
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new MyCustomControl.CircularButton();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.cardNameRichTextBox = new MyCustomControl.CustomRichTextBox();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.informationPanel = new System.Windows.Forms.Panel();
            this.listLabel = new System.Windows.Forms.Label();
            this.listPictureBox = new System.Windows.Forms.PictureBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.checkListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.descriptionPanel = new System.Windows.Forms.Panel();
            this.descriptionUserControl = new MyCustomControl.DescriptionUserControl();
            this.dueDatePanel = new System.Windows.Forms.Panel();
            this.featurePanel = new System.Windows.Forms.Panel();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.actionLabel = new MyCustomControl.RoundedLabel();
            this.observeButton = new MyCustomControl.RoundedButton();
            this.observePictureBox = new System.Windows.Forms.PictureBox();
            this.addFeaturePanel = new System.Windows.Forms.Panel();
            this.addFeatureLabel = new MyCustomControl.RoundedLabel();
            this.addChecklistButton = new MyCustomControl.RoundedButton();
            this.addDueDateButton = new MyCustomControl.RoundedButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.informationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.descriptionPanel.SuspendLayout();
            this.featurePanel.SuspendLayout();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observePictureBox)).BeginInit();
            this.addFeaturePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.iconPictureBox);
            this.topPanel.Controls.Add(this.cardNameRichTextBox);
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(902, 51);
            this.topPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::Board.Properties.Resources.CloseIcon24;
            this.exitButton.Location = new System.Drawing.Point(857, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(42, 42);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.BackColor = System.Drawing.Color.DarkTurquoise;
            this.iconPictureBox.Image = global::Board.Properties.Resources.CardIcon;
            this.iconPictureBox.Location = new System.Drawing.Point(16, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            // 
            // cardNameRichTextBox
            // 
            this.cardNameRichTextBox.AutoSize = true;
            this.cardNameRichTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cardNameRichTextBox.BackgroundColor = System.Drawing.Color.Empty;
            this.cardNameRichTextBox.ContentText = null;
            this.cardNameRichTextBox.FoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.cardNameRichTextBox.Location = new System.Drawing.Point(78, 3);
            this.cardNameRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardNameRichTextBox.Name = "cardNameRichTextBox";
            this.cardNameRichTextBox.NonFoucesedRichTextBoxColor = System.Drawing.Color.Empty;
            this.cardNameRichTextBox.SaveButtonCommand = null;
            this.cardNameRichTextBox.Size = new System.Drawing.Size(539, 44);
            this.cardNameRichTextBox.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.informationPanel);
            this.mainPanel.Controls.Add(this.bodyPanel);
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(902, 692);
            this.mainPanel.TabIndex = 0;
            // 
            // informationPanel
            // 
            this.informationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.informationPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.informationPanel.Controls.Add(this.listLabel);
            this.informationPanel.Controls.Add(this.listPictureBox);
            this.informationPanel.Controls.Add(this.boardLabel);
            this.informationPanel.Controls.Add(this.boardPictureBox);
            this.informationPanel.Location = new System.Drawing.Point(0, 51);
            this.informationPanel.Margin = new System.Windows.Forms.Padding(0);
            this.informationPanel.Name = "informationPanel";
            this.informationPanel.Size = new System.Drawing.Size(902, 36);
            this.informationPanel.TabIndex = 1;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.Location = new System.Drawing.Point(111, 22);
            this.listLabel.Margin = new System.Windows.Forms.Padding(0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(66, 19);
            this.listLabel.TabIndex = 3;
            this.listLabel.Text = "ListName";
            // 
            // listPictureBox
            // 
            this.listPictureBox.Image = global::Board.Properties.Resources.ListIcon16;
            this.listPictureBox.Location = new System.Drawing.Point(78, 19);
            this.listPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.listPictureBox.Name = "listPictureBox";
            this.listPictureBox.Size = new System.Drawing.Size(16, 16);
            this.listPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.listPictureBox.TabIndex = 1;
            this.listPictureBox.TabStop = false;
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardLabel.Location = new System.Drawing.Point(111, 4);
            this.boardLabel.Margin = new System.Windows.Forms.Padding(0);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(81, 19);
            this.boardLabel.TabIndex = 2;
            this.boardLabel.Text = "BoardName";
            // 
            // boardPictureBox
            // 
            this.boardPictureBox.Image = global::Board.Properties.Resources.BoardIcon16;
            this.boardPictureBox.Location = new System.Drawing.Point(78, 1);
            this.boardPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.boardPictureBox.Name = "boardPictureBox";
            this.boardPictureBox.Size = new System.Drawing.Size(16, 16);
            this.boardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boardPictureBox.TabIndex = 0;
            this.boardPictureBox.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.AutoSize = true;
            this.bodyPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bodyPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bodyPanel.Controls.Add(this.contentPanel);
            this.bodyPanel.Controls.Add(this.featurePanel);
            this.bodyPanel.Location = new System.Drawing.Point(0, 87);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(900, 605);
            this.bodyPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.AutoScroll = true;
            this.contentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.contentPanel.Controls.Add(this.descriptionPanel);
            this.contentPanel.Controls.Add(this.dueDatePanel);
            this.contentPanel.Controls.Add(this.checkListPanel);
            this.contentPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.contentPanel.Location = new System.Drawing.Point(1, 1);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(1);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(746, 603);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.WrapContents = false;
            // 
            // checkListPanel
            // 
            this.checkListPanel.AllowDrop = true;
            this.checkListPanel.AutoSize = true;
            this.checkListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.checkListPanel.Location = new System.Drawing.Point(10, 157);
            this.checkListPanel.Margin = new System.Windows.Forms.Padding(10, 10, 1, 1);
            this.checkListPanel.Name = "checkListPanel";
            this.checkListPanel.Size = new System.Drawing.Size(0, 0);
            this.checkListPanel.TabIndex = 1;
            this.checkListPanel.WrapContents = false;
            this.checkListPanel.SizeChanged += new System.EventHandler(this.checkListPanel_SizeChanged);
            this.checkListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.checkListPanel_DragDrop);
            this.checkListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.checkListPanel_DragEnter);
            this.checkListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.checkListPanel_Paint);
            // 
            // descriptionPanel
            // 
            this.descriptionPanel.AutoSize = true;
            this.descriptionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.descriptionPanel.Controls.Add(this.descriptionUserControl);
            this.descriptionPanel.Location = new System.Drawing.Point(10, 10);
            this.descriptionPanel.Margin = new System.Windows.Forms.Padding(10, 10, 1, 10);
            this.descriptionPanel.Name = "descriptionPanel";
            this.descriptionPanel.Size = new System.Drawing.Size(723, 107);
            this.descriptionPanel.TabIndex = 0;
            this.descriptionPanel.SizeChanged += new System.EventHandler(this.descriptionPanel_SizeChanged);
            this.descriptionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.descriptionPanel_Paint);
            // 
            // descriptionUserControl
            // 
            this.descriptionUserControl.AutoSize = true;
            this.descriptionUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.descriptionUserControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.descriptionUserControl.Location = new System.Drawing.Point(5, 5);
            this.descriptionUserControl.Margin = new System.Windows.Forms.Padding(5);
            this.descriptionUserControl.Name = "descriptionUserControl";
            this.descriptionUserControl.Size = new System.Drawing.Size(713, 97);
            this.descriptionUserControl.TabIndex = 0;
            // 
            // dueDatePanel
            // 
            this.dueDatePanel.AutoSize = true;
            this.dueDatePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dueDatePanel.Location = new System.Drawing.Point(10, 137);
            this.dueDatePanel.Margin = new System.Windows.Forms.Padding(10, 10, 1, 10);
            this.dueDatePanel.Name = "dueDatePanel";
            this.dueDatePanel.Size = new System.Drawing.Size(0, 0);
            this.dueDatePanel.TabIndex = 3;
            this.dueDatePanel.SizeChanged += new System.EventHandler(this.dueDatePanel_SizeChanged);
            this.dueDatePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dueDatePanel_Paint);
            // 
            // featurePanel
            // 
            this.featurePanel.BackColor = System.Drawing.Color.Silver;
            this.featurePanel.Controls.Add(this.actionPanel);
            this.featurePanel.Controls.Add(this.addFeaturePanel);
            this.featurePanel.Location = new System.Drawing.Point(753, 1);
            this.featurePanel.Margin = new System.Windows.Forms.Padding(1);
            this.featurePanel.Name = "featurePanel";
            this.featurePanel.Size = new System.Drawing.Size(146, 290);
            this.featurePanel.TabIndex = 1;
            // 
            // actionPanel
            // 
            this.actionPanel.AutoSize = true;
            this.actionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionPanel.Controls.Add(this.actionLabel);
            this.actionPanel.Controls.Add(this.observeButton);
            this.actionPanel.Controls.Add(this.observePictureBox);
            this.actionPanel.Location = new System.Drawing.Point(4, 10);
            this.actionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(137, 98);
            this.actionPanel.TabIndex = 3;
            this.actionPanel.SizeChanged += new System.EventHandler(this.actionPanel_SizeChanged);
            this.actionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.actionPanel_Paint);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.BackColor = System.Drawing.Color.Gray;
            this.actionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.actionLabel.LabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.actionLabel.Location = new System.Drawing.Point(3, 3);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.RoundedRadius = 5;
            this.actionLabel.Size = new System.Drawing.Size(83, 32);
            this.actionLabel.TabIndex = 5;
            this.actionLabel.Text = "Action";
            // 
            // observeButton
            // 
            this.observeButton.BackColor = System.Drawing.Color.Gray;
            this.observeButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.observeButton.FlatAppearance.BorderSize = 0;
            this.observeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.observeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.observeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.observeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.observeButton.Location = new System.Drawing.Point(3, 34);
            this.observeButton.Margin = new System.Windows.Forms.Padding(4);
            this.observeButton.Name = "observeButton";
            this.observeButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.observeButton.RoundedRadius = 10;
            this.observeButton.Size = new System.Drawing.Size(130, 44);
            this.observeButton.TabIndex = 2;
            this.observeButton.Text = "Observe";
            this.observeButton.UseVisualStyleBackColor = false;
            this.observeButton.Click += new System.EventHandler(this.observeButton_Click);
            // 
            // observePictureBox
            // 
            this.observePictureBox.BackColor = System.Drawing.Color.SpringGreen;
            this.observePictureBox.Location = new System.Drawing.Point(3, 85);
            this.observePictureBox.Name = "observePictureBox";
            this.observePictureBox.Size = new System.Drawing.Size(130, 10);
            this.observePictureBox.TabIndex = 3;
            this.observePictureBox.TabStop = false;
            this.observePictureBox.Visible = false;
            // 
            // addFeaturePanel
            // 
            this.addFeaturePanel.AutoSize = true;
            this.addFeaturePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addFeaturePanel.Controls.Add(this.addFeatureLabel);
            this.addFeaturePanel.Controls.Add(this.addChecklistButton);
            this.addFeaturePanel.Controls.Add(this.addDueDateButton);
            this.addFeaturePanel.Location = new System.Drawing.Point(4, 135);
            this.addFeaturePanel.Margin = new System.Windows.Forms.Padding(2);
            this.addFeaturePanel.Name = "addFeaturePanel";
            this.addFeaturePanel.Size = new System.Drawing.Size(137, 142);
            this.addFeaturePanel.TabIndex = 2;
            this.addFeaturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.addFeaturePanel_Paint);
            // 
            // addFeatureLabel
            // 
            this.addFeatureLabel.AutoSize = true;
            this.addFeatureLabel.BackColor = System.Drawing.Color.Gray;
            this.addFeatureLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.addFeatureLabel.LabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addFeatureLabel.Location = new System.Drawing.Point(3, 3);
            this.addFeatureLabel.Margin = new System.Windows.Forms.Padding(3);
            this.addFeatureLabel.Name = "addFeatureLabel";
            this.addFeatureLabel.RoundedRadius = 5;
            this.addFeatureLabel.Size = new System.Drawing.Size(58, 32);
            this.addFeatureLabel.TabIndex = 6;
            this.addFeatureLabel.Text = "Add";
            // 
            // addChecklistButton
            // 
            this.addChecklistButton.BackColor = System.Drawing.Color.Gray;
            this.addChecklistButton.ButtonColor = System.Drawing.Color.Teal;
            this.addChecklistButton.FlatAppearance.BorderSize = 0;
            this.addChecklistButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addChecklistButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addChecklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChecklistButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addChecklistButton.Location = new System.Drawing.Point(3, 94);
            this.addChecklistButton.Margin = new System.Windows.Forms.Padding(4);
            this.addChecklistButton.Name = "addChecklistButton";
            this.addChecklistButton.OnHoverButtonColor = System.Drawing.Color.DarkCyan;
            this.addChecklistButton.RoundedRadius = 10;
            this.addChecklistButton.Size = new System.Drawing.Size(130, 44);
            this.addChecklistButton.TabIndex = 1;
            this.addChecklistButton.Text = "Checklist";
            this.addChecklistButton.UseVisualStyleBackColor = false;
            this.addChecklistButton.Click += new System.EventHandler(this.addChecklistButton_Click);
            // 
            // addDueDateButton
            // 
            this.addDueDateButton.BackColor = System.Drawing.Color.Gray;
            this.addDueDateButton.ButtonColor = System.Drawing.Color.MediumPurple;
            this.addDueDateButton.FlatAppearance.BorderSize = 0;
            this.addDueDateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addDueDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.addDueDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDueDateButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDueDateButton.Location = new System.Drawing.Point(3, 34);
            this.addDueDateButton.Margin = new System.Windows.Forms.Padding(4);
            this.addDueDateButton.Name = "addDueDateButton";
            this.addDueDateButton.OnHoverButtonColor = System.Drawing.Color.DarkSlateBlue;
            this.addDueDateButton.RoundedRadius = 10;
            this.addDueDateButton.Size = new System.Drawing.Size(130, 44);
            this.addDueDateButton.TabIndex = 0;
            this.addDueDateButton.Text = "Due Date";
            this.addDueDateButton.UseVisualStyleBackColor = false;
            this.addDueDateButton.Click += new System.EventHandler(this.addDueDateButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // CardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(900, 684);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardForm";
            this.Load += new System.EventHandler(this.CardForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.informationPanel.ResumeLayout(false);
            this.informationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.descriptionPanel.ResumeLayout(false);
            this.descriptionPanel.PerformLayout();
            this.featurePanel.ResumeLayout(false);
            this.featurePanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observePictureBox)).EndInit();
            this.addFeaturePanel.ResumeLayout(false);
            this.addFeaturePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private MyCustomControl.CustomRichTextBox cardNameRichTextBox;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.FlowLayoutPanel contentPanel;
        private System.Windows.Forms.Panel descriptionPanel;
        private System.Windows.Forms.FlowLayoutPanel checkListPanel;
        private System.Windows.Forms.Panel featurePanel;
        private System.Windows.Forms.Panel dueDatePanel;
        private MyCustomControl.RoundedButton addChecklistButton;
        private MyCustomControl.RoundedButton addDueDateButton;
        private MyCustomControl.RoundedButton observeButton;
        private System.Windows.Forms.Panel addFeaturePanel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.PictureBox observePictureBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private MyCustomControl.DescriptionUserControl descriptionUserControl;
        private MyCustomControl.RoundedLabel actionLabel;
        private MyCustomControl.RoundedLabel addFeatureLabel;
        private MyCustomControl.CircularButton exitButton;
        private System.Windows.Forms.Panel informationPanel;
        private System.Windows.Forms.PictureBox boardPictureBox;
        private System.Windows.Forms.PictureBox listPictureBox;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.Label boardLabel;
    }
}