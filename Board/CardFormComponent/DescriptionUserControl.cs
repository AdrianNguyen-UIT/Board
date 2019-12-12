using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Board
{
    public partial class DescriptionUserControl : UserControl
    {
        String temptContent = null;

        public DescriptionUserControl()
        {
            InitializeComponent();
        }

        private void descriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionRichTextBox.Text == "Describe this card...")
            {
                descriptionRichTextBox.Text = "";
                descriptionRichTextBox.ForeColor = Color.Black;
            }
            RevealSaveAndCancelButton();
            descriptionRichTextBox.Cursor = Cursors.IBeam;
            descriptionRichTextBox.BackColor = Color.White;
            descriptionRichTextBox.SelectAll();

        }

        private void descriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            if (descriptionRichTextBox.Text == "")
            {
                descriptionRichTextBox.Text = "Describe this card...";
            }
            ResetDescriptionRichTextBox();
        }

        private void DescriptionUserControl_Load(object sender, EventArgs e)
        {
            HideSaveAndCancelButton();
            ResetDescriptionRichTextBox();

            //Load data from database
            //
            //
            //


            temptContent = descriptionRichTextBox.Text;
            if (descriptionRichTextBox.Text == "")
            {
                descriptionRichTextBox.Text = "Describe this card...";
            }
        }

        private void CancelDescriptionButton_Click(object sender, EventArgs e)
        {
            descriptionRichTextBox.Text = temptContent;
            descriptionRichTextBox_Leave(sender, e);
            SetSaveAndCancelButtonPos();
            HideSaveAndCancelButton();

        }

        private void ResetDescriptionRichTextBox()
        {
            descriptionRichTextBox.Cursor = Cursors.Hand;
            descriptionRichTextBox.BackColor = Color.LightGray;
        }

        private void descriptionRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int temptHeight = ((RichTextBox)sender).Height;
            if (temptHeight <= descriptionRichTextBox.MaximumSize.Height)
            {
                ((RichTextBox)sender).Height = e.NewRectangle.Height;
                if(((RichTextBox)sender).Height > descriptionRichTextBox.MinimumSize.Height)
                {
                    SetSaveAndCancelButtonPos();
                }
            }
        }

        private void SetSaveAndCancelButtonPos()
        {
            descriptionPanel.Height = descriptionRichTextBox.Location.Y + descriptionRichTextBox.Height + 42;
            ClientSize = new Size(Width, descriptionPanel.Height + 6);
        }

        private void SaveDescriptionButton_Click(object sender, EventArgs e)
        {
            temptContent = descriptionRichTextBox.Text;
            descriptionRichTextBox_Leave(sender, e);
            HideSaveAndCancelButton();
            ResetDescriptionRichTextBox();
        }

        private void HideSaveAndCancelButton()
        {
            ClientSize = new Size(Width, descriptionRichTextBox.Location.Y + descriptionRichTextBox.Height + 3 + 6);
        }

        private void RevealSaveAndCancelButton()
        {
            ClientSize = new Size(Width, descriptionRichTextBox.Location.Y + descriptionRichTextBox.Height + 42 + 6);
        }
    }
}
