using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int temptHeight = ((RichTextBox)sender).Height;
            if (temptHeight <= 200)
            {
                ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
            }
        }

        private void descriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            if(descriptionRichTextBox.Text == "Describe this card...")
            {
                descriptionRichTextBox.Text = "";
                descriptionRichTextBox.ForeColor = Color.Black;
            }
        }

        private void descriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            if (descriptionRichTextBox.Text == "")
            {
                descriptionRichTextBox.Text = "Describe this card...";
                descriptionRichTextBox.ForeColor = SystemColors.InactiveCaption;
            }
        }
    }
}
