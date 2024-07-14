using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;


namespace Cmpusbites_2
{
    //public partial class UserInfo
    //{
    //    public static string Username { get; set; }
    //    public static string password { get; set; }

    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //signup button
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool flag = true;

            // Session["Username"] = username;

            string connString = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

            SqlConnection sql = new SqlConnection(connString);
            sql.Open();

            string query = "select * from Users  WHERE username='" + username + "'AND password='" + password + "';insert into CurrentUser(id,username,password,name,contact,address,user_type,loyaltyP,credcard_accno,credcard_pass,cvv_code) values(0, '" + username + "' , '" + password + "',' ',' ',' ',4,1,'','','');update CurrentUser set name=(select name from Users where username='" + username + "' and password='" + password + "'),contact=(select contact from Users where username='" + username + "' and password='" + password + "'),address=(select address from Users where username='" + username + "' and password='" + password + "'), id = (select id from users where username = '" + username + "' and password = '" + password + "'), credcard_accno = (select credcard_accno from Users where username='" + username + "' and password='" + password + "'), credcard_pass = (select credcard_pass from Users where username='" + username + "' and password='" + password + "'), cvv_code = (select cvv_code from Users where username='" + username + "' and password='" + password + "'), loyaltyP = (select loyaltyP from Users where username='" + username + "' and password='" + password + "') where username='" + username + "' and password='" + password + "';";

            SqlCommand command = new SqlCommand(query, sql);

            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {

                MessageBox.Show("Login Successfull");

                if (username == "admin123" && password == "imcafemanager")
                {
                    CafeM CF = new CafeM();

                    CF.Visible = true;
                    this.Visible = false;
                }

                else if (password == "iminvmanager")
                {
                    InvMadditem Inv = new InvMadditem();

                    Inv.Visible = true;
                    this.Visible = false;
                }

                else
                {

                    Custmyaccount f3 = new Custmyaccount();
                    f3.Visible = true;
                    this.Visible = false;
                }




            }


            else
            {
                MessageBox.Show("The account does not exist. Create a new one!");
                flag = false;

            }
            if (flag == false)
            {
                string connString2 = "Data Source=DESKTOP-74H9KDR\\SQLEXPRESS;Initial Catalog=FinalProj;Integrated Security=True";

                SqlConnection sql2 = new SqlConnection(connString2);
                sql2.Open();

                string query2 = "delete from CurrentUser;";
                SqlCommand command2 = new SqlCommand(query2, sql2);

                SqlDataReader reader2 = command2.ExecuteReader();
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}