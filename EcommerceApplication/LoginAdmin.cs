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
    public partial class LoginAdmin : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");


        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void loginbutton_Click_1(object sender, EventArgs e)
        {
            
            string user = username.Text;
            string pass = passwd.Text;
            SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Admin_ where username='" + textBox1.Text.Trim() + "' AND password='" + textBox2.Text + "'";
            Console.WriteLine(cmd.CommandText);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password.");
            }
            connection.Close();

            
           /* AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();
            
            this.Hide();*/

        }

        private void exitbutton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main= new Main();
            main.Show();

            this.Hide();
        }
    }
}
