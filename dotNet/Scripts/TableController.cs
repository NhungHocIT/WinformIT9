using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet.Scripts
{
    class TableController
    {
        private static TableController ins;
        public static TableController Ins
        {
            get
            {
                if (ins == null)
                    ins = new TableController();
                return ins;
            }

            private set => ins = value;
        }
        private TableController() { }

        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();

            DataTable data = DataProvider.Ins.ExecuteQuery("Select * from TableCoffee");

            foreach (DataRow row in data.Rows)
            {
                Table table = new Table(row);
                list.Add(table);
            }
            return list;
        }

        public static int TableWidth = 150;
        public static int TableHeight = 150;
    }
}
