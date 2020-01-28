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
using System.Collections;


namespace EcommerceApplication
{
    public partial class UserProfile : Form
    {
        String username;

        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
        int cntrl2 = 0;
        int selected;

        ArrayList serialNumbers = new ArrayList();
        String Query = "select product_id, serial_number, price, screen_size, bluetooth, warranty, origin, category_name, brand_name, color_name "
                            + "from Product as p, Category as c, Brand as b, Color as co where p.category_id = c.category_id and p.brand_id = b.brand_id and p.color_id = co.color_id";
        int cntrl;

        public UserProfile(String query, ArrayList serialNums, String username)
        {
            InitializeComponent();
            var dataAdapter = new SqlDataAdapter(query, connection);

            if (query != "")
            {
                MessageBox.Show(query);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                orderBasketGridView.DataSource = ds.Tables[0];
            }
            this.serialNumbers = serialNums; 
            this.username = username;
        }

        private void startShoppingButton_Click(object sender, EventArgs e)
        {
            UserProducts products = new UserProducts(username);
            products.Show();
            this.Hide();    

        }

        private void updateOrderBasketButton_Click(object sender, EventArgs e)
        {
            var select = "SELECT * FROM OrderBasketTemp";
            var dataAdapter = new SqlDataAdapter(select, connection);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            orderBasketGridView.ReadOnly = true;
            orderBasketGridView.DataSource = ds.Tables[0];
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {

            UserProducts.delete = 1;
            UserProducts.cntrl = 0;
            for (int i = 0; i < serialNumbers.Count; i++)
            {
                cntrl2 = 1;
                if (serialNumbers[i].Equals(deleteTextBox.Text))
                {
                    orderBasketGridView.Rows.RemoveAt(selected);
                    serialNumbers.RemoveAt(i);
                }
                else
                {
                    if (cntrl == 0)
                    {
                        Query += " and ( p.serial_number = '" + serialNumbers[i] + "')";
                        cntrl = 1;
                    }
                    else
                    {
                        Query = Query.Substring(0, Query.Length - 1);
                        Query += " or p.serial_number = '" + serialNumbers[i] + "')";
                    }
                }
            }
            if (Query != "" && cntrl2 == 0)
            {
                var dataAdapter = new SqlDataAdapter(Query, connection);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                orderBasketGridView.DataSource = ds.Tables[0];

            }
            UserProducts.orderQuery = Query;

            MessageBox.Show("Product deleted.");
        }

        private void showorders_Click(object sender, EventArgs e)
        {

            OrderDetails orders = new OrderDetails(username);
            orders.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUser loginuser = new LoginUser();
            loginuser.Show();

            this.Hide();
        }

        private void orderBasketGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = orderBasketGridView.SelectedCells[0].RowIndex;
            deleteTextBox.Text = orderBasketGridView.Rows[selected].Cells[1].Value.ToString();
        }
    }
}
