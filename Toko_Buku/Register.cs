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
    public partial class Register : Form
    {
        private SqlConnection connection;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public Register()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            string customerID = Guid.NewGuid().ToString().Substring(0, 5);

            string query = "INSERT INTO Customer (CustomerID, Name, Address, PhoneNumber, Email, Password) VALUES (@CustomerID, @Name, @Address, @PhoneNumber, @Email, @Password)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@Name", txbx_username.Text);
                    cmd.Parameters.AddWithValue("@Address", txbx_alamat.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txbx_noTelp.Text);
                    cmd.Parameters.AddWithValue("@Email", txbx_email.Text);
                    cmd.Parameters.AddWithValue("@Password", txbx_password.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
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
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
