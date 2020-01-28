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
    public partial class Admin_Products : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
        String query = "select product_id, serial_number, price, screen_size, bluetooth, warranty, origin, category_name, brand_name, color_name "
                           + "from Product as p, Category as c, Brand as b, Color as co where p.category_id = c.category_id and p.brand_id = b.brand_id and p.color_id = co.color_id";

        public Admin_Products()
        {
            InitializeComponent();

            DataSet ds = new DataSet();       
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds);
            productsDataGridView.DataSource = ds.Tables[0];

            connection.Open();
            SqlCommand sc = new SqlCommand("select brand_name from Brand", connection);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("brand_name", typeof(string));
            dt.Rows.Add(new object[] { "Select" });
            dt.Load(reader);

            brandComboBox.ValueMember = "brand_name";
            brandComboBox.DataSource = dt;
            connection.Close();

            connection.Open();
            SqlCommand sc2 = new SqlCommand("select category_name from Category", connection);
            SqlDataReader reader2;

            reader2 = sc2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("category_name", typeof(string));
            dt2.Rows.Add(new object[] { "Select" });
            dt2.Load(reader2);

            categoryComboBox.ValueMember = "category_name";
            categoryComboBox.DataSource = dt2;
            connection.Close();

            connection.Open();
            SqlCommand sc3 = new SqlCommand("select color_name from Color", connection);
            SqlDataReader reader3;

            reader3 = sc3.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("color_name", typeof(string));
            dt3.Rows.Add(new object[] { "Select" });
            dt3.Load(reader3);

            colorComboBox.ValueMember = "color_name";
            colorComboBox.DataSource = dt3;
            connection.Close();

            connection.Open();
            SqlCommand sc4 = new SqlCommand("select distinct price from Product", connection);
            SqlDataReader reader4;

            reader4 = sc4.ExecuteReader();
            DataTable dt4 = new DataTable();
            dt4.Columns.Add("price", typeof(string));
            dt4.Rows.Add(new object[] { "Select" });
            dt4.Load(reader4);

            priceComboBox.ValueMember = "price";
            priceComboBox.DataSource = dt4;
            connection.Close();

            connection.Open();
            SqlCommand sc5 = new SqlCommand("select distinct screen_size from Product", connection);
            SqlDataReader reader5;

            reader5 = sc5.ExecuteReader();
            DataTable dt5 = new DataTable();
            dt5.Columns.Add("screen_size", typeof(string));
            dt5.Rows.Add(new object[] { "Select" });
            dt5.Load(reader5);

            screenSizeComboBox.ValueMember = "screen_size";
            screenSizeComboBox.DataSource = dt5;
            connection.Close();

            connection.Open();
            SqlCommand sc6 = new SqlCommand("select distinct bluetooth from Product", connection);
            SqlDataReader reader6;

            reader6 = sc6.ExecuteReader();
            DataTable dt6 = new DataTable();
            dt6.Columns.Add("bluetooth", typeof(string));
            dt6.Rows.Add(new object[] { "Select" });
            dt6.Load(reader6);

            bluetoothComboBox.ValueMember = "bluetooth";
            bluetoothComboBox.DataSource = dt6;
            query = "select product_id, serial_number, price, screen_size, bluetooth, warranty, origin, category_name, brand_name, color_name "
                           + "from Product as p, Category as c, Brand as b, Color as co where p.category_id = c.category_id and p.brand_id = b.brand_id and p.color_id = co.color_id";

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();

            this.Hide();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            AdminAddProduct addProduct = new AdminAddProduct();
            addProduct.Show();
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = productsDataGridView.SelectedCells[0].RowIndex;
            serialNumsTextBox.Text = productsDataGridView.Rows[selected].Cells[1].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var itemToDelete = serialNumsTextBox.Text;

            using (connection)
            {
                connection.Open();

                using (var command = new SqlCommand("DELETE FROM Product WHERE serial_number = '" + serialNumsTextBox.Text + "'", connection))
                {
                    // delete item from database
                    //command.Parameters.AddWithValue("serial_number", itemToDelete.Id);
                    command.ExecuteNonQuery();

                    // delete item from datasource and update DGV
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.Fill(ds);
                    productsDataGridView.DataSource = ds.Tables[0];

                    MessageBox.Show("Product deleted.");
                }
                
            }
            connection.Close();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoryFilterSelected = categoryComboBox.Text;
            query += " and " + "c.category_name = '" + categoryFilterSelected + "'";
        }

        private void brandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string brandFilterSelected = brandComboBox.Text;
            query += " and " + "b.brand_name = '" + brandFilterSelected + "'";
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorFilterSelected = colorComboBox.Text;
            query += " and " + "co.color_name = '" + colorFilterSelected + "'";
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string priceFilterSelected = priceComboBox.Text;
            query += " and " + "p.price = '" + priceFilterSelected + "'";
        }

        private void screenSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string screenSizeFilterSelected = screenSizeComboBox.Text;
            query += " and " + "p.screen_size = '" + screenSizeFilterSelected + "'";
        }

        private void bluetoothComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bluetoothFilterSelected = bluetoothComboBox.Text;
            query += " and " + "p.bluetooth = '" + bluetoothFilterSelected + "'";
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds);
            productsDataGridView.DataSource = ds.Tables[0];
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            query = "select product_id, serial_number, price, screen_size, bluetooth, warranty, origin, category_name, brand_name, color_name "
                   + "from Product as p, Category as c, Brand as b, Color as co where p.category_id = c.category_id and p.brand_id = b.brand_id and p.color_id = co.color_id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds);
            productsDataGridView.DataSource = ds.Tables[0];
        }
    }
}
