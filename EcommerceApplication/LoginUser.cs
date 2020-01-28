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


namespace EcommerceApplication
{
    public partial class LoginUser : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
        DataSet ds = new DataSet();

        public LoginUser()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            string query = "Select * from User_ where user_name = '" + usernameTextbox.Text.Trim() + "' and password ='" + passwordTextbox.Text.Trim() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                UserProfile userProfile = new UserProfile("", null,usernameTextbox.Text);
                userProfile.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
            connection.Close();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            CreateUserForm createUser = new CreateUserForm();
            createUser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Hide();
        }
     }
}
