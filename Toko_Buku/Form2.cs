using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Buku
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_transaction_Click(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct();
            manageProduct.TopLevel = false;
            manageProduct.FormBorderStyle = FormBorderStyle.None;
            manageProduct.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();

            panelContent.Controls.Add(manageProduct);

            manageProduct.Show();
        }

        private void btn_expedition_Click(object sender, EventArgs e)
        {
            Expedition expedition = new Expedition();
            expedition.TopLevel = false;
            expedition.FormBorderStyle = FormBorderStyle.None;
            expedition.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();

            panelContent.Controls.Add(expedition);

            expedition.Show();
        }

        private void btn_transactionHistory_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.TopLevel = false;
            category.FormBorderStyle = FormBorderStyle.None;
            category.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();

            panelContent.Controls.Add(category);

            category.Show();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
