using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Toko_Buku
{
    public partial class TransactionForm : Form
    {
        private string CustomerID { get; set; }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string selectedExpeditionID;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";

        public TransactionForm(string customerId)
        {
            InitializeComponent();
            CustomerID = customerId;
            LoadProductData();
            ConfigureDataGridViewAppearance();
            LoadExpeditionData();
            dataGridView1.CellClick += dataGridView1_CellClick;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            cbx_expedition.SelectedIndexChanged += cbx_expedition_SelectedIndexChanged;
            btn_beli.Click += btn_beli_Click;
        }

        private void LoadProductData()
        {
            string query = @"SELECT P.ProductID, P.Name, P.Description, P.Price, P.Stock, C.Name AS Category, P.Image
                FROM Product P
                JOIN Category C ON P.CategoryID = C.CategoryID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
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
            }
        }

        private void LoadExpeditionData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT ExpeditionID, Name FROM Expedition"; // Include the ID column in the query
                    SqlCommand command = new SqlCommand(query, conn);
                    DataTable categoryTable = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(categoryTable);
                    }

                    // Add an empty row to the table
                    DataRow emptyRow = categoryTable.NewRow();
                    emptyRow["ExpeditionID"] = string.Empty;
                    emptyRow["Name"] = string.Empty;
                    categoryTable.Rows.InsertAt(emptyRow, 0);

                    cbx_expedition.DisplayMember = "Name";
                    cbx_expedition.ValueMember = "ExpeditionID"; // Set the ValueMember to the ID column
                    cbx_expedition.DataSource = categoryTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void ConfigureDataGridViewAppearance()
        {
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Gray;

            dataGridView1.ReadOnly = true;

            dataGridView1.Columns["ProductID"].Visible = false;
            dataGridView1.Columns["Name"].Visible = true;
            dataGridView1.Columns["Description"].Visible = true;
            dataGridView1.Columns["Price"].Visible = true;
            dataGridView1.Columns["Stock"].Visible = true;
            dataGridView1.Columns["Category"].Visible = true;
            dataGridView1.Columns["Image"].Visible = true;

            dataGridView1.Columns["Category"].HeaderText = "Category";

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_expeditionPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int quantityOnHand = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Stock"].Value);

                int selectedQuantity = Convert.ToInt32(numericUpDown1.Value);

                if (selectedQuantity > quantityOnHand)
                {
                    MessageBox.Show("Selected quantity exceeds available stock.");
                    numericUpDown1.Value = quantityOnHand;
                }

                int productPrice = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["Price"].Value);
                UpdatePrices(productPrice);
            }
        }

        private void txbx_productName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePrices(int productPrice)
        {
            int expeditionPrice;
            if (int.TryParse(txbx_expeditionPrice.Text, out expeditionPrice))
            {
                int selectedQuantity = Convert.ToInt32(numericUpDown1.Value);
                int total = (productPrice * selectedQuantity) + expeditionPrice;
                txbx_total.Text = total.ToString();
            }
        }


        private void cbx_expedition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
                int selectedRowIndex = selectedCell.RowIndex;

                if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
                {
                    string selectedExpedition = cbx_expedition.SelectedValue.ToString();
                    selectedExpeditionID = cbx_expedition.SelectedValue.ToString(); // Store the selected expedition ID

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            string query = "SELECT ETA, Price FROM Expedition WHERE ExpeditionID = @ExpeditionID"; // Retrieve ETA and Price based on ID
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@ExpeditionID", selectedExpeditionID);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string eta = reader["ETA"].ToString();
                                    string expeditionPriceStr = reader["Price"].ToString();

                                    decimal expeditionPrice;
                                    if (decimal.TryParse(expeditionPriceStr, out expeditionPrice))
                                    {
                                        txbx_eta.Text = eta;
                                        txbx_expeditionPrice.Text = expeditionPrice.ToString();

                                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                                        string productPriceStr = selectedRow.Cells["Price"].Value.ToString();

                                        decimal productPrice;
                                        if (decimal.TryParse(productPriceStr, out productPrice))
                                        {
                                            UpdatePrices((int)productPrice);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid product price.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid expedition price.");
                                    }
                                }

                                reader.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }
        }

        private bool isPaymentFormShown = false;

        private void btn_beli_Click(object sender, EventArgs e)
        {
            if (!isPaymentFormShown && dataGridView1.SelectedCells.Count > 0 && cbx_expedition.SelectedValue != null)
            {
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                if (selectedRow.Cells["Name"].Value != null &&
                    selectedRow.Cells["Price"].Value != null &&
                    selectedRow.Cells["Stock"].Value != null &&
                    selectedRow.Cells["Image"].Value != null &&
                    txbx_eta.Text != "" && txbx_expeditionPrice.Text != "" && txbx_total.Text != "")
                {
                    string productName = selectedRow.Cells["Name"].Value.ToString();
                    int productPrice = Convert.ToInt32(selectedRow.Cells["Price"].Value);
                    int productStock = Convert.ToInt32(selectedRow.Cells["Stock"].Value);
                    byte[] productImage = (byte[])selectedRow.Cells["Image"].Value;
                    string expeditionName = cbx_expedition.SelectedValue.ToString();
                    string expeditionETA = txbx_eta.Text;
                    int expeditionPrice = Convert.ToInt32(txbx_expeditionPrice.Text);
                    int selectedQuantity = Convert.ToInt32(numericUpDown1.Value);
                    int totalPrice = Convert.ToInt32(txbx_total.Text);

                    // Generate order ID
                    string orderID = Guid.NewGuid().ToString().Substring(0, 5);

                    // Get current date and time as order date
                    DateTime orderDate = DateTime.Now;

                    // Insert the order into the database
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            string query = @"INSERT INTO [Order] (OrderID, OrderDate, CustomerID, ExpeditionID)
                                     VALUES (@OrderID, @OrderDate, @CustomerID, @ExpeditionID)";
                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@OrderID", orderID);
                            command.Parameters.AddWithValue("@OrderDate", orderDate);
                            command.Parameters.AddWithValue("@CustomerID", CustomerID);
                            command.Parameters.AddWithValue("@ExpeditionID", selectedExpeditionID); // Use the selected expedition ID
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }

                    Payment payment = new Payment(CustomerID)
                    {
                        ProductName = productName,
                        ProductPrice = productPrice,
                        ProductStock = productStock,
                        ProductImage = productImage,
                        ExpeditionName = expeditionName,
                        ExpeditionETA = expeditionETA,
                        ExpeditionPrice = expeditionPrice,
                        SelectedQuantity = selectedQuantity,
                        TotalPrice = totalPrice,
                        OrderID = orderID  // Pass the order ID to the Payment form
                    };

                    ResetTransactionForm(); // Clear the transaction form
                    isPaymentFormShown = true;
                    payment.FormClosed += Payment_FormClosed;
                    payment.Show();
                }
                else
                {
                    MessageBox.Show("Some required data is missing. Please make sure all fields are filled.");
                }
            }
        }

        private void ResetTransactionForm()
        {
            dataGridView1.ClearSelection();
            txbx_productName.Text = "";
            txbx_eta.Text = "";
            txbx_expeditionPrice.Text = "";
            txbx_total.Text = "0";
            numericUpDown1.Value = 0;
            cbx_expedition.SelectedIndex = 0;
            pictureBox1.Image = null;
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            isPaymentFormShown = false;
        }

        private void txbx_eta_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                byte[] imageData = (byte[])row.Cells["Image"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                string productPriceStr = row.Cells["Price"].Value.ToString();
                string productName = row.Cells["Name"].Value.ToString();
                txbx_productName.Text = productName;

                if (int.TryParse(productPriceStr, out int productPrice))
                {
                    txbx_total.Text = productPrice.ToString();
                    UpdatePrices(productPrice);
                }
                else
                {
                    MessageBox.Show("Invalid product price.");
                }
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }

}
