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
        public Board.Data.CheckListProp checkListProp;
        public List<Board.Data.ItemProp> itemProps;

        public CheckListUserControl()
        {
            InitializeComponent();
        }

        public delegate void CheckListDeletedEvenHandler(object sender, EventArgs e);
        public event CheckListDeletedEvenHandler CheckListDeleted;
        protected virtual void OnCheckListDeleted()
        {
            if (CheckListDeleted != null)
            {
                CheckListDeleted(this, null);
            }
        }

        public delegate void ResetEvenHandler(object sender, EventArgs e);
        public event ResetEvenHandler Reset;
        protected virtual void OnReset()
        {
            if (Reset != null)
            {
               Reset(this, null);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete this Checklist?\n" +
                "Once deleted, this Checklist cannot be retrieved", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Board.Data.DataService.DeleteCheckList(checkListProp);
                OnCheckListDeleted();
                Dispose();
            }
        }

        public void OnSpawned()
        {
            checkListNameRichTextBox.Focus();
        }

        private void OnSaveMouseDown(object sender, EventArgs e)
        {
            checkListProp.CheckList_Name = checkListNameRichTextBox.ContentText;
            Board.Data.DataService.UpdateCheckList(checkListProp);
            
        }

        public void LoadData(Board.Data.CheckListProp _checkListProp)
        {
            checkListProp = new Board.Data.CheckListProp();
            checkListProp = _checkListProp;
            LoadCheckListName(checkListProp.CheckList_Name);
            LoadItemList();
            ResetItemPosition();
        }

        private void LoadCheckListName(String name)
        {
            checkListNameRichTextBox.ContentText = name;
        }

        private void LoadItemList()
        {
            itemProps = Board.Data.DataService.GetItemByCheckListID(checkListProp.CheckList_ID);
            foreach (Board.Data.ItemProp itemProp in itemProps)
            {
                SpawnItem(itemProp);
            }
        }
        public void SpawnItem()
        {
            Board.Data.ItemProp itemProp = new Board.Data.ItemProp();
            itemProp.Item_Description = itemRichTextBox.Text;
            itemProp.CheckList_ID = checkListProp.CheckList_ID;
            itemProp.Item_Checked = false;
            itemProp.Item_Position = itemProps.Count;

            Board.Data.DataService.InsertItem(itemProp);
            itemProps = Board.Data.DataService.GetItemByCheckListID(checkListProp.CheckList_ID);

            SpawnItem(itemProps[itemProps.Count - 1]);

        }

        public void SpawnItem(Board.Data.ItemProp itemProp)
        {
            CheckListItemUserControl item = new CheckListItemUserControl();
            item.ItemDone += OnItemDone;
            item.ItemDeleted += OnItemDeleted;
            item.LoadData(itemProp);

            itemListPanel.Controls.Add(item);
            itemListPanel.Controls.SetChildIndex(item, itemProp.Item_Position);

            roundedProgressBar.Denominator += 1;
            roundedProgressBar.Animate();
            percentageNumberLabel.Text = Convert.ToInt32(roundedProgressBar.Value).ToString() + "%";

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
            checkListNameRichTextBox.SaveMouseDown += OnSaveMouseDown;
        }

        private void SetUpCheckListNameCustomRichTextBox()
        {
            checkListNameRichTextBox.SetRichTextBoxSize(520, 50);
            checkListNameRichTextBox.SetRichTextBoxMaxSize(520, 200);
            checkListNameRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            checkListNameRichTextBox.FoucesedRichTextBoxColor = Color.White;
            checkListNameRichTextBox.SetFont(new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
        }

        private void OnItemDone(object sender, bool state)
        {
            itemProps = Board.Data.DataService.GetItemByCheckListID(checkListProp.CheckList_ID);
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
            itemProps = Board.Data.DataService.GetItemByCheckListID(checkListProp.CheckList_ID);
            ResetItemPosition();
            if (state)
            {
                roundedProgressBar.CheckedCount -= 1;
            }
            roundedProgressBar.Denominator -= 1;
            roundedProgressBar.Animate();
            percentageNumberLabel.Text = Convert.ToInt32(roundedProgressBar.Value).ToString() + "%";
        }

        public void SetCheckListPosition(int index)
        {
            checkListProp.CheckList_Position = index;
            Board.Data.DataService.UpdateCheckList(checkListProp);
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

                CheckListUserControl checkListUserControl = target.Parent.Parent.Parent as CheckListUserControl;
                Board.Data.ItemProp _itemProp = new Board.Data.ItemProp();
                _itemProp.Item_Checked = data.itemProp.Item_Checked;
                _itemProp.Item_Description = data.itemProp.Item_Description;
                _itemProp.Item_Position = index;
                _itemProp.CheckList_ID = checkListUserControl.checkListProp.CheckList_ID;
                _itemProp.Item_ID = data.itemProp.Item_ID;
                Board.Data.DataService.UpdateItem(_itemProp);
                OnReset();

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

                ResetItemPosition();
            }
        }

        public void ResetItemPosition()
        {
            foreach (CheckListItemUserControl item in itemListPanel.Controls)
            {
                item.SetItemPosition(itemListPanel.Controls.GetChildIndex(item));
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
                SpawnItem();
                itemRichTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Cannot add a empty item!", "ERROR");
            }
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
