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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Fullname = this.textBox1.Text;
            string username = this.textBox2.Text;
            string password = this.textBox3.Text;
            string phoneNo = this.textBox4.Text;
            string address = this.textBox5.Text;
            string credcardaccno = this.textBox6.Text;
            string credcardpass = this.textBox7.Text;
            string cvvcode = this.textBox8.Text;
            int ustype = 4;
            int LP = 1;

            if (credcardaccno == "credit/debit card number" || credcardpass == "credit/debit card pass" || cvvcode == "credit/debit card cvv code")
            {
                //no credit card details
                string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                string query = "insert into Users(username,password,name,contact,address,user_type,loyaltyP,credcard_accno,credcard_pass,cvv_code) values" + "('" + username + "','" + password + "','" + Fullname + "','" + phoneNo + "','" + address + "','" + ustype + "','" + LP + "','NULL','NULL','NULL'); insert into userContact values('" + username + "','" + phoneNo + "','" + address + "')";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                int res = command.ExecuteNonQuery();

                sqlConnection.Close();

                if (res != 0)
                {
                    MessageBox.Show("The account has been successfully created");
                    Form1 f1 = new Form1();
                    f1.Visible = true;
                    this.Visible = false;
                }

                else
                {
                    MessageBox.Show("Account not created");
                }
            }
            else
            {
                //credit card details are provided
                string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();

                string query = "insert into Users(username,password,name,contact,address,user_type,loyaltyP,credcard_accno,credcard_pass,cvv_code) values" + "('" + username + "','" + password + "','" + Fullname + "','" + phoneNo + "','" + address + "','" + ustype + "','" + LP + "','" + credcardaccno + "','" + credcardpass + "','" + cvvcode + "'); insert into userContact values('" + username + "','" + phoneNo + "','" + address + "')";

                SqlCommand command = new SqlCommand(query, sqlConnection);

                int res = command.ExecuteNonQuery();

                sqlConnection.Close();

                if (res != 0)
                {
                    MessageBox.Show("The account has been successfully created");
                    Form1 f1 = new Form1();
                    f1.Visible = true;
                    this.Visible = false;
                }

                else
                {
                    MessageBox.Show("Account not created");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.PasswordChar = '*';
        }
    }
}
