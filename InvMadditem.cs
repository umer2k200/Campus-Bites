using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cmpusbites_2
{
    public partial class InvMadditem : Form
    {
        public InvMadditem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string itemname = this.textBox1.Text;
            string category = this.textBox2.Text;
            string supplier = this.textBox3.Text;
            string quantity = this.textBox4.Text;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            string query = "insert into Inventory(quantity,supplier,mgr_id,itemId,itemName,category) values ('" + quantity + "','" + supplier + "',10,'" + null + "','" + itemname + "','" + category + "');";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The item has been successfully added");

                InvMadditem obj = new InvMadditem();

                obj.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Item not added");
            }

        }

        private void InvM_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vIEWINVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMsuppliers f = new InvMsuppliers();
            f.Visible = true;
            this.Visible = false;
        }

        private void sETCOUPONSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMorderitems f = new InvMorderitems();
            f.Visible = true;
            this.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}
