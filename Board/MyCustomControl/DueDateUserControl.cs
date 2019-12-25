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
    public partial class DueDateUserControl : UserControl
    {
        Timer timer = new Timer();
        int notifyCount = 0;

        Board.Data.DueDateProp dueDateProp;


        public delegate void ShowNotificationEventHandler(object sender, EventArgs args);
        public event ShowNotificationEventHandler ShowNotification;

        protected virtual void OnShowNotification()
        {
            if(ShowNotification != null)
            {
                ShowNotification(this, EventArgs.Empty);
            }
        }

        public delegate void DueDateDeletedEventHandler(object sender, EventArgs args);
        public event DueDateDeletedEventHandler DueDateDeleted;

        protected virtual void OnDueDateDeleted()
        {
            if (DueDateDeleted != null)
            {
                DueDateDeleted(this, EventArgs.Empty);
            }
        }




        public DueDateUserControl()
        {
            InitializeComponent();
            saveCancelPanel.Visible = false;
            SetTimer();
        }

        private void SetTimer()
        {
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan time = dueDateProp.DueDate_DateTime.Subtract(DateTime.Now);
            CheckState();
            if ((int)time.TotalSeconds == dueDateProp.DueDate_Reminder && notifyCount == 0)
            {
                ++notifyCount;
                OnShowNotification();
            }
        }


        private void SetDueDateTime()
        {
            try
            {
                dueDateProp.DueDate_DateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day,
                        Int32.Parse(hourTextBox.Text), Int32.Parse(minuteTextBox.Text), Int32.Parse(secondTextBox.Text));
            }
            catch
            {
                DialogResult dialogResult = MessageBox.Show("Time is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(dialogResult == DialogResult.OK)
                {
                    cancelButton.PerformClick();
                }
            }
        }

        private void CheckState()
        {
            TimeSpan time = dueDateProp.DueDate_DateTime.Subtract(DateTime.Now);
            if(time.TotalSeconds < 0)
            {
                dueDateStateBar.SetState(2);//Overdue
            }
            else if (time.TotalSeconds <= 86400)
            {
                dueDateStateBar.SetState(1);//Duesoon
            }
            else
            {
                dueDateStateBar.SetState(0);//Ongoing
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                dueDateStateBar.SetState(3);
                timer.Stop();
            }
            else
            {
                timer.Start();
                CheckState();
            }
            dueDateProp.DueDate_Checked = ((CheckBox)sender).Checked;
            Board.Data.DataService.UpdateDueDate(dueDateProp);
        }

        private void dateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            saveCancelPanel.Visible = true;
        }

        private void hourTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            saveCancelPanel.Visible = true;
        }

        private void minuteTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            saveCancelPanel.Visible = true;
        }

        private void secondTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            saveCancelPanel.Visible = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SetDueDateTime();
            SetReminderTime();
            Board.Data.DataService.UpdateDueDate(dueDateProp);
            saveCancelPanel.Visible = false;
        }

        private void SetReminderTime()
        {
            if (setReminderComboBox.SelectedIndex == 0) //at time
            {
                dueDateProp.DueDate_Reminder = 0;
            }
            else if (setReminderComboBox.SelectedIndex == 1)//5 minutes
            {
                dueDateProp.DueDate_Reminder = 5 * 60;
            }
            else if (setReminderComboBox.SelectedIndex == 2)//15 minutes
            {
                dueDateProp.DueDate_Reminder = 15 * 60;
            }
            else if (setReminderComboBox.SelectedIndex == 3)//30minutes
            {
                dueDateProp.DueDate_Reminder = 30 * 60;
            }
            else if (setReminderComboBox.SelectedIndex == 4)//1 hour
            {
                dueDateProp.DueDate_Reminder = 1 * 3600;
            }
            else if (setReminderComboBox.SelectedIndex == 5)//2 hours
            {
                dueDateProp.DueDate_Reminder = 2 * 3600;
            }
            else if (setReminderComboBox.SelectedIndex == 6)//1 day
            {
                dueDateProp.DueDate_Reminder = 24 * 3600;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            LoadDateTime(dueDateProp.DueDate_DateTime);
            LoadReminderTime(dueDateProp.DueDate_Reminder);
            saveCancelPanel.Visible = false;
        }

        private void DueDateUserControl_Leave(object sender, EventArgs e)
        {
            cancelButton.PerformClick();
        }

        private void setReminderComboBox_MouseDown(object sender, MouseEventArgs e)
        {
            saveCancelPanel.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to delete this Due Date?\n" +
                            "Once deleted, this Due Date cannot be retrieved", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Board.Data.DataService.DeleteDueDate(dueDateProp);
                Dispose();
            }
        }

        public void LoadData(Board.Data.DueDateProp _dueDateProp)
        {
            dueDateProp = new Board.Data.DueDateProp();
            dueDateProp = _dueDateProp;
            LoadDateTime(dueDateProp.DueDate_DateTime);
            LoadReminderTime(dueDateProp.DueDate_Reminder);
            LoadChecked(dueDateProp.DueDate_Checked);
            SetDueDateTime();
        }

        private void LoadDateTime(DateTime dateTime)
        {
            dateTimePicker.Value = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
            hourTextBox.Text = dateTime.Hour.ToString("D2");
            minuteTextBox.Text = dateTime.Minute.ToString("D2");
            secondTextBox.Text = dateTime.Second.ToString("D2");
        }

        private void LoadReminderTime(int reminderTime)
        {
            if(reminderTime == 0)
            {
                setReminderComboBox.SelectedIndex = 0;
            }
            else if(reminderTime == 5 * 60)
            {
                setReminderComboBox.SelectedIndex = 1;
            }
            else if (reminderTime == 15 * 60)
            {
                setReminderComboBox.SelectedIndex = 2;
            }
            else if (reminderTime == 30 * 60)
            {
                setReminderComboBox.SelectedIndex = 3;
            }
            else if (reminderTime == 1 * 3600)
            {
                setReminderComboBox.SelectedIndex = 4;
            }
            else if (reminderTime == 2 * 3600)
            {
                setReminderComboBox.SelectedIndex = 5;
            }
            else if (reminderTime == 24 * 3600)
            {
                setReminderComboBox.SelectedIndex = 6;
            }
        }

        private void LoadChecked(bool state)
        {
            checkBox.Checked = state;
        }
    }
}
