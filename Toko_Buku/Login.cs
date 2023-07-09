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
    public partial class Login : Form
    {
        private SqlConnection connection;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public Login()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            string username = txbx_username.Text;
            string password = txbx_password.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Admin
                string adminQuery = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                using (SqlCommand adminCmd = new SqlCommand(adminQuery, conn))
                {
                    adminCmd.Parameters.AddWithValue("@Username", username);
                    adminCmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        int adminResult = (int)adminCmd.ExecuteScalar();

                        if (adminResult > 0)
                        {
                            form_menu menuAdmin = new form_menu();
                            menuAdmin.Show();
                            this.Hide();
                            return;
                        }
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

                // Customers
                string userQuery = "SELECT COUNT(*) FROM Customer WHERE Name = @Name AND Password = @Password";
                using (SqlCommand userCmd = new SqlCommand(userQuery, conn))
                {
                    userCmd.Parameters.AddWithValue("@Name", username);
                    userCmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        int userResult = (int)userCmd.ExecuteScalar();

                        if (userResult > 0)
                        {
                            CustomersForm customers = new CustomersForm();
                            customers.Show();
                            this.Hide();
                            return;
                        }
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

                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {

        }

        private void txbx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbx_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
