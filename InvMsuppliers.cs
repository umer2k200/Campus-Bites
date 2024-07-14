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
    public partial class InvMsuppliers : Form
    {
        public InvMsuppliers()
        {
            InitializeComponent();
            populateData();
        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMadditem f = new InvMadditem();
            f.Visible = true;
            this.Visible = false;
        }

        private void mENUMANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMupdateitem f = new InvMupdateitem();
            f.Visible = true;
            this.Visible = false;
        }

        private void rEMOVEITEMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMremoveitem f = new InvMremoveitem();
            f.Visible = true;
            this.Visible = false;
        }

        private void vIEWSALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMviewinventory f = new InvMviewinventory();
            f.Visible = true;
            this.Visible = false;
        }

        private void sETCOUPONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMorderitems f = new InvMorderitems();
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

            string query = "select supplier,itemName,category from Inventory";

            //string query = "select name,contact,address from Users where user_type = 2 or user_type = 3;";
            SqlCommand cmd = new SqlCommand(query, sqlConnection);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                dataGridView1.Columns.Add("Supplier Name", "Supplier Name");
                dataGridView1.Columns.Add("Item", "Item");
                dataGridView1.Columns.Add("Category", "Category");


                while (rdr.Read())
                {
                    string sup = rdr["supplier"].ToString();
                    string it = rdr["itemName"].ToString();
                    string cat = rdr["category"].ToString();



                    dataGridView1.Rows.Add(sup, it, cat);
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
    }
}
