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
    public partial class Custmyaccount : Form
    {
        public Custmyaccount()
        {
            InitializeComponent();
            populateData();
            populateData2();
            populateData3();
        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mENUMANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmenu f = new Custmenu();
            f.Visible = true;
            this.Visible = false;
        }

        private void rEMOVEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmycart f = new Custmycart();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string contact = this.textBox1.Text;
            string address = this.textBox2.Text;
            string password = this.textBox3.Text;
            string rps = this.textBox4.Text;

            if (password == rps)
            {
                string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                string query = "update Users set contact='" + contact + "',address='" + address + "',password='" + password + "' where id=(select top 1 id from CurrentUser );";

                SqlCommand command = new SqlCommand(query, sqlConnection);
                int res = command.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Profile updated");
                Custmyaccount f = new Custmyaccount();
                f.Visible = true;
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("The passwords are not identical");
            }

        }

        public void populateData()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select * from orders";

            //string query = "select name,contact,address from Users where user_type = 2 or user_type = 3;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
        }

        public void populateData2()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select loyaltyP from CurrentUser";

            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            // object rdr = cmd.ExecuteScalar();
            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                dataGridView2.Columns.Add("Loyalty Points", "Loyalty Points");


                while (rdr.Read())
                {

                    string LP = rdr["loyaltyP"].ToString();

                    dataGridView2.Rows.Add(LP);
                }
            }



            else
            {
                MessageBox.Show("No data found");
            }


            sqlConnection.Close();

        }

        public void populateData3()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select id,stat,dTime,pay_type,Tamount,cashRet,cashierId from Orders where cust_id=(select id from CurrentUser);";


            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            // object rdr = cmd.ExecuteScalar();
            SqlDataReader rdr = cmd.ExecuteReader();


            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("Id", "Id");
                dataGridView1.Columns.Add("Status", "Status");
                dataGridView1.Columns.Add("Date/Time", "Date/Time");
                dataGridView1.Columns.Add("Payment Type", "Payment Type");
                dataGridView1.Columns.Add("Total Amount", "Total Amount");
                dataGridView1.Columns.Add("Return Amount", "Return Amount");
                dataGridView1.Columns.Add("Cashier Id", "Cashier  Id");


                while (rdr.Read())
                {
                    string id = rdr["id"].ToString();
                    string stat = rdr["stat"].ToString();
                    string dT = rdr["dTime"].ToString();
                    string pay = rdr["pay_type"].ToString();
                    string Tamount = rdr["Tamount"].ToString();
                    string cashR = rdr["cashRet"].ToString();
                    string cashID = rdr["cashierId"].ToString();

                    dataGridView1.Rows.Add(id, stat, dT, pay, Tamount, cashR, cashID);
                }
            }



            else
            {
                MessageBox.Show("No data found");
            }


            sqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
