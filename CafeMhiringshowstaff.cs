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
    public partial class CafeMhiringshowstaff : Form
    {
        public CafeMhiringshowstaff()
        {
            InitializeComponent();
            populateData();
        }

        public void populateData()
        {
            string conString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();

            string query = "select U.name,UC.Contact,UC.address from Users U join userContact UC on U.username=UC.username where U.user_type=3 OR U.user_type=2 ";
            //string query = "select name,contact,address from Users where user_type = 2 or user_type = 3;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("U.name", "U.name");
                dataGridView1.Columns.Add("UC.Contact", "UC.Contact");
                dataGridView1.Columns.Add("UC.address", "UC.address");

                while (rdr.Read())
                {
                    string name = rdr["Name"].ToString();
                    string contact = rdr["Contact"].ToString();
                    string address = rdr["Address"].ToString();

                    dataGridView1.Rows.Add(name, contact, address);
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

        private void button1_Click(object sender, EventArgs e)
        {
            CafeM_hiring f = new CafeM_hiring();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
