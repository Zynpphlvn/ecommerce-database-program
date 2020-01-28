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
    public partial class AdminAddProduct : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");

        public AdminAddProduct()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand addProduct = new SqlCommand("insert into Product (serial_number, price, category_id, brand_id, screen_size, color_id, bluetooth, warranty, origin) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)", connection);
            //da = new SqlDataAdapter("SELECT category_id FROM Category WHERE category_name = '" + categoryTextBox.Text + "'", connection);
            string sql = "SELECT category_id FROM Category WHERE category_name = '" + categoryTextBox.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, connection);
            var categoryId = Convert.ToInt32(cmd.ExecuteScalar());

            sql = "SELECT brand_id FROM Brand WHERE brand_name = '" + brandTextBox.Text + "'";
            cmd = new SqlCommand(sql, connection);
            var brandId = Convert.ToInt32(cmd.ExecuteScalar());

            sql = "SELECT color_id FROM Color WHERE color_name = '" + colorTextBox.Text + "'";
            cmd = new SqlCommand(sql, connection);
            var colorId = Convert.ToInt32(cmd.ExecuteScalar());

            addProduct.Parameters.AddWithValue("@p1", serialNumTextBox.Text);
            addProduct.Parameters.AddWithValue("@p2", priceTextBox.Text);
            addProduct.Parameters.AddWithValue("@p3", categoryId);
            addProduct.Parameters.AddWithValue("@p4", brandId);
            addProduct.Parameters.AddWithValue("@p5", screenSizeTextBox.Text);
            addProduct.Parameters.AddWithValue("@p6", colorId);
            addProduct.Parameters.AddWithValue("@p7", int.Parse(bluetoothTextBox.Text));
            addProduct.Parameters.AddWithValue("@p8", warrantyTextBox.Text);
            addProduct.Parameters.AddWithValue("@p9", originTextBox.Text);

            addProduct.ExecuteNonQuery();

            string queryString = "EXEC sp_executeSQL N'CREATE trigger same_brandss on Product after insert as begin select * from Product where brand_id = " + brandId + " end'";
            //cmd.CommandText = queryString;
            //cmd.ExecuteNonQuery();

            DataSet ds = new DataSet();
            string query = "select * from Product where brand_id = " + brandId;
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            connection.Close();
        }
    }
}
