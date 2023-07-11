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
    public partial class Expedition : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public Expedition()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadAdminData();
            LoadExpeditionData();
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

        private void LoadExpeditionData()
        {
            string query = "SELECT * FROM Expedition";

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



        private void btn_add_Click(object sender, EventArgs e)
        {
            string expeditionID = Guid.NewGuid().ToString().Substring(0, 5);

            string query = "INSERT INTO Expedition (ExpeditionID, Name, AdminID, Price, ETA) VALUES (@ExpeditionID, @Name, @AdminID, @Price, @ETA)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExpeditionID", expeditionID);
                    cmd.Parameters.AddWithValue("@Name", txbx_expedition.Text);
                    cmd.Parameters.AddWithValue("@Price", txbx_price.Text);
                    cmd.Parameters.AddWithValue("@ETA", txbx_eta.Text);
                    cmd.Parameters.AddWithValue("@AdminID", cbx_admin.SelectedValue);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully added.");
                        LoadExpeditionData();
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
            string query = "UPDATE Expedition SET Name = @Name, ExpeditionID = @ExpeditionID, Price = @Price, ETA = @ETA, AdminID = @AdminID WHERE ExpeditionID = @ExpeditionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExpeditionID", txbx_search.Text);
                    cmd.Parameters.AddWithValue("@Name", txbx_expedition.Text);
                    cmd.Parameters.AddWithValue("@Price", txbx_price.Text);
                    cmd.Parameters.AddWithValue("@ETA", txbx_eta.Text);
                    cmd.Parameters.AddWithValue("@AdminID", cbx_admin.SelectedValue);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully updated.");
                        LoadExpeditionData();
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
            txbx_eta.Text = string.Empty;
            txbx_expedition.Text = string.Empty;
            txbx_price.Text = string.Empty;
            txbx_search.Text = string.Empty;
            cbx_admin.SelectedIndex = -1;
            cbx_admin.SelectedIndex = -1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Expedition WHERE ExpeditionID = @ExpeditionID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExpeditionID", txbx_search.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data successfully deleted.");
                        LoadExpeditionData();
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
            string query = "SELECT * FROM Expedition WHERE ExpeditionID = @ExpeditionID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ExpeditionID", txbx_search.Text);

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

        private void Expedition_Load(object sender, EventArgs e)
        {

        }
    }
}
