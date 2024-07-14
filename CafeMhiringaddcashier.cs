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

namespace Cmpusbites_2
{
    public partial class CafeMhiringaddcashier : Form
    {
        public CafeMhiringaddcashier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Fullname = this.textBox1.Text;
            string username = this.textBox2.Text;
            string password = this.textBox3.Text;
            string phoneNo = this.textBox4.Text;
            string address = this.textBox5.Text;
            int ustype = 3;
            // string LP = "NULL";


            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "update userContact set username = '" + username + "', Contact = '" + phoneNo + "', address = '" + address + "' where username = (select u2.username from userContact u1 inner join users u2 on u1.username= u2.username where u2.id = 11); update users set username = '" + username + "', password = '" + password + "', name = '" + Fullname + "', contact = '" + phoneNo + "', address = '" + address + "' where id = 11 ;";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();

            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The cashier has been successfully added");
                CafeM_hiring f = new CafeM_hiring();
                f.Visible = true;
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Cashier not added");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CafeM_hiring f = new CafeM_hiring();
            f.Visible = true;
            this.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
    }
}
