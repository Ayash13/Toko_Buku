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
    public partial class TransactionData : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";

        public TransactionData()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            LoadTransactionData();
            btn_search.Click += btn_search_Click;
        }

        private void LoadTransactionData()
        {
            string query = @"SELECT O.OrderDate, O.CustomerID, C.Name AS CustomerName, C.Email, C.PhoneNumber, C.Address,
                    OD.ProductID, P.Name AS ProductName, OD.Quantity, OD.Subtotal AS TotalAmount, PM.PaymentMethod
                    FROM [Order] O
                    JOIN OrderDetail OD ON O.OrderID = OD.OrderID
                    JOIN Product P ON OD.ProductID = P.ProductID
                    JOIN Customer C ON O.CustomerID = C.CustomerID
                    JOIN Payment PM ON O.OrderID = PM.OrderID
                    ORDER BY O.OrderDate DESC";

            try
            {
                connection.Open();
                adapter.SelectCommand = new SqlCommand(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
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
                connection.Close();
            }
        }


        private void txbx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string customerName = txbx_name.Text.Trim();

            // Execute the search query only if the customer name is not empty
            if (!string.IsNullOrEmpty(customerName))
            {
                string query = @"SELECT O.OrderDate, O.CustomerID, C.Name AS CustomerName, C.Email, C.PhoneNumber, C.Address,
                OD.ProductID, P.Name AS ProductName, OD.Quantity, OD.Subtotal AS TotalAmount, PM.PaymentMethod
                FROM [Order] O
                JOIN OrderDetail OD ON O.OrderID = OD.OrderID
                JOIN Product P ON OD.ProductID = P.ProductID
                JOIN Customer C ON O.CustomerID = C.CustomerID
                JOIN Payment PM ON O.OrderID = PM.OrderID
                WHERE C.Name LIKE @CustomerName
                ORDER BY O.OrderDate DESC";

                try
                {
                    connection.Open();
                    adapter.SelectCommand = new SqlCommand(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@CustomerName", "%" + customerName + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
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
                    connection.Close();
                }
            }
            else
            {
                LoadTransactionData();
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string productID = row.Cells["ProductID"].Value.ToString();

                // Retrieve the image from the database based on the ProductID
                string query = "SELECT Image FROM Product WHERE ProductID = @ProductID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@ProductID", productID);
                        byte[] imageData = (byte[])command.ExecuteScalar();

                        if (imageData != null)
                        {
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
    }
}
