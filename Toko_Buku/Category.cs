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
    public partial class Category : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";

        public Category()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadAdminData();
            LoadCategoryData();
        }

        private void LoadCategoryData()
        {
           string query = "SELECT * FROM Category";

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


        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }

        private void txbx_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txbx_category_TextChanged(object sender, EventArgs e)
        {

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

        private void cbx_admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_admin.SelectedValue != null)
            {
                string adminID = cbx_admin.SelectedValue.ToString();
            }
        }
    }
}
