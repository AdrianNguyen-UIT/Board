using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCustomControl;
namespace Board
{
    public partial class CardForm : Form
    {
        Data.CardProp cardProp;
        List<Data.DueDateProp> dueDateProps;
        List<Data.CheckListProp> checkListProps;
        List<Data.ListProp> listProps;
        List<Data.BoardProp> boardProps;

        public CardForm(Data.CardProp _cardProp)
        {
            InitializeComponent();
            cardProp = new Data.CardProp();
            cardProp = _cardProp;
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            LoadCardName();
            LoadDescription();
            LoadDueDate();
            LoadCheckList();
            LoadObservation();
            LoadListName();
            LoadBoardName();
            notifyIcon.Icon = SystemIcons.Application;

            distractedButton.Select();
        }

        private void LoadListName()
        {
            listProps = Data.DataService.GetListByListID(cardProp.List_ID);
            listLabel.Text = listProps[0].List_Name;
        }

        private void LoadBoardName()
        {
            boardProps = Data.DataService.GetBoardByBoardID(listProps[0].Board_ID);
            boardLabel.Text = boardProps[0].Board_Name;
        }

        private void LoadObservation()
        {
            CheckObservingState();
        }

        private void LoadCheckList()
        {
            checkListProps = Data.DataService.GetCheckListByCardID(cardProp.Card_ID);
            if (checkListProps.Count != 0)
            {
                foreach (Data.CheckListProp checkListProp in checkListProps)
                {
                    SpawnCheckListUserControl(checkListProp, false);
                }
            }
        }

        private void LoadDueDate()
        {
            dueDateProps = Data.DataService.GetDueDateByCardID(cardProp.Card_ID);
            if (dueDateProps.Count != 0)
            {
                SpawnDueDateUserControl(dueDateProps[0]);
            }
        }

        private void LoadDescription()
        {
            descriptionUserControl.LoadData(cardProp);
        }

        private  void OnShowNotification(object sender, EventArgs e)
        {
            if(cardProp.Card_Observing == true)
            {
                Console.WriteLine("\a");
                notifyIcon.ShowBalloonTip(10000, "Notification", "You got 1 notification", ToolTipIcon.Info);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadCardName()
        {
            cardNameRichTextBox.SetRichTextBoxSize(750, 30);
            cardNameRichTextBox.SetRichTextBoxMinSize(750, 30);
            cardNameRichTextBox.SetRichTextBoxMaxSize(750, 200);
            cardNameRichTextBox.SetFont(new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            cardNameRichTextBox.NonFoucesedRichTextBoxColor = Color.LightGray;
            cardNameRichTextBox.FoucesedRichTextBoxColor = Color.White;
            cardNameRichTextBox.SetSaveAndCancelFlatAppearanceColor(topPanel.BackColor);
            cardNameRichTextBox.SaveMouseDown += CardNameRichTextBox_SaveMouseDown;
            cardNameRichTextBox.ContentText = cardProp.Card_Name;
        }

        private void CardNameRichTextBox_SaveMouseDown(object sender, EventArgs e)
        {
            cardProp.Card_Name = cardNameRichTextBox.ContentText;
            Data.DataService.UpdateCard(cardProp);

        }

        private void descriptionPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, descriptionPanel.Width + 1, descriptionPanel.Height + 1), 6);

        }

        #region allow to drag and drop CheckListUserControl in checkListPanel
        private void checkListPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void checkListPanel_DragDrop(object sender, DragEventArgs e)
        {
            CheckListUserControl data = (CheckListUserControl)e.Data.GetData(typeof(CheckListUserControl));
            if(data == null)
            {
                return;
            }
            FlowLayoutPanel target = (FlowLayoutPanel)sender;
            FlowLayoutPanel source = (FlowLayoutPanel)data.Parent;

            if (source != target)
            {
                // Add control to panel
                target.Controls.Add(data);

                // Reorder
                Point p = target.PointToClient(new Point(e.X, e.Y));
                var item = target.GetChildAtPoint(p);
                int index = target.Controls.GetChildIndex(item, false);
                target.Controls.SetChildIndex(data, index);

                // Invalidate to paint!
                target.Invalidate();
                source.Invalidate();
            }
            else
            {
                // Just add the control to the new panel.
                // No need to remove from the other panel, this changes the Control.Parent property.
                Point p = target.PointToClient(new Point(e.X, e.Y));
                var item = target.GetChildAtPoint(p);
                int index = target.Controls.GetChildIndex(item, false);
                target.Controls.SetChildIndex(data, index);
                target.Invalidate();

                ResetCheckListPos();
            }
        }

        private void ResetCheckListPos()
        {
            foreach(CheckListUserControl checkList in checkListPanel.Controls)
            {
                checkList.SetCheckListPosition(checkListPanel.Controls.GetChildIndex(checkList));
            }
        }
        #endregion


        #region Paint rounded corner for Des, CheckList, DueDate, Action, Add panel
        private void descriptionPanel_SizeChanged(object sender, EventArgs e)
        {
            descriptionPanel.Invalidate();
        }

        private void checkListPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, checkListPanel.Width + 1, checkListPanel.Height + 1), 6);
        }

        private void checkListPanel_SizeChanged(object sender, EventArgs e)
        {
            checkListPanel.Invalidate();
        }

        private void dueDatePanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, dueDatePanel.Width + 1, dueDatePanel.Height + 1), 6);
        }

        private void dueDatePanel_SizeChanged(object sender, EventArgs e)
        {
            dueDatePanel.Invalidate();
        }

        private void addFeaturePanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, addFeaturePanel.Width + 1, addFeaturePanel.Height + 1), 6);
        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Gray),
                new Rectangle(-1, -1, actionPanel.Width + 1, actionPanel.Height + 1), 6);
        }

        private void actionPanel_SizeChanged(object sender, EventArgs e)
        {
            actionPanel.Invalidate();
        }

        private void featurePanel_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RoundedDrawing.FillRoundedRectangle(g, new SolidBrush(Color.Silver),
                new Rectangle(-1, -1, featurePanel.Width + 1, featurePanel.Height + 1), 6);
        }
        #endregion

        private void addChecklistButton_Click(object sender, EventArgs e)
        {
            SpawnCheckListUserControl();
        }

        private void SpawnCheckListUserControl(Data.CheckListProp clProp, bool focus)
        {
            CheckListUserControl checkListUserControl = new CheckListUserControl();
            checkListUserControl.AutoSize = true;
            checkListUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            checkListUserControl.BackColor = System.Drawing.Color.Teal;
            checkListUserControl.Location = new System.Drawing.Point(5, 5);
            checkListUserControl.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            checkListUserControl.Name = "checkListUserControl";
            checkListUserControl.Size = new System.Drawing.Size(693, 130);
            checkListUserControl.CheckListDeleted += CheckListUserControl_CheckListDeleted;
            checkListUserControl.Reset += CheckListUserControl_Reset;
            checkListUserControl.LoadData(clProp);
            checkListPanel.Controls.Add(checkListUserControl);
            checkListPanel.Controls.SetChildIndex(checkListUserControl, clProp.CheckList_Position);

            if (focus == true)
            {
                checkListUserControl.OnSpawned();
            }
        }

        private void CheckListUserControl_Reset(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            CardForm_Load(null, null);
            this.Show();
        }

        private void CheckListUserControl_CheckListDeleted(object sender, EventArgs e)
        {
            checkListProps = Data.DataService.GetCheckListByCardID(cardProp.Card_ID);
            ResetCheckListPos();
        }

        private void SpawnCheckListUserControl()
        {
            Data.CheckListProp checkListProp = new Data.CheckListProp();
            checkListProp.Card_ID = cardProp.Card_ID;
            checkListProp.CheckList_Name = $"Checklist ({checkListProps.Count})";
            checkListProp.CheckList_Position = checkListProps.Count;
            Data.DataService.InsertCheckList(checkListProp);

            checkListProps = Data.DataService.GetCheckListByCardID(cardProp.Card_ID);
            SpawnCheckListUserControl(checkListProps[checkListProps.Count - 1], true);
        }

        private void addDueDateButton_Click(object sender, EventArgs e)
        {
            if (dueDateProps.Count == 0)
            {
                SpawnDueDateUserControl();
            }
        }

        private void SpawnDueDateUserControl(Data.DueDateProp ddProp)
        {
            DueDateUserControl dueDateUserControl = new DueDateUserControl();
            dueDateUserControl.AutoSize = true;
            dueDateUserControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            dueDateUserControl.BackColor = System.Drawing.Color.MediumPurple;
            dueDateUserControl.Location = new System.Drawing.Point(5, 5);
            dueDateUserControl.Margin = new System.Windows.Forms.Padding(5);
            dueDateUserControl.Name = "dueDateUserControl";
            dueDateUserControl.Size = new System.Drawing.Size(690, 126);
            dueDateUserControl.TabIndex = 2;
            dueDateUserControl.DueDateDeleted += DueDateUserControl_DueDateDeleted;
            dueDateUserControl.ShowNotification += OnShowNotification;
            dueDateUserControl.LoadData(ddProp);
            dueDatePanel.Controls.Add(dueDateUserControl);
        }

        private void DueDateUserControl_DueDateDeleted(object sender, EventArgs args)
        {
            dueDateProps = Data.DataService.GetDueDateByCardID(cardProp.Card_ID);
        }

        private void SpawnDueDateUserControl()
        {
            Data.DueDateProp dueDateProp = new Data.DueDateProp();
            dueDateProp.Card_ID = cardProp.Card_ID;
            dueDateProp.DueDate_Checked = false;
            dueDateProp.DueDate_DateTime = DateTime.Now;
            dueDateProp.DueDate_Reminder = 0;
            Data.DataService.InsertDueDate(dueDateProp);
            LoadDueDate();
        }

        private void observeButton_Click(object sender, EventArgs e)
        {
            cardProp.Card_Observing = !cardProp.Card_Observing;
            CheckObservingState();
            Data.DataService.UpdateCard(cardProp);
        }

        private void CheckObservingState()
        {
            if (cardProp.Card_Observing == true)
            {
                observeButton.ButtonColor = Color.FromArgb(255, 255, 128);
                observeButton.OnHoverButtonColor = Color.Yellow;
                observationPIctureBox.Visible = true;

            }
            else
            {
                observeButton.ButtonColor = Color.FromArgb(224, 224, 224);
                observeButton.OnHoverButtonColor = Color.DimGray;
                observationPIctureBox.Visible = false;
            }
        }


    }
}
