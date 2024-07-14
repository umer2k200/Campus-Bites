using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Cmpusbites_2
{
    public partial class CafeMviewinsights : Form
    {
        public CafeMviewinsights()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select avg(loyaltyP) as Average from Users where user_type=4";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Average", "Average");
                while (rdr.Read())
                {
                    string avrg = rdr["Average"].ToString();

                    dataGridView1.Rows.Add(avrg);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select sum(Tamount) as Sum from Orders group by pay_type having pay_type='Credit Card'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Sum", "Sum");
                while (rdr.Read())
                {
                    string sm = rdr["Sum"].ToString();

                    dataGridView1.Rows.Add(sm);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select sum(Tamount) as Sum from Orders group by pay_type having pay_type='Cash On Delivery'";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Sum", "Sum");
                while (rdr.Read())
                {
                    string sm = rdr["Sum"].ToString();

                    dataGridView1.Rows.Add(sm);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select m.name as Name, i.supplier as Supplier from MenuItems m join Inventory i on m.id=i.itemId ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Supplier", "Supplier");

                while (rdr.Read())
                {
                    string nm = rdr["Name"].ToString();
                    string sp = rdr["Supplier"].ToString();

                    dataGridView1.Rows.Add(nm, sp);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select u.id as Id, uc.username as Username, uc.Contact as Contact, uc.address as Address from Users u join UserContact uc on u.username=uc.username; ";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Username", "Username");
                dataGridView1.Columns.Add("Contact", "Contact");
                dataGridView1.Columns.Add("Address", "Address");

                while (rdr.Read())
                {
                    string id = rdr["Id"].ToString();
                    string usnm = rdr["Username"].ToString();
                    string cntc = rdr["Contact"].ToString();
                    string addr = rdr["Address"].ToString();

                    dataGridView1.Rows.Add(id, usnm, cntc, addr);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select co.CurruserId as CustomerID,u.name as CustomerName,m.name as ItemName,m.category as Category,co.quantity as Quantity,co.price as Price from Cust_Order co join MenuItems m on co.itemId=m.id join Users u on u.id=co.CurruserId;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("CustomerId", "CustomerId");
                dataGridView1.Columns.Add("CustomerName", "CustomerName");
                dataGridView1.Columns.Add("ItemName", "ItemName");
                dataGridView1.Columns.Add("Category", "Category");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Price", "Price");

                while (rdr.Read())
                {
                    string cid = rdr["CustomerId"].ToString();
                    string cnm = rdr["CustomerName"].ToString();
                    string itn = rdr["ItemName"].ToString();
                    string cat = rdr["Category"].ToString();
                    string quan = rdr["Quantity"].ToString();
                    string pr = rdr["Price"].ToString();


                    dataGridView1.Rows.Add(cid, cnm, itn, cat, quan, pr);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select co.CurruserId as CustomerID,u.name as CustomerName,m.name as ItemName,m.category as Category,co.quantity as Quantity,co.price as Price from Cust_Order co join MenuItems m on co.itemId=m.id join Users u on u.id=co.CurruserId;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("CustomerId", "CustomerId");
                dataGridView1.Columns.Add("CustomerName", "CustomerName");
                dataGridView1.Columns.Add("ItemName", "ItemName");
                dataGridView1.Columns.Add("Category", "Category");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Price", "Price");

                while (rdr.Read())
                {
                    string cid = rdr["CustomerId"].ToString();
                    string cnm = rdr["CustomerName"].ToString();
                    string itn = rdr["ItemName"].ToString();
                    string cat = rdr["Category"].ToString();
                    string quan = rdr["Quantity"].ToString();
                    string pr = rdr["Price"].ToString();


                    dataGridView1.Rows.Add(cid, cnm, itn, cat, quan, pr);
                }
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select o.cust_id as CustomerId, u.name as CustomerName,m.name as ItemName,co.quantity as Quantity,o.dTime as DateTime,o.pay_type as PaymentType ,o.stat as Status,o.cashierId as CashierId from Orders o join Cust_Order co on o.cust_id=co.CurruserId join  MenuItems m on m.id=co.itemId join Users u on o.cust_id=u.id\r\n";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();



            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("CustomerId", "CustomerId");
                dataGridView1.Columns.Add("CustomerName", "CustomerName");
                dataGridView1.Columns.Add("ItemName", "ItemName");
                dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("DateTime", "DateTime");
                dataGridView1.Columns.Add("PaymentType", "PaymentType");
                dataGridView1.Columns.Add("Status", "Status");
                dataGridView1.Columns.Add("CashierId", "CashierId");

                while (rdr.Read())
                {
                    string cid = rdr["CustomerId"].ToString();
                    string cnm = rdr["CustomerName"].ToString();
                    string itn = rdr["ItemName"].ToString();
                    string quan = rdr["Quantity"].ToString();
                    string dt = rdr["DateTime"].ToString();
                    string pt = rdr["PaymentType"].ToString();
                    string st = rdr["Status"].ToString();
                    string pr = rdr["CashierId"].ToString();


                    dataGridView1.Rows.Add(cid, cnm, itn, quan, dt, pt, st, pr);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select u.name as CashierName,u.id as Id,m.name as ItemName,co.quantity as Quantity from Users u join Orders o on u.id=o.cashierId join Cust_Order co on o.cust_id=co.id join MenuItems m on co.itemId=m.id where u.user_type=3;\r\n";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("CashierName", "CashierName");
                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("ItemName", "ItemName");
                dataGridView1.Columns.Add("Quantity", "Quantity");


                while (rdr.Read())
                {
                    string cid = rdr["CashierName"].ToString();
                    string cnm = rdr["Id"].ToString();
                    string itn = rdr["ItemName"].ToString();
                    string quan = rdr["Quantity"].ToString();



                    dataGridView1.Rows.Add(cid, cnm, itn, quan);
                }
            }
        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            CafeMviewsales f = new CafeMviewsales();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
