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
    public partial class FormLogin : Form
    {
        private SqlConnection connection;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public FormLogin()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_daftar_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.TopLevel = false;
            register.FormBorderStyle = FormBorderStyle.None;
            register.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(register);

            register.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.TopLevel = false;
            login.FormBorderStyle = FormBorderStyle.None;
            login.Dock = DockStyle.Fill;

            panel1.Controls.Clear();

            panel1.Controls.Add(login);

            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

