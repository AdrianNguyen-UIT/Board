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
        Board.Data.CardProp cardProp;
        public DescriptionUserControl()
        {
            InitializeComponent();
        }

        public void LoadData(Board.Data.CardProp _cardProp)
        {
            cardProp = new Board.Data.CardProp();
            cardProp = _cardProp;
            customRichTextBox.ContentText = cardProp.Card_Description;
        }

        private void DescriptionUserControl_Load(object sender, EventArgs e)
        {
            hideButton.Visible = true;
            showButton.Visible = false;
            SetUpCustomRichTextBox();
        }

        private void SetUpCustomRichTextBox()
        {
            customRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            customRichTextBox.FoucesedRichTextBoxColor = Color.White;
            customRichTextBox.SetRichTextBoxMinSize(623, 50);
            customRichTextBox.SetRichTextBoxSize(623, 50);
            customRichTextBox.SetRichTextBoxMaxSize(623, 200);
            topPanel.Size = new Size(690, 35);
            customRichTextBox.SaveMouseDown += CustomRichTextBox_SaveMouseDown;
        }

        private void CustomRichTextBox_SaveMouseDown(object sender, EventArgs e)
        {
            cardProp.Card_Description = customRichTextBox.ContentText;
            Board.Data.DataService.UpdateCard(cardProp);
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
