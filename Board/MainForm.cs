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
    public partial class MainForm : Form
    {
        public List<Boards> listBoards = new List<Boards>();
        private System.Windows.Forms.Panel BoardListPanel;
        private System.Windows.Forms.Button ButtonAddBoard;
        private System.Windows.Forms.Label LBBoard;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel ListListPanel;
        private System.Windows.Forms.Button ButtonAddList;
        public void Init()
        {
            this.BoardListPanel = new System.Windows.Forms.Panel();
            this.ButtonAddBoard = new System.Windows.Forms.Button();
            this.LBBoard = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ListListPanel = new System.Windows.Forms.Panel();
            this.ButtonAddList = new System.Windows.Forms.Button();
            this.BoardListPanel.SuspendLayout();
            this.ListListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoardListPanel
            // 
            this.BoardListPanel.AutoScroll = true;
            this.BoardListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoardListPanel.Controls.Add(this.ButtonAddBoard);
            this.BoardListPanel.Controls.Add(this.DeleteButton);
            this.BoardListPanel.Controls.Add(this.LBBoard);
            this.BoardListPanel.Controls.Add(this.MinimizeButton);
            this.BoardListPanel.Location = new System.Drawing.Point(3, 2);
            this.BoardListPanel.Name = "BoardListPanel";
            this.BoardListPanel.Size = new System.Drawing.Size(211, 534);
            this.BoardListPanel.TabIndex = 0;
            // 
            // ButtonAddBoard
            // 
            this.ButtonAddBoard.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBoard.Location = new System.Drawing.Point(60, 47);
            this.ButtonAddBoard.Name = "ButtonAddBoard";
            this.ButtonAddBoard.Size = new System.Drawing.Size(75, 73);
            this.ButtonAddBoard.TabIndex = 1;
            this.ButtonAddBoard.Text = "+";
            this.ButtonAddBoard.UseVisualStyleBackColor = true;
            this.ButtonAddBoard.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LBBoard
            // 
            this.LBBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LBBoard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBoard.Location = new System.Drawing.Point(9, 7);
            this.LBBoard.Name = "LBBoard";
            this.LBBoard.Size = new System.Drawing.Size(147, 37);
            this.LBBoard.TabIndex = 0;
            this.LBBoard.Text = "Board";
            this.LBBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(162, 46);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(46, 33);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(162, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 33);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "◁";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ListListPanel
            // 
            this.ListListPanel.AutoScroll = true;
            this.ListListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ListListPanel.Controls.Add(this.ButtonAddList);
            this.ListListPanel.Location = new System.Drawing.Point(220, 0);
            this.ListListPanel.Name = "ListListPanel";
            this.ListListPanel.Size = new System.Drawing.Size(648, 534);
            this.ListListPanel.TabIndex = 4;
            // 
            // ButtonAddList
            // 
            this.ButtonAddList.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddList.Location = new System.Drawing.Point(13, 229);
            this.ButtonAddList.Name = "ButtonAddList";
            this.ButtonAddList.Size = new System.Drawing.Size(75, 73);
            this.ButtonAddList.TabIndex = 2;
            this.ButtonAddList.Text = "+";
            this.ButtonAddList.UseVisualStyleBackColor = true;
            this.ButtonAddList.Click += new System.EventHandler(this.ButtonAddList_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 535);
            this.Controls.Add(this.ListListPanel);
            this.Controls.Add(this.BoardListPanel);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.BoardListPanel.ResumeLayout(false);
            this.ListListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        public MainForm()
        {
            Init();
            ButtonAddList.Enabled = false;
            DeleteButton.Enabled = false;
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            ButtonAddBoard.Location = new Point(ButtonAddBoard.Location.X, ButtonAddBoard.Location.Y + 35);
            Boards NewBoard = new Boards();
            NewBoard.Location = new Point(3, ButtonAddBoard.Location.Y - 35);
            NewBoard.Click += NewBoard_Click;
            listBoards.Add(NewBoard);
            BoardListPanel.Controls.Add(NewBoard);
        }

        private void NewBoard_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
            }
            (sender as Boards).BackColor = Color.LightBlue;
            ButtonAddList.Enabled = true;
            DeleteButton.Enabled = true;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + (sender as Boards).list.Count * 205, 229);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (sender as Boards).list.Count; i++)
            {
                ListListPanel.Controls.Add((sender as Boards).list[i]);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ListListPanel.Controls.Clear();
            ButtonAddList.Enabled = false;
            DeleteButton.Enabled = false;
            if (listBoards.Count == 0) return;
            List<Boards> EmptyListBoard = new List<Boards>();
            int Locate = -1;
            for (int i = 0; i < listBoards.Count; i++)
            {
                if (listBoards[i].BackColor == Color.LightBlue)
                {
                    Locate = i;
                    break;
                }
                EmptyListBoard.Add(listBoards[i]);
            }
            if (Locate == -1) return;
            for (int i = 0; i < listBoards.Count; i++)
            {
                BoardListPanel.Controls.Remove(listBoards[i]);
            }
            for (int i = Locate + 1; i < listBoards.Count; i++)
            {
                listBoards[i].Location = new Point(3, listBoards[i].Location.Y - 35);
                EmptyListBoard.Add(listBoards[i]);
            }
            listBoards.Clear();
            listBoards = EmptyListBoard;
            for (int i = 0; i < listBoards.Count; i++)
            {
                BoardListPanel.Controls.Add(listBoards[i]);
            }

            ButtonAddBoard.Location = new Point(ButtonAddBoard.Location.X, ButtonAddBoard.Location.Y - 35);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (MinimizeButton.Text == "▷")
            {
                this.Controls.Remove(MinimizeButton);
                this.Controls.Add(BoardListPanel);
                MinimizeButton.Text = "◁";
                MinimizeButton.Location = new Point(162, 7);
                BoardListPanel.Controls.Add(MinimizeButton);
                ListListPanel.Location = new Point(220, 0);
                ListListPanel.Size = new Size(648, 534);
            }
            else
            {
                this.Controls.Remove(BoardListPanel);
                MinimizeButton.Text = "▷";
                MinimizeButton.Location = new Point(10, 10);
                this.Controls.Add(MinimizeButton);
                ListListPanel.Location = new Point(50, 0);
                ListListPanel.Size = new Size(800, 534);
            }
        }

        private void ButtonAddList_Click(object sender, EventArgs e)
        {
            int Locate = -1;
            for (int i = 0; i < listBoards.Count; i++)
            {
                if (listBoards[i].BackColor == Color.LightBlue)
                {
                    Locate = i;
                    break;
                }
            }
            ButtonAddList.Location = new Point(ButtonAddList.Location.X + 205, ButtonAddList.Location.Y);
            Lists NewList = new Lists();
            NewList.Location = new Point(ButtonAddList.Location.X - 205, 0);
            ListListPanel.Controls.Add(NewList);
            listBoards[Locate].list.Add(NewList);
        }
    }
}
