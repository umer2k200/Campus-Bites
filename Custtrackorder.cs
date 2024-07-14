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
    public partial class Custtrackorder : Form
    {
        public Custtrackorder()
        {
            InitializeComponent();
            populateData();
        }
        System.Timers.Timer Timer;
        int m, s;
        private void Custtrackorder_Load(object sender, EventArgs e)
        {
            Timer = new System.Timers.Timer();
            Timer.Interval = 1000;
            Timer.Elapsed += Timer_Elapsed;
            s = 60;
            m = 0;
            Timer.Start();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s = s - 1;
                if (s == 0)
                {
                    Timer.Stop();
                    MessageBox.Show("Order Delivered!");

                    string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connString);
                    sqlConnection.Open();

                    string query = "update Orders set stat='Delivered' where cust_id=(select id from CurrentUser);";

                    SqlCommand command = new SqlCommand(query, sqlConnection);
                    int res = command.ExecuteNonQuery();
                    sqlConnection.Close();

                    Custmyaccount f = new Custmyaccount();
                    f.Visible = true;
                    this.Visible = false;
                }
                label3.Text = "Your Order will be delivered in: " + m + ":" + s.ToString("00") + " seconds";
            }));
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

        private void rEMOVEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmycart f = new Custmycart();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custfeedback f = new Custfeedback();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            string query = "select id,stat,dTime,pay_type,Tamount,cashRet,cashierId from Orders where cust_id=(select id from CurrentUser) and stat = 'Pending';";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
