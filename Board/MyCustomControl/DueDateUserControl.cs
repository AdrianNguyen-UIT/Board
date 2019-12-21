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
        DateTime dueDateTime;
        Timer timer = new Timer();
        int reminderTime;
        int notifyCount = 0;


        public delegate void ShowNotificationEventHandler(object sender, EventArgs args);
        public event ShowNotificationEventHandler ShowNotification;

        protected virtual void OnShowNotification()
        {
            if(ShowNotification != null)
            {
                ShowNotification(this, EventArgs.Empty);
            }
        }


        public DueDateUserControl()
        {
            InitializeComponent();
            SetDueDateTime();
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
            TimeSpan time = dueDateTime.Subtract(DateTime.Now);
            CheckState();
            if ((int)time.TotalSeconds == reminderTime && notifyCount == 0)
            {
                ++notifyCount;
                OnShowNotification();
            }
        }

        private void setReminderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(((ComboBox)sender).SelectedIndex == 0) //at time
            {
                reminderTime = 0;
            }
            else if (((ComboBox)sender).SelectedIndex == 1)//5 minutes
            {
                reminderTime = 5 * 60;
            }
            else if (((ComboBox)sender).SelectedIndex == 2)//15 minutes
            {
                reminderTime = 15 * 60;
            }
            else if (((ComboBox)sender).SelectedIndex == 3)//30minutes
            {
                reminderTime = 30 * 60;
            }
            else if (((ComboBox)sender).SelectedIndex == 4)//1 hour
            {
                reminderTime = 1 * 3600;
            }
            else if (((ComboBox)sender).SelectedIndex == 5)//2 hours
            {
                reminderTime = 2 * 3600;
            }
            else if (((ComboBox)sender).SelectedIndex == 6)//1 day
            {
                reminderTime = 24 * 3600;
            }
        }

        private void SetDueDateTime()
        {
            dueDateTime = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, dateTimePicker.Value.Day,
                Int32.Parse(hourTextBox.Text), Int32.Parse(minuteTextBox.Text), Int32.Parse(secondTextBox.Text));
        }

        private void CheckState()
        {
            TimeSpan time = dueDateTime.Subtract(DateTime.Now);
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
            //insert/save into databas
            //
            //
            SetDueDateTime();
            saveCancelPanel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //revert to old data
            //
            //
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
                            "Once deleted, this Due Date cannot be retrieved", "Announce", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                //Delete checklist from database

                Dispose();
            }
        }
    }
}
