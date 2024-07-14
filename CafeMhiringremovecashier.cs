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
    public partial class CafeMhiringremovecashier : Form
    {
        public CafeMhiringremovecashier()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "update users set name = '' where id = 11 and username = '" + username + "';";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();

            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The cashier has been successfully deleted. Now Add/Hire a new Cashier");
                CafeMhiringaddcashier f = new CafeMhiringaddcashier();
                f.Visible = true;
                this.Visible = false;
            }

            else
            {
                MessageBox.Show("Cashier not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CafeM_hiring f = new CafeM_hiring();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
