using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Data
{
    public class DueDateProp
    {
        public int DueDate_ID { get; set; }

        public int Card_ID { get; set; }

        public DateTime DueDate_DateTime { get; set; }

        public int DueDate_Reminder { get; set; }

        public bool DueDate_Checked { get; set; }
    }
}
