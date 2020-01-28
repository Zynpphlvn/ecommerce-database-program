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
    public partial class Admin_Users : Form
    {
        String [] orderdetails= new String[10];
        String [] temp_orderdetails = new String[10];

        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
        DataSet ds = new DataSet();


        public Admin_Users()
        {
            InitializeComponent();
        }

   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            orderdetails[0] = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            orderdetails[1] = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            orderdetails[2] = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            orderdetails[3] = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            orderdetails[4] = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            orderdetails[5] = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            orderdetails[6] = dataGridView1.Rows[selected].Cells[6].Value.ToString();
            orderdetails[7] = dataGridView1.Rows[selected].Cells[7].Value.ToString();
            orderdetails[8] = dataGridView1.Rows[selected].Cells[8].Value.ToString();
            orderdetails[9] = dataGridView1.Rows[selected].Cells[9].Value.ToString();

            for (int i = 0; i < 10; i++)
                     temp_orderdetails[i] = orderdetails[i];


            textBox1.Text = orderdetails[0];
            textBox2.Text = orderdetails[1];
            textBox3.Text = orderdetails[2];
            textBox4.Text = orderdetails[3];
            textBox5.Text = orderdetails[4];
            textBox6.Text = orderdetails[5];
            textBox7.Text = orderdetails[6];
            textBox8.Text = orderdetails[7];
            textBox9.Text = orderdetails[8];
            textBox10.Text = orderdetails[9];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();

            this.Hide();
        }

        private void wiev_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            String searchtext = searchBox.Text.Trim().ToLower();
            String query = "";


            if (searchtext != "")
            {
                searchtext = char.ToUpper(searchtext[0]) + searchtext.Substring(1);
                query = "Select * from User_ where user_name = '" + searchtext + "'";

            }

            else
                query = "Select * from User_ ";

            SqlDataAdapter da = new SqlDataAdapter(query, connection);

            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void orderdetail_Click_1(object sender, EventArgs e)
        {
            if (orderdetails[9] != "0")
            {

                OrderDetails order = new OrderDetails(orderdetails[1]);
                order.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("This user does not have any order yet!");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connection.Open();
            String changetext ;

            SqlCommand cmd = new SqlCommand(" UPDATE User_ SET user_name = '" + textBox2.Text + "' Where user_name ='" + orderdetails[1] + "'", connection);
            cmd.ExecuteNonQuery();
           
            cmd = new SqlCommand(" UPDATE User_ SET user_surname = '" + textBox3.Text + "' Where user_surname ='" + orderdetails[2] + "'", connection);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(" UPDATE User_ SET age = '" + textBox5.Text + "' Where age ='" + orderdetails[4] + "'", connection);
            cmd.ExecuteNonQuery();
            
            cmd = new SqlCommand(" UPDATE User_ SET gender = '" + textBox6.Text + "' Where gender ='" + orderdetails[5] + "'", connection);
            cmd.ExecuteNonQuery();
            
            cmd = new SqlCommand(" UPDATE User_ SET email = '" + textBox7.Text + "' Where email ='" + orderdetails[6] + "'", connection);
            cmd.ExecuteNonQuery();
            
            cmd = new SqlCommand(" UPDATE User_ SET phone_number = '" + textBox8.Text + "' Where phone_number ='" + orderdetails[7] + "'", connection);
            cmd.ExecuteNonQuery();
     
            cmd = new SqlCommand(" UPDATE User_ SET user_name = '" + textBox10.Text + "' Where user_name ='" + orderdetails[9] + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        private void textBox1_ModifiedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change user id");
          //  textBox1.Text = myRow["user_id"].ToString();
        }

        
        private void textBox4_ModifiedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change identifier number");
        }

        private void textBox9_ModifiedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("You cannot change registration number");

        }
    }

}
