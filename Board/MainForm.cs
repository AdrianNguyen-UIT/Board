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
        List<Boards> listBoards = new List<Boards>();
        FlowLayoutPanel FlowBoardPanel = new FlowLayoutPanel();
        List<Button> ButtonBoards = new List<Button>();
        private System.Windows.Forms.Panel BoardListPanel;
        private System.Windows.Forms.Button ButtonAddBoard;
        private System.Windows.Forms.Label LBBoard;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ButtonAddList;
        private System.Windows.Forms.Panel ListListPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBoardList;
        public MainForm()
        {
            this.BoardListPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBoardList = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddBoard = new System.Windows.Forms.Button();
            this.LBBoard = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ButtonAddList = new System.Windows.Forms.Button();
            this.ListListPanel = new System.Windows.Forms.Panel();
            this.BoardListPanel.SuspendLayout();
            this.flowLayoutPanelBoardList.SuspendLayout();
            this.ListListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BoardListPanel
            // 
            this.BoardListPanel.AutoScroll = true;
            this.BoardListPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BoardListPanel.Controls.Add(this.flowLayoutPanelBoardList);
            this.BoardListPanel.Controls.Add(this.LBBoard);
            this.BoardListPanel.Controls.Add(this.MinimizeButton);
            this.BoardListPanel.Location = new System.Drawing.Point(3, 2);
            this.BoardListPanel.Name = "BoardListPanel";
            this.BoardListPanel.Size = new System.Drawing.Size(211, 857);
            this.BoardListPanel.TabIndex = 0;
            // 
            // flowLayoutPanelBoardList
            // 
            this.flowLayoutPanelBoardList.AutoScroll = true;
            this.flowLayoutPanelBoardList.Controls.Add(this.ButtonAddBoard);
            this.flowLayoutPanelBoardList.Location = new System.Drawing.Point(5, 42);
            this.flowLayoutPanelBoardList.Name = "flowLayoutPanelBoardList";
            this.flowLayoutPanelBoardList.Size = new System.Drawing.Size(203, 812);
            this.flowLayoutPanelBoardList.TabIndex = 3;
            // 
            // ButtonAddBoard
            // 
            this.ButtonAddBoard.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBoard.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddBoard.Name = "ButtonAddBoard";
            this.ButtonAddBoard.Size = new System.Drawing.Size(180, 29);
            this.ButtonAddBoard.TabIndex = 1;
            this.ButtonAddBoard.Text = "+";
            this.ButtonAddBoard.UseVisualStyleBackColor = true;
            this.ButtonAddBoard.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // LBBoard
            // 
            this.LBBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LBBoard.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBoard.Location = new System.Drawing.Point(6, 7);
            this.LBBoard.Name = "LBBoard";
            this.LBBoard.Size = new System.Drawing.Size(139, 37);
            this.LBBoard.TabIndex = 0;
            this.LBBoard.Text = "Board";
            this.LBBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(151, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 33);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "◁";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ButtonAddList
            // 
            this.ButtonAddList.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddList.Location = new System.Drawing.Point(13, 10);
            this.ButtonAddList.Name = "ButtonAddList";
            this.ButtonAddList.Size = new System.Drawing.Size(75, 73);
            this.ButtonAddList.TabIndex = 2;
            this.ButtonAddList.Text = "+";
            this.ButtonAddList.UseVisualStyleBackColor = true;
            this.ButtonAddList.Click += new System.EventHandler(this.ButtonAddList_Click);
            // 
            // ListListPanel
            // 
            this.ListListPanel.AllowDrop = true;
            this.ListListPanel.AutoScroll = true;
            this.ListListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ListListPanel.Controls.Add(this.ButtonAddList);
            this.ListListPanel.Location = new System.Drawing.Point(220, 0);
            this.ListListPanel.Name = "ListListPanel";
            this.ListListPanel.Size = new System.Drawing.Size(1362, 859);
            this.ListListPanel.TabIndex = 4;
            this.ListListPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListListPanel_DragDrop);
            this.ListListPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListListPanel_DragEnter);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ListListPanel);
            this.Controls.Add(this.BoardListPanel);
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BoardListPanel.ResumeLayout(false);
            this.flowLayoutPanelBoardList.ResumeLayout(false);
            this.ListListPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            FlowBoardPanel.Size = new Size(60, 857);
            FlowBoardPanel.Location = new Point(0, 0);
            FlowBoardPanel.AutoScroll = true;
            ButtonAddList.Enabled = false;
        }
        #region Add Boards 
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Boards NewBoard = new Boards();
            NewBoard.Size = new Size(175, 30);
            NewBoard.Click += NewBoard_Click;
            NewBoard.BoardName.Click += BoardName_Click;
            NewBoard.Deleted += NewBoard_Deleted;
            listBoards.Add(NewBoard);
            flowLayoutPanelBoardList.Controls.Remove(ButtonAddBoard);
            flowLayoutPanelBoardList.Controls.Add(NewBoard);
            flowLayoutPanelBoardList.Controls.Add(ButtonAddBoard);
        }

        private void BoardName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
                listBoards[i].Size = new Size(175, 30);
            }
            (sender as TextBox).ReadOnly = false;
            (((sender as TextBox).Parent) as Boards).BackColor = Color.LightBlue;
            (((sender as TextBox).Parent) as Boards).Size = new Size(175, 71);
            ButtonAddList.Enabled = true;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + (((sender as TextBox).Parent) as Boards).list.Count * 205, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (((sender as TextBox).Parent) as Boards).list.Count; i++)
            {
                (((sender as TextBox).Parent) as Boards).list[i].Location = new Point(13 + 205 * i, 0);
                ListListPanel.Controls.Add((((sender as TextBox).Parent) as Boards).list[i]);
            }
        }

        private void NewBoard_Deleted(object sender, EventArgs e)
        {
            listBoards.Remove(sender as Boards);
            flowLayoutPanelBoardList.Controls.Remove(sender as Boards);
            if ((sender as Boards).BackColor == Color.LightBlue) ListListPanel.Controls.Clear();
        }

        private void NewBoard_Click(object sender, EventArgs e)
        {
            (sender as Boards).BoardName_Validated(sender, e);
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
                listBoards[i].Size = new Size(175, 30);
            }
            (sender as Boards).BackColor = Color.LightBlue;
            ButtonAddList.Enabled = true;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + (sender as Boards).list.Count * 205, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (sender as Boards).list.Count; i++)
            {
                (sender as Boards).list[i].Location = new Point(13 + 205 * i, 0);
                ListListPanel.Controls.Add((sender as Boards).list[i]);
            }
        }
        #endregion
        #region Minimize button
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (MinimizeButton.Text == "▷")
            {
                FlowBoardPanel.Controls.Clear();
                this.Controls.Remove(FlowBoardPanel);
                this.Controls.Add(BoardListPanel);
                MinimizeButton.Text = "◁";
                MinimizeButton.Location = new Point(151, 7);
                BoardListPanel.Controls.Add(MinimizeButton);
                ListListPanel.Location = new Point(220, 0);
                ListListPanel.Size = new Size(1362, 859);
            }
            else
            {
                this.Controls.Remove(BoardListPanel);
                this.Controls.Add(FlowBoardPanel);
                MinimizeButton.Text = "▷";
                FlowBoardPanel.Controls.Add(MinimizeButton);
                ListListPanel.Location = new Point(65, 0);
                ListListPanel.Size = new Size(1500, 859);
                ButtonBoards.Clear();
                for (int i = 0; i < listBoards.Count; i++)
                {
                    Button newButton = new Button();
                    newButton.Text = i + "";
                    newButton.BackColor = Color.White;
                    if (listBoards[i].BackColor == Color.LightBlue)
                        newButton.BackColor = Color.LightBlue;
                    newButton.Click += NewButton_Click;
                    newButton.Size = new Size(37, 33);
                    FlowBoardPanel.Controls.Add(newButton);
                    ButtonBoards.Add(newButton);
                }
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ButtonBoards.Count; i++)
            {
                ButtonBoards[i].BackColor = Color.White;
            }
            (sender as Button).BackColor = Color.LightBlue;
            ListListPanel.Controls.Clear();
            int Locate = int.Parse((sender as Button).Text);
            ButtonAddList.Enabled = true;
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
            }
            listBoards[Locate].BackColor = Color.LightBlue;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + listBoards[Locate].list.Count * 205, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (listBoards[Locate]).list.Count; i++)
            {
                listBoards[Locate].list[i].Location = new Point(13 + 205 * i, 0);
                ListListPanel.Controls.Add((listBoards[Locate]).list[i]);
            }
        }
        #endregion
        #region Add List in ListPanel
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
            NewList.Deleted += NewList_Deleted;
            ListListPanel.Controls.Add(NewList);
            listBoards[Locate].list.Add(NewList);
        }

        private void NewList_Deleted(object sender, EventArgs e)
        {
            Lists uc = sender as Lists;
            int Locate = -1;
            for (int i = 0; i < listBoards.Count; i++)
            {
                if (listBoards[i].BackColor == Color.LightBlue)
                {
                    Locate = i;
                    break;
                }
            }
            int listLocate = listBoards[Locate].list.IndexOf(uc);
            listBoards[Locate].list.Remove(uc);
            ListListPanel.Controls.Remove(uc);
            for (int i = listLocate; i < (listBoards[Locate]).list.Count; i++)
            {
                listBoards[Locate].list[i].Location = new Point(listBoards[Locate].list[i].Location.X - 205, 0);
            }
            ButtonAddList.Location = new Point(ButtonAddList.Location.X - 205, 10);
        }
        #endregion
        #region Allow to drag and drop Lists in ListPanel
        private void ListListPanel_DragDrop(object sender, DragEventArgs e)
        {
            int listlocate = 0;
            int i1 = 0;
            int i2 = 0;
            for (int i = 0; i < listBoards.Count; i++)
            {
                if (listBoards[i].BackColor == Color.LightBlue)
                {
                    listlocate = i;
                    break;
                }
            }
            Lists element = e.Data.GetData("Object") as Lists;
            if (element == null) return;
            Panel target = (Panel)sender;
            Point p = target.PointToClient(new Point(e.X, e.Y));
            Lists item = target.GetChildAtPoint(p) as Lists;
            if (item != null)
            {
                for (int i = 0; i < (listBoards[listlocate].list.Count); i++)
                {
                    if (i1 != 0 && i2 != 0) break;
                    if (listBoards[listlocate].list[i] == item)
                    {
                        i1 = i;
                    }
                    else if (listBoards[listlocate].list[i] == element)
                    {
                        i2 = i;
                    }
                }
            }
            else
            {
                i1 = listBoards[listlocate].list.Count - 1;
                for (int i = 0; i < (listBoards[listlocate].list.Count); i++)
                {
                    if (listBoards[listlocate].list[i] == element)
                    {
                        i2 = i;
                        break;
                    }
                }
            }
            Lists temp = listBoards[listlocate].list[i1];
            listBoards[listlocate].list[i1] = listBoards[listlocate].list[i2];
            listBoards[listlocate].list[i2] = temp;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + listBoards[listlocate].list.Count * 205, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (listBoards[listlocate].list.Count); i++)
            {
                (listBoards[listlocate]).list[i].Location = new Point(13 + 205 * i, 0);
                ListListPanel.Controls.Add((listBoards[listlocate]).list[i]);
            }
        }

        private void ListListPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        #endregion
    }
}
