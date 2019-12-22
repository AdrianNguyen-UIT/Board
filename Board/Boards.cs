using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Board
{
    public partial class Boards : UserControl
    {
        public System.Windows.Forms.TextBox BoardName;
        private MyCustomControl.CircularButton DeleteButtonBoard;
        private MyCustomControl.RoundedButton saveButton;
        private MyCustomControl.RoundedButton cancelButton;
        string NameBoard;
        string temp;
        public List<Lists> list = new List<Lists>();
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public Boards()
        {
            this.BoardName = new System.Windows.Forms.TextBox();
            this.DeleteButtonBoard = new MyCustomControl.CircularButton();
            this.saveButton = new MyCustomControl.RoundedButton();
            this.cancelButton = new MyCustomControl.RoundedButton();
            this.SuspendLayout();
            // 
            // BoardName
            // 
            this.BoardName.Location = new System.Drawing.Point(3, 3);
            this.BoardName.Name = "BoardName";
            this.BoardName.ReadOnly = true;
            this.BoardName.Size = new System.Drawing.Size(100, 20);
            this.BoardName.TabIndex = 0;
            this.BoardName.Validated += new System.EventHandler(this.BoardName_Validated);
            // 
            // DeleteButtonBoard
            // 
            this.DeleteButtonBoard.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButtonBoard.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.DeleteButtonBoard.FlatAppearance.BorderSize = 0;
            this.DeleteButtonBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.DeleteButtonBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButtonBoard.Image = global::Board.Properties.Resources.CloseIcon16;
            this.DeleteButtonBoard.Location = new System.Drawing.Point(120, 0);
            this.DeleteButtonBoard.Name = "DeleteButtonBoard";
            this.DeleteButtonBoard.Size = new System.Drawing.Size(52, 30);
            this.DeleteButtonBoard.TabIndex = 4;
            this.DeleteButtonBoard.UseVisualStyleBackColor = false;
            this.DeleteButtonBoard.Click += new System.EventHandler(this.DeleteButtonBoard_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(7, 37);
            this.saveButton.Margin = new System.Windows.Forms.Padding(1);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.saveButton.RoundedRadius = 10;
            this.saveButton.Size = new System.Drawing.Size(84, 33);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(93, 37);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverButtonColor = System.Drawing.Color.Red;
            this.cancelButton.RoundedRadius = 10;
            this.cancelButton.Size = new System.Drawing.Size(79, 33);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Boards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.DeleteButtonBoard);
            this.Controls.Add(this.BoardName);
            this.Name = "Boards";
            this.Size = new System.Drawing.Size(175, 71);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DeleteButtonBoard_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(175, 30);
            NameBoard = temp;
            BoardName.Text = NameBoard;
            BoardName.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(175, 30);
            BoardName.Text = NameBoard;
            BoardName.ReadOnly = true;
        }

        public void BoardName_Validated(object sender, EventArgs e)
        {
            temp = BoardName.Text;
            BoardName.Text = NameBoard;
            BoardName.ReadOnly = true;
        }
    }
}

