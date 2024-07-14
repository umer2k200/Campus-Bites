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
    public partial class CafeMviewsales : Form
    {
        public CafeMviewsales()
        {
            InitializeComponent();
            populateData();
        }


        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeM_hiring f = new CafeM_hiring();
            f.Visible = true;
            this.Visible = false;
        }

        private void mENUMANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMadditem f = new CafeMadditem();
            f.Visible = true;
            this.Visible = false;
        }

        private void rEMOVEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CafeMremoveitem f = new CafeMremoveitem();
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

        public void populateData()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select * from Orders";

            //string query = "select name,contact,address from Users where user_type = 2 or user_type = 3;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Status", "Status");
                dataGridView1.Columns.Add("Date/Time", "Date/Time");
                dataGridView1.Columns.Add("Payment Type", "Payment Type");
                dataGridView1.Columns.Add("Total", "Total");
                //dataGridView1.Columns.Add("Quantity", "Quantity");
                dataGridView1.Columns.Add("Remaining", "Remaining");
                dataGridView1.Columns.Add("Cashier Id", "Cashier Id");
                dataGridView1.Columns.Add("Customer Id", "Customer Id");
                // dataGridView1.Columns.Add("Item Id", "Item Id");

                while (rdr.Read())
                {
                    string id = rdr["id"].ToString();
                    string stat = rdr["stat"].ToString();
                    string dTime = rdr["dTime"].ToString();
                    string pay_type = rdr["pay_type"].ToString();
                    string Tamount = rdr["Tamount"].ToString();
                    //string quantity = rdr["quantity"].ToString();
                    string cashRet = rdr["cashRet"].ToString();
                    string cashierId = rdr["cashierId"].ToString();
                    string custId = rdr["cust_Id"].ToString();
                    //string itemId = rdr["itemId"].ToString();


                    dataGridView1.Rows.Add(id, stat, dTime, pay_type, Tamount, cashRet, cashierId, custId);
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
            CafeMviewinsights f = new CafeMviewinsights();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
