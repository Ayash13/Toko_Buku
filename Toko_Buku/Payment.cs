using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Buku
{
    public partial class Payment : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public string ProductName { get; set; }
        public string ProductID { get; set; }
        public int ProductPrice { get; set; }
        public int ProductStock { get; set; }
        public byte[] ProductImage { get; set; }
        public string ExpeditionName { get; set; }
        public string ExpeditionETA { get; set; }
        public int ExpeditionPrice { get; set; }
        public int SelectedQuantity { get; set; }
        public int TotalPrice { get; set; }
        public string CustomerID { get; set; }
        public string OrderID { get; set; }

        public Payment(string customerId)
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            CustomerID = customerId;
            LoadCustomerData(customerId);
        }

        private void LoadCustomerData(string customerId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Address, PhoneNumber, Email FROM Customer WHERE CustomerID = @CustomerId";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CustomerId", customerId);
                    try
                    {
                        conn.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            label_customer.Text = reader["Name"].ToString();
                            label_address.Text = reader["Address"].ToString();
                            label_noTelp.Text = reader["PhoneNumber"].ToString();
                            label_email.Text = reader["Email"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading customer data: " + ex.Message);
                    }
                }
            }
        }


        private void Payment_Load_1(object sender, EventArgs e)
        {
            try
            {
                label_Product.Text = ProductName;
                label_qty.Text = SelectedQuantity.ToString();
                label_expedition.Text = ExpeditionName;
                label_eta.Text = ExpeditionETA;
                label_expeditionPrice.Text = ExpeditionPrice.ToString();
                label_totalPrice.Text = TotalPrice.ToString();

                using (MemoryStream ms = new MemoryStream(ProductImage))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the payment form: " + ex.Message);
                this.Close();
            }
        }

        private void label_Product_Click(object sender, EventArgs e)
        {

        }

        private void label_qty_Click(object sender, EventArgs e)
        {

        }

        private void label_expedition_Click(object sender, EventArgs e)
        {

        }

        private void label_eta_Click(object sender, EventArgs e)
        {

        }

        private void label_expeditionPrice_Click(object sender, EventArgs e)
        {

        }

        private void label_customer_Click(object sender, EventArgs e)
        {

        }

        private void label_address_Click(object sender, EventArgs e)
        {

        }

        private void label_noTelp_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void label_totalPrice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbx_paymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBank = cbx_paymentMethod.SelectedItem.ToString();

            switch (selectedBank)
            {
                case "BCA":
                    label_rekeningNumber.Text = "2466372";
                    break;
                case "BRI":
                    label_rekeningNumber.Text = "1234567";
                    break;
                case "BNI":
                    label_rekeningNumber.Text = "9876543";
                    break;
                default:
                    label_rekeningNumber.Text = "";
                    break;
            }
        }

        private void label_rekeningNumber_Click(object sender, EventArgs e)
        {

        }

        private void btn_beli_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmPayment_Click(object sender, EventArgs e)
        {
            string orderDetailID = Guid.NewGuid().ToString().Substring(0, 5);
            string query = "INSERT INTO OrderDetail (OrderDetailID, OrderID, ProductID, Quantity, Subtotal) VALUES (@OrderDetailID, @OrderID, @ProductID, @Quantity, @Subtotal)";
            string paymentID = Guid.NewGuid().ToString().Substring(0, 5);
            string sqlQuery = "INSERT INTO Payment (PaymentID, OrderID, TotalAmount, PaymentMethod) VALUES (@PaymentID, @OrderID, @TotalAmount, @PaymentMethod)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderDetailID", orderDetailID);
                    cmd.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd.Parameters.AddWithValue("@ProductID", ProductID);
                    cmd.Parameters.AddWithValue("@Quantity", label_qty.Text);
                    cmd.Parameters.AddWithValue("@Subtotal", label_totalPrice.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                using (SqlCommand cmd2 = new SqlCommand(sqlQuery, conn))
                {
                    cmd2.Parameters.AddWithValue("@PaymentID", paymentID);
                    cmd2.Parameters.AddWithValue("@OrderID", OrderID);
                    cmd2.Parameters.AddWithValue("@TotalAmount", label_totalPrice.Text);
                    cmd2.Parameters.AddWithValue("@PaymentMethod", cbx_paymentMethod.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd2.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

    }
}
