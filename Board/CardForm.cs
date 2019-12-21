using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCustomControl;
using System.Media;
namespace Board
{
    public partial class CardForm : Form
    {
        List<CheckListUserControl> clList = new List<CheckListUserControl>();
        DueDateUserControl dueDateUserControl;
        bool isObserving = false;


        public CardForm()
        {
            InitializeComponent();
        }

        private  void OnShowNotification(object sender, EventArgs e)
        {
            if(isObserving)
            {
                Console.WriteLine("\a");
                notifyIcon.ShowBalloonTip(10000, "Notification", "You got 1 notification", ToolTipIcon.Info);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomizeCardNameRichTextBox()
        {
            cardNameRichTextBox.SetRichTextBoxSize(750, 30);
            cardNameRichTextBox.SetRichTextBoxMinSize(750, 30);
            cardNameRichTextBox.SetRichTextBoxMaxSize(750, 200);
            cardNameRichTextBox.SetFont(new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            cardNameRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            cardNameRichTextBox.FoucesedRichTextBoxColor = Color.White;
            cardNameRichTextBox.SetSaveAndCancelFlatAppearanceColor(topPanel.BackColor);
        }


        private void CardForm_Load(object sender, EventArgs e)
        {
            CustomizeCardNameRichTextBox();
            notifyIcon.Icon = SystemIcons.Application;
        }

        private void descriptionPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, descriptionPanel.Width + 1, descriptionPanel.Height + 1), 6);

        }

        #region allow to drag and drop CheckListUserControl in checkListPanel
        private void checkListPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void checkListPanel_DragDrop(object sender, DragEventArgs e)
        {
            CheckListUserControl data = (CheckListUserControl)e.Data.GetData(typeof(CheckListUserControl));
            if(data == null)
            {
                return;
            }
            FlowLayoutPanel target = (FlowLayoutPanel)sender;
            FlowLayoutPanel source = (FlowLayoutPanel)data.Parent;

            if (source != target)
            {
                // Add control to panel
                target.Controls.Add(data);

                // Reorder
                Point p = target.PointToClient(new Point(e.X, e.Y));
                var item = target.GetChildAtPoint(p);
                int index = target.Controls.GetChildIndex(item, false);
                target.Controls.SetChildIndex(data, index);

                // Invalidate to paint!
                target.Invalidate();
                source.Invalidate();
            }
            else
            {
                // Just add the control to the new panel.
                // No need to remove from the other panel, this changes the Control.Parent property.
                Point p = target.PointToClient(new Point(e.X, e.Y));
                var item = target.GetChildAtPoint(p);
                int index = target.Controls.GetChildIndex(item, false);
                target.Controls.SetChildIndex(data, index);
                target.Invalidate();
            }
        }
        #endregion

        
        #region Paint rounded corner for Des, CheckList, DueDate, Action, Add panel
        private void descriptionPanel_SizeChanged(object sender, EventArgs e)
        {
            descriptionPanel.Invalidate();
        }

        private void checkListPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, checkListPanel.Width + 1, checkListPanel.Height + 1), 6);
        }

        private void checkListPanel_SizeChanged(object sender, EventArgs e)
        {
            checkListPanel.Invalidate();
        }

        private void dueDatePanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, dueDatePanel.Width + 1, dueDatePanel.Height + 1), 6);
        }

        private void dueDatePanel_SizeChanged(object sender, EventArgs e)
        {
            dueDatePanel.Invalidate();
        }

        private void addFeaturePanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, addFeaturePanel.Width + 1, addFeaturePanel.Height + 1), 6);
        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, actionPanel.Width + 1, actionPanel.Height + 1), 6);
        }

        private void actionPanel_SizeChanged(object sender, EventArgs e)
        {
            actionPanel.Invalidate();
        }

        #endregion

        private void addChecklistButton_Click(object sender, EventArgs e)
        {
            CheckListUserControl checkListUserControl = new CheckListUserControl();
            checkListUserControl.AutoSize = true;
            checkListUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            checkListUserControl.BackColor = System.Drawing.Color.Teal;
            checkListUserControl.Location = new System.Drawing.Point(5, 5);
            checkListUserControl.Margin = new System.Windows.Forms.Padding(5,10,5,10);
            checkListUserControl.Name = "checkListUserControl";
            checkListUserControl.Size = new System.Drawing.Size(693, 130);
            checkListPanel.Controls.Add(checkListUserControl);
            clList.Add(checkListUserControl);
        }

        private void addDueDateButton_Click(object sender, EventArgs e)
        {
            if (dueDateUserControl == null)
            {
                dueDateUserControl = new DueDateUserControl();
                dueDateUserControl.AutoSize = true;
                dueDateUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                dueDateUserControl.BackColor = System.Drawing.Color.MediumPurple;
                dueDateUserControl.Location = new System.Drawing.Point(5, 5);
                dueDateUserControl.Margin = new System.Windows.Forms.Padding(5);
                dueDateUserControl.Name = "dueDateUserControl";
                dueDateUserControl.Size = new System.Drawing.Size(690, 126);
                dueDateUserControl.TabIndex = 2;
                dueDateUserControl.ShowNotification += OnShowNotification;
                dueDatePanel.Controls.Add(dueDateUserControl);
            }
        }

        private void observeButton_Click(object sender, EventArgs e)
        {
            observePictureBox.Visible = !observePictureBox.Visible;
            if(observePictureBox.Visible)
            {
                isObserving = true;
            }
            else
            {
                isObserving = false;
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new Region(path);
            base.OnPaint(e);
        }
    }
}
