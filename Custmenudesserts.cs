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
    public partial class Custmenudesserts : Form
    {
        public Custmenudesserts()
        {
            InitializeComponent();
            populateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Custmenu f = new Custmenu();
            f.Visible = true;
            this.Visible = false;
        }

        public void populateData()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select id,name,descrpt,nut_info,price from MenuItems group by category,id,name,descrpt,nut_info,price having category='Desserts'";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("Description", "Description");
                dataGridView1.Columns.Add("Nutritional Info", "Nutritional Info");
                dataGridView1.Columns.Add("Price", "Price");

                while (rdr.Read())
                {
                    string id = rdr["id"].ToString();
                    string Mname = rdr["name"].ToString();
                    string des = rdr["descrpt"].ToString();
                    string nut = rdr["nut_info"].ToString();
                    string price = rdr["price"].ToString();

                    dataGridView1.Rows.Add(id, Mname, des, nut, price);
                }
            }

            else
            {
                MessageBox.Show("No data found");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = this.textBox4.Text;
            decimal quantity = this.numericUpDown1.Value;
            //finding loyaltyP first

            int lp = 1;
            string connString2 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection2 = new SqlConnection(connString2);
            sqlConnection2.Open();

            string query2 = "select top 1 loyaltyP from CurrentUser;";

            SqlCommand command2 = new SqlCommand(query2, sqlConnection2);

            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                int lp2 = Convert.ToInt32(result2);
                lp = lp2;
            }
            //---------------------------------------
            if (lp >= 3)
            {
                string connString3 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection3 = new SqlConnection(connString3);
                sqlConnection3.Open();

                string query3 = "insert into Cust_Order(id,quantity,price,itemId,CurruserId) values(0,'" + quantity + "',0,'" + id + "',0);update Cust_Order set id=(select top 1 id from CurrentUser), CurruserId=(select top 1 id from CurrentUser),price=(select price from MenuItems where id='" + id + "') where itemId = '" + id + "'; Update Cust_Order set price = (price*0.75) where itemId = '" + id + "';";

                SqlCommand command3 = new SqlCommand(query3, sqlConnection3);
                int res3 = command3.ExecuteNonQuery();
                MessageBox.Show("Item added to the Cart! Price Discounted due to your Loyalty Points");
                Custmenufastfood f = new Custmenufastfood();
                f.Visible = true;
                this.Visible = false;
            }
            else
            {
                string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                string query = "insert into Cust_Order(id,quantity,price,itemId,CurruserId) values(0,'" + quantity + "',0,'" + id + "',0);update Cust_Order set id=(select top 1 id from CurrentUser), CurruserId=(select top 1 id from CurrentUser),price=(select price from MenuItems where id='" + id + "') where itemId = '" + id + "';";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                int res = command.ExecuteNonQuery();
                MessageBox.Show("Item added to the Cart");
                Custmenufastfood f = new Custmenufastfood();
                f.Visible = true;
                this.Visible = false;
            }
            
        }
    }
}
