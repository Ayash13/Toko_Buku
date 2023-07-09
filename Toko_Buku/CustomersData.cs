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
    public partial class CustomersData : Form
    {
        private SqlConnection connection;
        private SqlCommand command;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public CustomersData()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
