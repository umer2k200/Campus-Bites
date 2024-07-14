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
using System.Xml.Linq;

namespace Cmpusbites_2
{
    public partial class Custmycart : Form
    {
        public Custmycart()
        {
            InitializeComponent();
            populateData();
            populateData2();
        }

        private void Custmycart_Load(object sender, EventArgs e)
        {

        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmyaccount f = new Custmyaccount();
            f.Visible = true;
            this.Visible = false;
        }

        private void mENUMANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmenu f = new Custmenu();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custtrackorder f = new Custtrackorder();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custfeedback f = new Custfeedback();
            f.Visible = true;
            this.Visible = false;
        }

        private void sETCOUPONSToolStripMenuItem_Click(object sender, EventArgs e)
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

        public void populateData()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            //string query = "select co.itemId,M.name,M.category,co.quantity,co.price from Cust_Order co join MenuItems M  on co.itemId=M.id;";
            string query = "select co.itemId,M.name,M.category,co.quantity,co.price from Cust_Order co join MenuItems M  on co.itemId=M.id join CurrentUser c on co.CurruserId = c.id;";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("co.itemId", "ItemId");
                dataGridView1.Columns.Add("M.name", "Name");
                dataGridView1.Columns.Add("M.category", "Category");
                dataGridView1.Columns.Add("co.quantity", "Quantity");
                dataGridView1.Columns.Add("co.price", "Price");

                while (rdr.Read())
                {
                    string id = rdr["ItemId"].ToString();
                    string Mname = rdr["Name"].ToString();
                    string cat = rdr["Category"].ToString();
                    string quan = rdr["Quantity"].ToString();
                    string price = rdr["Price"].ToString();

                    dataGridView1.Rows.Add(id, Mname, cat, quan, price);
                }
            }

            else
            {
                MessageBox.Show("No data found");
            }
        }

        public void populateData2()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select sum(c.price*c.quantity) as Total from Cust_Order c join CurrentUser c1 on c.CurruserId = c1.id where  C.CurruserId = c1.id";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                dataGridView2.Columns.Add("Total", "Total $");


                while (rdr.Read())
                {
                    string tot = rdr["Total"].ToString();


                    dataGridView2.Rows.Add(tot);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox4.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "delete from Cust_Order where itemId='" + id + "';";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();

            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The item has been removed from the cart");

                Custmycart f = new Custmycart();
                f.Visible = true;
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Item not found");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = this.textBox4.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "delete from Cust_Order where itemId='" + id + "';";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();

            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The item has been removed from the cart");

                Custmycart f = new Custmycart();
                f.Visible = true;
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Item not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string Cname = this.textBox1.Text;
            int disc_amt = 1;
            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "SELECT disc_amt FROM Coupon WHERE code='" + Cname + "'";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            object result = command.ExecuteScalar();

            if (result != null)
            {
                int discountAmount = Convert.ToInt32(result);
                MessageBox.Show("Discount of " + discountAmount + "% added to your amount!");
                disc_amt = discountAmount;
            }
            else
            {
                MessageBox.Show("Coupon not found");
            }

            //------------------------------


            string connString2 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection2 = new SqlConnection(connString2);
            sqlConnection2.Open();

            string query2 = "update Cust_Order set price = ((price*" + disc_amt + ")/100);";

            SqlCommand command2 = new SqlCommand(query2, sqlConnection2);

            int res2 = command2.ExecuteNonQuery();

            sqlConnection2.Close();


            //------------------------------
            Custmycart f = new Custmycart();
            f.Visible = true;
            this.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string var = "NULL";
            //if curretnuser ka credcar_accno!='credit/debit card number ' then okay else 
            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";


            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "select credcard_accno from CurrentUser where credcard_accno!='" + var + "';";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            object result = command.ExecuteScalar();

            if (result != null)
            {
                //Order by card
                double tot_amount = 1;
                string connString2 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection2 = new SqlConnection(connString2);
                sqlConnection2.Open();

                string query2 = "select sum(price * quantity) from Cust_Order;";

                SqlCommand command2 = new SqlCommand(query2, sqlConnection2);

                object result2 = command2.ExecuteScalar();

                if (result2 != null)
                {
                    double totalamount = Convert.ToDouble(result2);
                    tot_amount = totalamount;
                }
                //------------------------

                string connString3 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection3 = new SqlConnection(connString3);
                sqlConnection3.Open();

                string query3 = "insert into Orders (stat) values('Pending'); update Orders set cust_id=(select top 1 id from CurrentUser) , custOrderID=(select top 1 id from CurrentUser), dTime=GETDATE(),pay_type='Credit Card',Tamount='" + tot_amount + 
                    "',cashRet=0,cashierId=11 where id=(select top 1 id from Orders order by id desc); ";

                SqlCommand command3 = new SqlCommand(query3, sqlConnection3);

                int res3 = command3.ExecuteNonQuery();

                sqlConnection3.Close();

                if (res3 != 0)
                {
                    MessageBox.Show("Order Placed");
                }
                //-------------------------------------------
                int lp = 1;
                string connString4 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection4 = new SqlConnection(connString4);
                sqlConnection4.Open();

                string query4 = "select top 1 loyaltyP from CurrentUser;";

                SqlCommand command4 = new SqlCommand(query4, sqlConnection4);

                object result4 = command4.ExecuteScalar();

                if (result4 != null)
                {
                    int lp2 = Convert.ToInt32(result4);
                    lp = lp2 + 1;
                }
                //--------------------------------------------------------
                string connString5 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection5 = new SqlConnection(connString5);
                sqlConnection5.Open();

                string query5 = "update users set loyaltyP = '" + lp + "' where id  = (select top 1 id from CurrentUser); update CurrentUser set loyaltyP = '" + lp + "';";

                SqlCommand command5 = new SqlCommand(query5, sqlConnection5);


                int res5 = command5.ExecuteNonQuery();

                sqlConnection5.Close();

                Custtrackorder f = new Custtrackorder();
                f.Visible = true;
                this.Visible = false;

            }

            else
            {
                MessageBox.Show("Credit card info does not exist");
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cash on delivery

          
            double tot_amount = 1;
            string connString2 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection2 = new SqlConnection(connString2);
            sqlConnection2.Open();

            string query2 = "select sum(price * quantity) from Cust_Order;";

            SqlCommand command2 = new SqlCommand(query2, sqlConnection2);

            object result2 = command2.ExecuteScalar();

            if (result2 != null)
            {
                double totalamount = Convert.ToDouble(result2);
                tot_amount = totalamount;
            }
            //------------------------

            string connString3 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection3 = new SqlConnection(connString3);
            sqlConnection3.Open();

            string query3 = "insert into Orders (stat) values('Pending'); update Orders set cust_id=(select top 1 id from CurrentUser) , custOrderID=(select top 1 id from CurrentUser), dTime=GETDATE(),pay_type='Cash On Delivery',Tamount='" + tot_amount + "',cashRet=0,cashierId=11 where id=(select top 1 id from Orders order by id desc); ";

            SqlCommand command3 = new SqlCommand(query3, sqlConnection3);

            int res3 = command3.ExecuteNonQuery();

            sqlConnection3.Close();

            if (res3 != 0)
            {
                MessageBox.Show("Order Placed");
            }
            int lp = 1;
            string connString4 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection4 = new SqlConnection(connString4);
            sqlConnection4.Open();

            string query4 = "select top 1 loyaltyP from CurrentUser;";

            SqlCommand command4 = new SqlCommand(query4, sqlConnection4);

            object result4 = command4.ExecuteScalar();

            if (result4 != null)
            {
                int lp2 = Convert.ToInt32(result4);
                lp = lp2 + 1;
            }
            //--------------------------------------------------------
            string connString5 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection5 = new SqlConnection(connString5);
            sqlConnection5.Open();

            string query5 = "update users set loyaltyP = '" + lp + "' where id  = (select top 1 id from CurrentUser); update CurrentUser set loyaltyP = '" + lp + "';";

            SqlCommand command5 = new SqlCommand(query5, sqlConnection5);


            int res5 = command5.ExecuteNonQuery();

            sqlConnection5.Close();

            Custtrackorder f = new Custtrackorder();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
