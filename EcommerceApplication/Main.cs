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
    public partial class Main : Form
    {
        public static int user = 0;

        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
        }

        private void userlogin_Click(object sender, EventArgs e)
        {
            user = 1;
            LoginUser userlogin = new LoginUser();
            userlogin.Show();

            this.Hide();
        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            LoginAdmin adminlogin = new LoginAdmin();
            adminlogin.Show();

            this.Hide();
        }
    }
}
