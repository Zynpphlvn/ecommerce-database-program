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
    public partial class OrderDetails : Form
    {
        Boolean cellSelected = false;
        String invoiceid;
        String cargoid;
        String order_id;
        SqlConnection connection = new SqlConnection("Data Source=HCP\\SQLEXPRESS;Initial Catalog=ecommercedb;Integrated Security=True");
        String username;
        String[] orderdetails;
        string usernametext;
        public OrderDetails( String username)
        {
            InitializeComponent();
            this.username = username;


            String queryy = "Select user_surname from User_ where user_name ='" + username + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(queryy, connection);
            da.Fill(ds);

            foreach (DataRow pRow in ds.Tables[0].Rows)
                 usernametext= username + " "  + pRow["user_surname"].ToString();
                     
            richTextBox1.Text = usernametext.ToUpper();


            String query = "select o.order_id ,order_date ,serial_number, price, category_name, brand_name,screen_size,color_name from OrderLine as o, Product p, Category c, Brand b,Color co , Order_ ord, User_ u where o.product_id = p.product_id and c.category_id= p.category_id and b.brand_id=p.brand_id and p.color_id=co.color_id and ord.order_id= o.order_id and u.user_name = '" + username + "' and u.user_id=ord.user_id";
            ds = new DataSet();
                    da = new SqlDataAdapter(query, connection);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void invoicedetails_Click(object sender, EventArgs e)
        {

            if (cellSelected)
            {
                String query = "Select i.invoice_id,bank_name, cost, number_of_installment, monthly_payment, address_id from Invoice as i, Bank as b where i.invoice_id = '" + invoiceid + "' and b.bank_id=i.bank_id";
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];

            }
            else
                MessageBox.Show("Please select an order");
          
        }

        private void cargodetails_Click(object sender, EventArgs e)
        {
            if (cellSelected)
            {
                String query = "select cargo_id,cargo_name,delivery_date,country_name,city_name,district_name,zip_code from Cargo as c, Address_ as a where c.cargo_id = '" + cargoid +"' and a.address_id = c.address_id";
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(ds);
                dataGridView3.DataSource = ds.Tables[0];

            }
            else
                MessageBox.Show("Please select an order");
               
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cellSelected = true;
            int selected = dataGridView1.SelectedCells[0].RowIndex;

            String query = "select ord.invoice_id, ord.cargo_id from OrderLine as o, Product p, Category c, Brand b,Color co , Order_ ord, User_ u where o.product_id = p.product_id and c.category_id= p.category_id and b.brand_id=p.brand_id and p.color_id=co.color_id and ord.order_id= o.order_id and u.user_name = '" + username + "' and u.user_id=ord.user_id and ord.order_id = '" +order_id + "'"; 
           
            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            
            da.Fill(ds);

            foreach (DataRow pRow in ds.Tables[0].Rows)
            {

                invoiceid = pRow["invoice_id"].ToString();
                cargoid = pRow["cargo_id"].ToString();


            }

            order_id= dataGridView1.Rows[selected].Cells[0].Value.ToString();
            invoice_id.Text = invoiceid;
            cargo_id.Text = cargoid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Main.user == 0)
            {
                Admin_Users adminusers = new Admin_Users();
                adminusers.Show();
                this.Hide();

            }
            else
            {
                UserProfile userprofile = new UserProfile("", null,username);
                userprofile.Show();
                this.Hide();

            }
           
        }
    }
}
