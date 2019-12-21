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
using System.Globalization;

namespace MyCustomControl
{
    public partial class CheckListUserControl : UserControl
    {
        private Rectangle dragBoxFromMouseDown;

        public CheckListUserControl()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete this checklist?\n" +
                "Once deleted, this checklist cannot be retrieved", "Announce", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                //Delete checklist from database

                Dispose();
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            bottomPanel.Visible = true;
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideButton.Visible = false;
            showButton.Visible = true;
            bottomPanel.Visible = false;
        }

        private void CheckListUserControl_Load(object sender, EventArgs e)
        {
            SetUpCheckListNameCustomRichTextBox();
            SetupBottomPanel();
            hideButton.Visible = true;
            showButton.Visible = false;
        }

        private void SetUpCheckListNameCustomRichTextBox()
        {
            checkListNameRichTextBox.SetRichTextBoxSize(520, 50);
            checkListNameRichTextBox.SetRichTextBoxMaxSize(520, 200);
            checkListNameRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            checkListNameRichTextBox.FoucesedRichTextBoxColor = Color.White;
            checkListNameRichTextBox.SetFont(new Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
        }

        private void OnItemDone(object sender, bool state)
        {
            if (state)
            {
                roundedProgressBar.CheckedCount += 1;
            }
            else
            {
                roundedProgressBar.CheckedCount -= 1;
            }
            roundedProgressBar.Animate();
            percentageNumberLabel.Text = Convert.ToInt32(roundedProgressBar.Value).ToString() + "%";
        }

        private void OnItemDeleted(object sender, bool state)
        {
            if(state)
            {
                roundedProgressBar.CheckedCount -= 1;
            }
            roundedProgressBar.Denominator -= 1;
            roundedProgressBar.Animate();
            percentageNumberLabel.Text = Convert.ToInt32(roundedProgressBar.Value).ToString() + "%";
        }

        #region Bottom Panel 

        private void SetupBottomPanel()
        {
            addItemButtonPanel.Visible = true;
            iscPanel.Visible = false;
        }

        private void itemListPanel_DragDrop(object sender, DragEventArgs e)
        {
            CheckListItemUserControl data = (CheckListItemUserControl)e.Data.GetData(typeof(CheckListItemUserControl));
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

        private void itemListLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            addItemButtonPanel.Visible = false;
            itemRichTextBoxPanel.Visible = true;
            iscPanel.Visible = true;
            itemRichTextBox.Focus();
        }

        private void itemRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int temptHeight = ((RichTextBox)sender).Height;
            if (temptHeight <= itemRichTextBox.MaximumSize.Height)
            {
                ((RichTextBox)sender).Height = e.NewRectangle.Height;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            itemRichTextBox.Text = "";
            SetupBottomPanel();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (itemRichTextBox.Text != "")
            {
                SpawnItem(itemRichTextBox.Text);
                roundedProgressBar.Denominator += 1;
                roundedProgressBar.Animate();
                percentageNumberLabel.Text = Convert.ToInt32(roundedProgressBar.Value).ToString() + "%";
                itemRichTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Cannot add a empty item!", "ERROR");
            }
        }

        private void SpawnItem(String text)
        {
            CheckListItemUserControl item = new CheckListItemUserControl(text);
            item.ItemDone += OnItemDone;
            item.ItemDeleted += OnItemDeleted;
            itemListPanel.Controls.Add(item);
        }

        private void iscPanel_Leave(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }
        #endregion

        #region allow drag and drop control
        private void CheckListUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;
            dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)), dragSize);
        }

        private void CheckListUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void CheckListUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DoDragDrop(this, DragDropEffects.All);
                }
            }
        }
        #endregion

    }
}
