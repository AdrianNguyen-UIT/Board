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
    public partial class DescriptionUserControl : UserControl
    {
        public DescriptionUserControl()
        {
            InitializeComponent();
        }

        private void DescriptionUserControl_Load(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            SetUpCustomRichTextBox();
        }

        private void SetUpCustomRichTextBox()
        {
            customRichTextBox.ContentText = "Describe your card...";
            customRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            customRichTextBox.FoucesedRichTextBoxColor = Color.White;
            customRichTextBox.SetRichTextBoxMinSize(623, 50);
            customRichTextBox.SetRichTextBoxSize(623, 50);
            customRichTextBox.SetRichTextBoxMaxSize(623, 200);
            topPanel.Size = new Size(690, 35);
        }

        
        private void hideButton_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = false;
            hideButton.Visible = false;
            showButton.Visible = true;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = true;
            hideButton.Visible = true;
            showButton.Visible = false;
        }

        public void SetCustomRicTextBoxSize(int width, int height)
        {
            customRichTextBox.SetRichTextBoxSize(width, height);
            Invalidate();
        }
        public void SetCustomRicTextBoxSize(Size size)
        {
            customRichTextBox.SetRichTextBoxSize(size);
            Invalidate();
        }
        public void SetCustomRicTextBoxMinSize(int width, int height)
        {
            customRichTextBox.SetRichTextBoxMinSize(width, height);
            Invalidate();
        }
        public void SetCustomRicTextBoxMinSize(Size size)
        {
            customRichTextBox.SetRichTextBoxMinSize(size);
            Invalidate();
        }
        public void SetCustomRicTextBoxMaxSize(int width, int height)
        {
            customRichTextBox.SetRichTextBoxMaxSize(width, height);
            Invalidate();
        }
        public void SetCustomRicTextBoxMaxSize(Size size)
        {
            customRichTextBox.SetRichTextBoxMaxSize(size);
            Invalidate();
        }
    }
}
