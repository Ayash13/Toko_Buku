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
    public partial class ManageProduct : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        private string connectionString = "Data Source=DESKTOP-AJFQKR8\\AYASH;Initial Catalog=Toko_Buku;Persist Security Info=True;User ID=sa;Password=Rahasiatau123";
        public ManageProduct()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }

        private void btn_chooseImage_Click(object sender, EventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {

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
    }
}
