using dotNet.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet
{
    public partial class fStaff : Form
    {
        public fStaff()
        {
            InitializeComponent();
            LoadTable();
        }
        private void LoadTable()
        {
            List<Table> tableList = TableController.Ins.LoadTableList();

            foreach (var item in tableList)
            {
                Button btn = new Button()
                {
                    Width = TableController.TableWidth,
                    Height = TableController.TableHeight
                };

                flpTable.Controls.Add(btn);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
