using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Cmpusbites_2
{
    public partial class CafeMadditem : Form
    {
        public CafeMadditem()
        {
            InitializeComponent();
        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeM_hiring f = new CafeM_hiring();
            f.Visible = true;
            this.Visible = false;
        }

        private void rEMOVEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMremoveitem f = new CafeMremoveitem();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMviewsales f = new CafeMviewsales();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMviewinventory f = new CafeMviewinventory();
            f.Visible = true;
            this.Visible = false;
        }

        private void sETCOUPONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMsetcoupons f = new CafeMsetcoupons();
            f.Visible = true;
            this.Visible = false;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "delete from CurrentUser";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            int res = command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("You have successfully logged out!");
            Form1 f = new Form1();
            f.Visible = true;
            this.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add item
            string itemname = textBox1.Text;
            string desc = textBox2.Text;
            string nut_info = textBox3.Text;
            string price = textBox4.Text;
            string category = textBox5.Text;


            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            //string query1="select * from MenuItems where name in(select )"


            string query = "insert into MenuItems (name,descrpt,nut_info,price,category,mgr_id) values('" + itemname + "','" + desc + "','" + nut_info + "','" + price + "','" + category + "',8);";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The item has been successfully added");

                CafeMadditem obj = new CafeMadditem();

                obj.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Item not added");
            }


        }
    }
}
