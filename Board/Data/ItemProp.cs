using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Board.Data
{
    public class ItemProp
    {
        public int Item_ID { get; set; }

        public int CheckList_ID { get; set; }

        public String Item_Description { get; set; }

        public bool Item_Checked { get; set; }

        public int Item_Position { get; set; }
    }
}
