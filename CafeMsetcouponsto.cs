using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpusbites_2
{
    public partial class CafeMsetcouponsto : Form
    {
        public CafeMsetcouponsto()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code = this.textBox8.Text;
            string dsc = this.textBox7.Text;
            string discount = this.textBox6.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            //string query1="select * from MenuItems where name in(select )"


            string query = "insert into Coupon (code,descrpt,disc_amt) values ('" + code + "','" + dsc + "','" + discount + "');";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The coupon has been successfully added");

                CafeMsetcoupons obj = new CafeMsetcoupons();

                obj.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Coupon not added");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = this.textBox5.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            //string query1="select * from MenuItems where name in(select )"


            string query = "delete from Coupon where code='" + code + "';";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The coupon has been successfully deleted");

                CafeMsetcoupons obj = new CafeMsetcoupons();

                obj.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Coupon not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CafeMsetcoupons obj = new CafeMsetcoupons();
            obj.Visible = true;
            this.Visible = false;
        }
    }
}
