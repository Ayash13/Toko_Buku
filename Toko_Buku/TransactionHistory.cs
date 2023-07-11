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
    public partial class TransactionHistory : Form
    {
        private string CustomerID;
        private SqlConnection connection;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";

        public TransactionHistory(string customerID)
        {
            InitializeComponent();
            CustomerID = customerID;
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            LoadTransactionHistory();
        }

        private void LoadTransactionHistory()
        {
            string query = @"SELECT O.OrderDate, P.Name AS ProductName, P.Description, OD.Quantity, E.Name AS Expedition,
                    E.ETA, OD.Subtotal AS TotalAmount, P.Image AS ProductImage
                    FROM [Order] O
                    JOIN OrderDetail OD ON O.OrderID = OD.OrderID
                    JOIN Product P ON OD.ProductID = P.ProductID
                    JOIN Expedition E ON O.ExpeditionID = E.ExpeditionID
                    WHERE O.CustomerID = @CustomerID
                    ORDER BY O.OrderDate DESC";

            try
            {
                connection.Open();
                adapter.SelectCommand = new SqlCommand(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", CustomerID);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                DataColumn dateColumn = new DataColumn("TransactionDate", typeof(DateTime));
                dataTable.Columns.Add(dateColumn);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["TransactionDate"] = DateTime.Parse(row["OrderDate"].ToString());
                }

                dataTable.Columns.Remove("OrderDate");

                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TransactionDate",
                    HeaderText = "Transaction Date",
                    DataPropertyName = "TransactionDate",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductName",
                    HeaderText = "Product Name",
                    DataPropertyName = "ProductName",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Description",
                    HeaderText = "Description",
                    DataPropertyName = "Description",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Quantity",
                    HeaderText = "Quantity",
                    DataPropertyName = "Quantity",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Expedition",
                    HeaderText = "Expedition",
                    DataPropertyName = "Expedition",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ETA",
                    HeaderText = "ETA",
                    DataPropertyName = "ETA",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TotalAmount",
                    HeaderText = "Total Amount",
                    DataPropertyName = "TotalAmount",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

                dataGridView1.Columns.Add(new DataGridViewImageColumn
                {
                    Name = "ProductImage",
                    HeaderText = "Product Image",
                    DataPropertyName = "ProductImage",
                    SortMode = DataGridViewColumnSortMode.Automatic
                });

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

        private void TransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                byte[] imageData = (byte[])selectedRow.Cells["ProductImage"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

    }
}
