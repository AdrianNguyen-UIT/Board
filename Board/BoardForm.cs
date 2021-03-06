﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Board.Components;
namespace Board
{
    public partial class BoardForm : Form
    {
        List<Boards> listBoards = new List<Boards>();
        FlowLayoutPanel FlowBoardPanel = new FlowLayoutPanel();
        List<Button> ButtonBoards = new List<Button>();
        private System.Windows.Forms.Panel BoardListPanel;
        private System.Windows.Forms.Label LBBoard;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel ListListPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBoardList;
        private MyCustomControl.RoundedButton ButtonAddBoard;
        private MyCustomControl.RoundedButton ButtonAddList;

        List<Data.BoardProp> boardProps;

        public BoardForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.BoardListPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanelBoardList = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonAddBoard = new MyCustomControl.RoundedButton();
            this.LBBoard = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ListListPanel = new System.Windows.Forms.Panel();
            this.ButtonAddList = new MyCustomControl.RoundedButton();
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
            this.flowLayoutPanelBoardList.AllowDrop = true;
            this.flowLayoutPanelBoardList.AutoScroll = true;
            this.flowLayoutPanelBoardList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelBoardList.Controls.Add(this.ButtonAddBoard);
            this.flowLayoutPanelBoardList.Location = new System.Drawing.Point(5, 42);
            this.flowLayoutPanelBoardList.Name = "flowLayoutPanelBoardList";
            this.flowLayoutPanelBoardList.Size = new System.Drawing.Size(203, 812);
            this.flowLayoutPanelBoardList.TabIndex = 3;
            this.flowLayoutPanelBoardList.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanelBoardList_DragDrop);
            this.flowLayoutPanelBoardList.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanelBoardList_DragEnter);
            // 
            // ButtonAddBoard
            // 
            this.ButtonAddBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddBoard.ButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddBoard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddBoard.FlatAppearance.BorderSize = 0;
            this.ButtonAddBoard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.ButtonAddBoard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.ButtonAddBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddBoard.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddBoard.Image = global::Board.Properties.Resources.AddIcon;
            this.ButtonAddBoard.Location = new System.Drawing.Point(3, 3);
            this.ButtonAddBoard.Name = "ButtonAddBoard";
            this.ButtonAddBoard.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddBoard.RoundedRadius = 2;
            this.ButtonAddBoard.Size = new System.Drawing.Size(180, 29);
            this.ButtonAddBoard.TabIndex = 8;
            this.ButtonAddBoard.UseVisualStyleBackColor = false;
            this.ButtonAddBoard.Click += new System.EventHandler(this.ButtonAddBoard_Click);
            // 
            // LBBoard
            // 
            this.LBBoard.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LBBoard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBBoard.Location = new System.Drawing.Point(6, 7);
            this.LBBoard.Name = "LBBoard";
            this.LBBoard.Size = new System.Drawing.Size(159, 32);
            this.LBBoard.TabIndex = 0;
            this.LBBoard.Text = "Board";
            this.LBBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.Location = new System.Drawing.Point(171, 7);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 33);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.Text = "◁";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
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
            // ButtonAddList
            // 
            this.ButtonAddList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddList.ButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddList.FlatAppearance.BorderSize = 0;
            this.ButtonAddList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.ButtonAddList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.ButtonAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddList.Image = global::Board.Properties.Resources.AddIcon;
            this.ButtonAddList.Location = new System.Drawing.Point(13, 10);
            this.ButtonAddList.Name = "ButtonAddList";
            this.ButtonAddList.OnHoverButtonColor = System.Drawing.Color.Transparent;
            this.ButtonAddList.RoundedRadius = 2;
            this.ButtonAddList.Size = new System.Drawing.Size(75, 68);
            this.ButtonAddList.TabIndex = 9;
            this.ButtonAddList.UseVisualStyleBackColor = false;
            this.ButtonAddList.Click += new System.EventHandler(this.ButtonAddList_Click);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.ListListPanel);
            this.Controls.Add(this.BoardListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Board";
            this.Load += BoardForm_Load;
            this.BoardListPanel.ResumeLayout(false);
            this.flowLayoutPanelBoardList.ResumeLayout(false);
            this.ListListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            FlowBoardPanel.Size = new Size(60, 857);
            FlowBoardPanel.Location = new Point(0, 0);
            FlowBoardPanel.AutoScroll = true;
            ButtonAddList.Enabled = false;
        }

        private void BoardForm_Load(object sender, EventArgs e)
        {
            boardProps = new List<Data.BoardProp>();
            boardProps = Data.DataService.GetAllBoard();
            int count = 0;
            foreach (Data.BoardProp boardProp in boardProps)
            {
                Boards NewBoard = new Boards();
                NewBoard.Size = new Size(175, 42);
                NewBoard.LoadData(boardProp);
                NewBoard.DoubleClick += NewBoard_Click;
                NewBoard.BoardName.Click += BoardName_Click;
                NewBoard.Deleted += NewBoard_Deleted;
                listBoards.Add(NewBoard);
                flowLayoutPanelBoardList.Controls.Remove(ButtonAddBoard);
                flowLayoutPanelBoardList.Controls.Add(NewBoard);
                flowLayoutPanelBoardList.Controls.Add(ButtonAddBoard);

                foreach (Data.ListProp listProp in NewBoard.listProps)
                {
                    Lists NewList = new Lists();
                    NewList.LoadData(listProp);
                    NewList.SecondFormShowed += NewList_SecondFormShowed;
                    NewList.SecondFormClosed += NewList_SecondFormClosed;
                    NewList.Deleted += NewList_Deleted;
                    NewBoard.list.Add(NewList);
                }
                if (count == 0)
                {
                    NewBoard_Click(NewBoard, e);
                    count++;
                }
            }

        }

        private void ResetListPropsIneEachBoard()
        {
            foreach (Boards boards in listBoards)
            {
                boards.listProps = Data.DataService.GetListByBoardID(boards.boardProp.Board_ID);
            }
        }

        private void NewList_SecondFormClosed(object sender, EventArgs e)
        {
            BoardForm boardForm = new BoardForm();
            boardForm.Show();
        }

        private void NewList_SecondFormShowed(object sender, EventArgs e)
        {
            Hide();
        }
        #region Add Boards 
        private void ButtonAddBoard_Click(object sender, EventArgs e)
        {
            Boards NewBoard = new Boards();
            NewBoard.Size = new Size(175, 42);
            NewBoard.NameBoard = "Board (" + (listBoards.Count + 1) + ")";
            NewBoard.BoardName.Text = NewBoard.NameBoard;
            NewBoard.DoubleClick += NewBoard_Click;
            NewBoard.BoardName.Click += BoardName_Click;
            NewBoard.Deleted += NewBoard_Deleted;
            listBoards.Add(NewBoard);
            flowLayoutPanelBoardList.Controls.Remove(ButtonAddBoard);
            flowLayoutPanelBoardList.Controls.Add(NewBoard);
            flowLayoutPanelBoardList.Controls.Add(ButtonAddBoard);

            Data.BoardProp boardProp = new Data.BoardProp();
            boardProp.Board_Name = NewBoard.NameBoard;
            boardProp.Board_Position = listBoards.Count - 1;
            Data.DataService.InsertBoard(boardProp);

            boardProps = Data.DataService.GetAllBoard();
            NewBoard.boardProp = boardProps[boardProps.Count - 1];

        }
        private void BoardName_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
                listBoards[i].Size = new Size(175, 42);
            }
            (sender as TextBox).ReadOnly = false;
            (((sender as TextBox).Parent) as Boards).BackColor = Color.LightBlue;
            (((sender as TextBox).Parent) as Boards).Size = new Size(175, 93);
            ButtonAddList.Enabled = true;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + (((sender as TextBox).Parent) as Boards).list.Count * 300, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (((sender as TextBox).Parent) as Boards).list.Count; i++)
            {
                (((sender as TextBox).Parent) as Boards).list[i].Location = new Point(13 + 300 * i, 0);
                ListListPanel.Controls.Add((((sender as TextBox).Parent) as Boards).list[i]);
            }
            LBBoard.Text = (sender as TextBox).Text;
        }

        private void NewBoard_Deleted(object sender, EventArgs e)
        {
            listBoards.Remove(sender as Boards);
            flowLayoutPanelBoardList.Controls.Remove(sender as Boards);
            if ((sender as Boards).BackColor == Color.LightBlue) ListListPanel.Controls.Clear();
            boardProps = Data.DataService.GetAllBoard();
        }

        private void NewBoard_Click(object sender, EventArgs e)
        {
            (sender as Boards).BoardName_Validated(sender, e);
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
                listBoards[i].Size = new Size(175, 42);
            }
            (sender as Boards).BackColor = Color.LightBlue;
            ButtonAddList.Enabled = true;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + (sender as Boards).list.Count * 300, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (sender as Boards).list.Count; i++)
            {
                (sender as Boards).list[i].Location = new Point(13 + 300 * i, 0);
                ListListPanel.Controls.Add((sender as Boards).list[i]);
            }
            LBBoard.Text = (sender as Boards).BoardName.Text;
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
                MinimizeButton.Location = new Point(171, 7);
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
                    newButton.Text = (i+1) + "";
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
            int Locate = int.Parse((sender as Button).Text) - 1;
            ButtonAddList.Enabled = true;
            for (int i = 0; i < listBoards.Count; i++)
            {
                listBoards[i].BackColor = Color.White;
            }
            listBoards[Locate].BackColor = Color.LightBlue;
            LBBoard.Text = listBoards[Locate].BoardName.Text;
            ListListPanel.Controls.Clear();
            ButtonAddList.Location = new Point(13 + listBoards[Locate].list.Count * 300, 10);
            ListListPanel.Controls.Add(ButtonAddList);
            for (int i = 0; i < (listBoards[Locate]).list.Count; i++)
            {
                listBoards[Locate].list[i].Location = new Point(13 + 300 * i, 0);
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
            ButtonAddList.Location = new Point(ButtonAddList.Location.X + 300, ButtonAddList.Location.Y);
            Lists NewList = new Lists();
            NewList.TextboxListName.Text = "List (" + (listBoards[Locate].list.Count + 1) + ")";
            NewList.NameLists = NewList.TextboxListName.Text;
            NewList.Location = new Point(ButtonAddList.Location.X - 300, 0);
            NewList.Deleted += NewList_Deleted;
            NewList.SecondFormShowed += NewList_SecondFormShowed;
            NewList.SecondFormClosed += NewList_SecondFormClosed;
            listBoards[Locate].list.Add(NewList);
            ListListPanel.Controls.Add(NewList);

            Data.BoardProp boardProp = new Data.BoardProp();
            boardProp = listBoards[Locate].boardProp;

            Data.ListProp listProp = new Data.ListProp();
            listProp.Board_ID = boardProp.Board_ID;
            listProp.List_Name = NewList.TextboxListName.Text;
            listProp.List_Observing = false;
            listProp.List_Position = listBoards[Locate].list.Count - 1;
            Data.DataService.InsertList(listProp);
            listBoards[Locate].listProps = Data.DataService.GetListByBoardID(boardProp.Board_ID);
            NewList.listProp = listBoards[Locate].listProps[listBoards[Locate].listProps.Count - 1];
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
                listBoards[Locate].list[i].Location = new Point(listBoards[Locate].list[i].Location.X - 300, 0);
            }
            ButtonAddList.Location = new Point(ButtonAddList.Location.X - 300, 10);
            ResetListPropsIneEachBoard();
        }
        #endregion
        #region Allow to drag and drop Board in BoardList
        private void flowLayoutPanelBoardList_DragDrop(object sender, DragEventArgs e)
        {
            Boards element = e.Data.GetData("Object") as Boards;
            if (element == null) return;
            Point p = flowLayoutPanelBoardList.PointToClient(new Point(e.X, e.Y));
            Boards item = flowLayoutPanelBoardList.GetChildAtPoint(p) as Boards;
            if (item == null)
                item = listBoards[listBoards.Count - 1];
            int indexi = flowLayoutPanelBoardList.Controls.GetChildIndex(item, false);
            int indexe = flowLayoutPanelBoardList.Controls.GetChildIndex(element, false);
            flowLayoutPanelBoardList.Controls.SetChildIndex(element, indexi);
            flowLayoutPanelBoardList.Controls.SetChildIndex(item, indexe);
            indexi = listBoards.IndexOf(item);
            indexe = listBoards.IndexOf(element);
            Boards temp = listBoards[indexi];
            listBoards[indexi] = listBoards[indexe];
            listBoards[indexe] = temp;

            ResetBoardPosition();
        }

        private void ResetBoardPosition()
        {
            foreach (Boards board in listBoards)
            {
                if(board != null)
                board.SetBoardPosition(flowLayoutPanelBoardList.Controls.GetChildIndex(board));
            }
        }

        private void flowLayoutPanelBoardList_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetData("Object") as Boards) == null)
                e.Effect = DragDropEffects.None;
            else
                e.Effect = e.AllowedEffect;
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
            Panel target = (Panel)sender;
            Point p = target.PointToClient(new Point(e.X, e.Y));
            Lists item = target.GetChildAtPoint(p) as Lists;
            if (item == element) return;
            if (element == null) return;
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
            //Change Position
            Point tempP = listBoards[listlocate].list[i1].Location;
            listBoards[listlocate].list[i1].Location = listBoards[listlocate].list[i2].Location;
            listBoards[listlocate].list[i2].Location = tempP;
            Lists temp = listBoards[listlocate].list[i1];
            listBoards[listlocate].list[i1] = listBoards[listlocate].list[i2];
            listBoards[listlocate].list[i2] = temp;

            ResetListPosition(listBoards[listlocate]);
        }

        private void ResetListPosition(Boards board)
        {
            foreach (Lists list in board.list)
            {
                int index = ListListPanel.Controls.Count - 1 - ListListPanel.Controls.GetChildIndex(list);
                list.SetListPosition(index);
            }
        }

        private void ListListPanel_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetData("Object") as Lists) == null)
                e.Effect = DragDropEffects.None;
            else
                e.Effect = e.AllowedEffect;
        }

        #endregion
    }
}
