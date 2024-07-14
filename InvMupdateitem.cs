using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cmpusbites_2
{
    public partial class InvMupdateitem : Form
    {
        public InvMupdateitem()
        {
            InitializeComponent();
        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvMadditem f = new InvMadditem();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string itemname = this.textBox1.Text;
            string cat = this.textBox2.Text;
            string quantity = this.textBox3.Text;


            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            sqlConnection.Open();

            //string query1="select * from MenuItems where name in(select )"


            string query = "update Inventory set itemName='" + itemname + "',category='" + cat + "',quantity='" + quantity + "' where itemName='" + itemname + "' AND category='" + cat + "';";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int res = command.ExecuteNonQuery();
            sqlConnection.Close();

            if (res != 0)
            {
                MessageBox.Show("The item has been successfully updated");

                InvMupdateitem obj = new InvMupdateitem();

                obj.Visible = true;
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Item not updated");
            }
        }
    }
}
