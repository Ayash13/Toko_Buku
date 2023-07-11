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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
