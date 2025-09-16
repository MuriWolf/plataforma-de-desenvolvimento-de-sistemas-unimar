using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryLib;

namespace InventoryApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Produto> produtos = InventoryManager.ConsultarProdutos();

            DataGridView dataGridView = this.dataGridView1;
            BindingSource source = [];

            source.DataSource = produtos;
            dataGridView.DataSource = produtos;

            this.labelTotalProdutosEstoque.Text = InventoryManager.ConsultarEstoque().ToString();
        }
    }
}
