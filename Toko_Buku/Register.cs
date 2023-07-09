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

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {

        }
    }
}
