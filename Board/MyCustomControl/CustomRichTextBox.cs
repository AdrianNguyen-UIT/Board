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
    public partial class CustomRichTextBox : UserControl
    {
        private String contentText;
        private Color backgroundColor;
        private Color nonFocusedsRichTextBoxColor;
        private Color focusedRichTextBoxColor;

        public delegate void CancelMouseDownEventHandler(object sender, EventArgs e);
        public event CancelMouseDownEventHandler CancelMouseDown;

        protected virtual void OnCancelMouseDown()
        {
            if(CancelMouseDown != null)
            {
                CancelMouseDown(this, EventArgs.Empty);
            }
        }

        public delegate void SaveMouseDownEventHandler(object sender, EventArgs e);
        public event CancelMouseDownEventHandler SaveMouseDown;

        protected virtual void OnSaveMouseDown()
        {
            if (SaveMouseDown != null)
            {
                SaveMouseDown(this, EventArgs.Empty);
            }
        }

        public CustomRichTextBox()
        {
            InitializeComponent();
        }

        private void richTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int temptHeight = ((RichTextBox)sender).Height;
            if (temptHeight <= richTextBox.MaximumSize.Height)
            {
                ((RichTextBox)sender).Height = e.NewRectangle.Height;
            }
        }

        private void PerformBeginningState()
        {
            buttonsFlowLayoutPanel.Visible = false;
            richTextBox.BackColor = nonFocusedsRichTextBoxColor;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            contentText = richTextBox.Text;
            OnSaveMouseDown();
            PerformBeginningState();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            richTextBox.Text = contentText;
            OnCancelMouseDown();
            PerformBeginningState();
        }

        public void SetRichTextBoxSize(int width, int height)
        {
            richTextBox.Size = new Size(width, height);
            Invalidate();
        }

        public void SetRichTextBoxSize(Size size)
        {
            richTextBox.Size = size;
            Invalidate();
        }

        public void SetRichTextBoxMaxSize(int maxWidth, int maxHeight)
        {
            richTextBox.MaximumSize = new Size(maxWidth, maxHeight);
            Invalidate();
        }

        public void SetRichTextBoxMaxSize(Size size)
        {
            richTextBox.MaximumSize = size;
            Invalidate();
        }

        public void SetRichTextBoxMinSize(int minWidth, int minHeight)
        {
            richTextBox.MinimumSize = new Size(minWidth, minHeight);
            Invalidate();
        }

        public void SetRichTextBoxMinSize(Size size)
        {
            richTextBox.MinimumSize = size;
            Invalidate();
        }


        public String ContentText
        {
            get
            {
                return contentText;
            }
            set
            {
                contentText = value;
                richTextBox.Text = contentText;
                Invalidate();
            }
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                Invalidate();
            }
        }

        public Color NonFoucesedRichTextBoxColor
        {
            get => nonFocusedsRichTextBoxColor;
            set
            {
                nonFocusedsRichTextBoxColor = value;
                richTextBox.BackColor = nonFocusedsRichTextBoxColor;
                richTextBox.Invalidate();
            }
        }

        public Color FoucesedRichTextBoxColor
        {
            get => focusedRichTextBoxColor;
            set
            {
                focusedRichTextBoxColor = value;
                Invalidate();
            }
        }

        public void SetFont(Font font)
        {
            richTextBox.Font = font;
            Invalidate();
        }

        public void SetSaveAndCancelFlatAppearanceColor(Color color)
        {
            saveButton.FlatAppearance.MouseOverBackColor = color;
            saveButton.FlatAppearance.MouseDownBackColor = color;
            cancelButton.FlatAppearance.MouseOverBackColor = color;
            cancelButton.FlatAppearance.MouseDownBackColor = color;
        }

        private void richTextBox_MouseEnter(object sender, EventArgs e)
        {
            richTextBox.Cursor = Cursors.Hand;
        }

        private void richTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            richTextBox.BackColor = focusedRichTextBoxColor;
            richTextBox.Focus();
            richTextBox.SelectAll();
            buttonsFlowLayoutPanel.Visible = true;
        }

        private void CustomRichTextBox_Load(object sender, EventArgs e)
        {
            PerformBeginningState();
        }

        private void CustomRichTextBox_Leave(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }

        private void richTextBox_Enter(object sender, EventArgs e)
        {
            richTextBox_MouseDown(sender, null);
        }
    }
}
