using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet.Scripts
{
    class Table
    {
        private int iD;
        private string status;
        private string name;

        public string Status { get => status; private set => status = value; }
        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }

        public Table(int iD, string name, string status) { 
            this.iD = iD;
            this.name = name;
            this.status = status;
        }

        public Table(DataRow row)
        {
            this.iD = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.status = row["Status"].ToString();
        }
    }
}
