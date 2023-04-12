using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //string userName = txtID.Text;
            //string pass = txtPas.Text;
            //string query 
            //    = "select * from dbo.Account where UserName = '"+userName+"' and Password = '"+pass+"'";

            //DataTable result = DataProvider.Ins.ExecuteQuery(query);

            //if (result.Rows.Count > 0) { 
                this.Hide();
                fStaff fStaff= new fStaff();
                fStaff.ShowDialog();
                this.Show();
            //}
            //else
            //{
            //    MessageBox.Show($"TryAgain! {result}");
            //}
        }
    }
}


/*
 string id = txtID.Text;
            string pass = txtPas.Text;

            string query = "SELECT * FROM dbo.TaiKhoan WHERE taiKhoan = '" + id + "' AND matKhau = '" + pass + "'";
            SqlConnection sqlConnection = new SqlConnection(strCon);
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader DReader = cmd.ExecuteReader();
            if(DReader.Read())
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("Again");
            }

            sqlConnection.Close();
            
            ' or 1=1 --
 */
