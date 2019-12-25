using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomControl
{
    public partial class CheckListItemUserControl : UserControl
    {
        private Rectangle dragBoxFromMouseDown;
        public Board.Data.ItemProp itemProp;

        public delegate void ItemDoneEnventHandler(object sender, bool state);
        public event ItemDoneEnventHandler ItemDone;

        public delegate void ItemDeletedEvenHandler(object sender, bool state);
        public event ItemDeletedEvenHandler ItemDeleted;

        public bool Checked 
        {
            get => checkBox.Checked;
        }
        protected virtual void OnItemDone(bool state)
        {
            if (ItemDone != null)
            {
                ItemDone(this, state);
            }
        }

        protected virtual void OnItemDeleted(bool state)
        {
            if (ItemDeleted != null)
            {
                ItemDeleted(this, state);
            }
        }

        public CheckListItemUserControl()
        {
            InitializeComponent();

        }

        public void SetItemPosition(int index)
        {
            itemProp.Item_Position = index;
            Board.Data.DataService.UpdateItem(itemProp);
        }

        public void LoadData(Board.Data.ItemProp _itemProp)
        {
            itemProp = new Board.Data.ItemProp();
            itemProp = _itemProp;
            LoadCheckedState(itemProp.Item_Checked);
            LoadItemContent(itemProp.Item_Description);
        }

        private void LoadItemContent(String content)
        {
            customRichTextBox.ContentText = content;
        }

        private void LoadCheckedState(bool state)
        {
            checkBox.Checked = state;
        }

        private void CheckListItemUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            Size dragSize = SystemInformation.DragSize;
            dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)), dragSize);
        }

        private void CheckListItemUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void CheckListItemUserControl_MouseMove(object sender, MouseEventArgs e)
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

        private void CheckListItemUserControl_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DimGray;
        }

        private void CheckListItemUserControl_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void SetUpCustomRichTextBox()
        {
            customRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            customRichTextBox.FoucesedRichTextBoxColor = Color.White;
            customRichTextBox.SetRichTextBoxMinSize(589, 25);
            customRichTextBox.SetRichTextBoxSize(589, 25);
            customRichTextBox.SetRichTextBoxMaxSize(589, 200);
        }

        private void CheckListItemUserControl_Load(object sender, EventArgs e)
        {
            SetUpCustomRichTextBox();
            deleteButton.Location = new Point(customRichTextBox.Width + customRichTextBox.Location.X + 4, customRichTextBox.Location.Y + 3);
            customRichTextBox.SaveMouseDown += CustomRichTextBox_SaveMouseDown;
        }

        private void CustomRichTextBox_SaveMouseDown(object sender, EventArgs e)
        {
            itemProp.Item_Description = customRichTextBox.ContentText;
            Board.Data.DataService.UpdateItem(itemProp);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender) != null)
            {
                if(((CheckBox)sender).Checked == true)
                {
                    itemProp.Item_Checked = true;
                    customRichTextBox.SetFont(new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
                }
                else
                {
                    itemProp.Item_Checked = false;
                    customRichTextBox.SetFont(new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
                }
                Board.Data.DataService.UpdateItem(itemProp);
                OnItemDone(((CheckBox)sender).Checked);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete this Item?\n" +
                "Once deleted, this Item cannot be retrieved", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Board.Data.DataService.DeleteItem(itemProp);
                OnItemDeleted(checkBox.Checked);
                this.Dispose();
            }
        }
    }
}
