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
    public partial class Custmenu : Form
    {
        public Custmenu()
        {
            InitializeComponent();
        }

        private void hIRINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custmyaccount f = new Custmyaccount();
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

        private void Custmenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Custmenufastfood f = new Custmenufastfood();
            f.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Custmenudrinks f = new Custmenudrinks();
            f.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Custmenusnacks f = new Custmenusnacks();
            f.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Custmenudesserts f = new Custmenudesserts();
            f.Visible = true;
            this.Visible = false;
        }
    }
}
