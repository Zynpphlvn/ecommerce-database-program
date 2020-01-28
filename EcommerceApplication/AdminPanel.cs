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
    public partial class AdminPanel : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Users users = new Admin_Users();
            users.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Products products = new Admin_Products();
            products.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginAdmin login = new LoginAdmin();
            login.Show();

            this.Hide();
        }
    }
}
