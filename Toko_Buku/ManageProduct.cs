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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Toko_Buku
{
    public partial class ManageProduct : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string imagePath;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public ManageProduct()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadProductData();
            LoadAdminData();
            LoadCategoryData();
        }

        private void LoadProductData()
        {
            string query = "SELECT * FROM Product";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
        }

        private void LoadAdminData()
        {
            try
            {
                connection.Open();

                string query = "SELECT AdminID, Username FROM Admin";
                command = new SqlCommand(query, connection);
                DataTable adminTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(adminTable);

                cbx_admin.DisplayMember = "Username";
                cbx_admin.ValueMember = "AdminID";

                cbx_admin.DataSource = adminTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadCategoryData()
        {
            try
            {
                connection.Open();

                string query = "SELECT CategoryID, Name FROM Category";
                command = new SqlCommand(query, connection);
                DataTable categoryTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(categoryTable);

                cbx_category.DisplayMember = "Name";
                cbx_category.ValueMember = "CategoryID";

                cbx_category.DataSource = categoryTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);
                txbx_pictSource.Text = imagePath;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            string productID = Guid.NewGuid().ToString().Substring(0, 5);

            string query = "INSERT INTO Product (ProductID, Name, Description, Price, Stock, CategoryID, AdminID, Image) VALUES (@ProductID, @Name, @Description, @Price, @Stock, @CategoryID, @AdminID, @Image)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@Name", txbx_product.Text);
                    cmd.Parameters.AddWithValue("@Description", txbx_description.Text);
                    cmd.Parameters.AddWithValue("@Price", txbx_price.Text);
                    cmd.Parameters.AddWithValue("@Stock", txbx_stock.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", cbx_category.SelectedValue);
                    cmd.Parameters.AddWithValue("@AdminID", cbx_admin.SelectedValue);
                    cmd.Parameters.AddWithValue("@Image", File.ReadAllBytes(imagePath));

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added.");
                        LoadProductData();
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
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            string query = "UPDATE Product SET Name = @Name, Description = @Description, Price = @Price, Stock = @Stock, CategoryID = @CategoryID, AdminID = @AdminID, Image = @Image WHERE ProductID = @ProductID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", txbx_search.Text);
                    cmd.Parameters.AddWithValue("@Name", txbx_product.Text);
                    cmd.Parameters.AddWithValue("@Description", txbx_description.Text);
                    cmd.Parameters.AddWithValue("@Price", txbx_price.Text);
                    cmd.Parameters.AddWithValue("@Stock", txbx_stock.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", cbx_category.SelectedValue);
                    cmd.Parameters.AddWithValue("@AdminID", cbx_admin.SelectedValue);
                    cmd.Parameters.AddWithValue("@Image", File.ReadAllBytes(imagePath));

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully updated.");
                        LoadProductData();
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
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            txbx_product.Text = string.Empty;
            txbx_description.Text = string.Empty;
            txbx_price.Text = string.Empty;
            txbx_stock.Text = string.Empty;
            txbx_pictSource.Text = string.Empty;
            cbx_category.SelectedIndex = -1;
            cbx_admin.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Product WHERE ProductID = @ProductID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductID", txbx_search.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                        LoadProductData();
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
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Product WHERE ProductID = @idProduct";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProduct", txbx_search.Text);

                    try
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
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
        }

        private void txbx_product_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_category.SelectedValue != null)
            {
                string categoryID = cbx_category.SelectedValue.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void txbx_pictSource_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txbx_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbx_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_admin.SelectedValue != null)
            {
                string adminID = cbx_admin.SelectedValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
