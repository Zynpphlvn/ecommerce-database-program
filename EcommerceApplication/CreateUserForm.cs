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

namespace EcommerceApplication
{
    public partial class CreateUserForm : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand signup = new SqlCommand("insert into User_ (user_name, user_surname, identifier_number, age, gender, email, phone_number, password) values (@u1, @u2, @u3, @u4, @u5, @u6, @u7, @u8)", connection);
            signup.Parameters.AddWithValue("@u1", nameTextbox.Text);
            signup.Parameters.AddWithValue("@u2", surnameTextBox.Text);
            signup.Parameters.AddWithValue("@u3", idNoTextBox.Text);
            signup.Parameters.AddWithValue("@u4", ageTextBox.Text);
            signup.Parameters.AddWithValue("@u5", genderTextBox.Text);
            signup.Parameters.AddWithValue("@u6", emailTextBox.Text);
            signup.Parameters.AddWithValue("@u7", phoneTextBox.Text);
            signup.Parameters.AddWithValue("@u8", passwordTextBox.Text);

            signup.ExecuteNonQuery();

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUser loginuser= new LoginUser();
            loginuser.Show();

            this.Hide();
        }
    }
}
