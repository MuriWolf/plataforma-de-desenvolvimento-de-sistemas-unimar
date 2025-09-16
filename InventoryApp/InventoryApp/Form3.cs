using InventoryLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class Form3 : Form
    {
        private readonly List<Produto> produtos = InventoryManager.ConsultarProdutos();
        private Produto? produtoSelecionado = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataGridView dataGridView = this.dataGridView1;
            BindingSource source = [];

            source.DataSource = this.produtos;
            dataGridView.DataSource = this.produtos;
            dataGridView.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.produtoSelecionado = this.produtos.ElementAt(e.RowIndex);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (this.produtoSelecionado is not null)
            {
                InventoryManager.RemoverProduto(this.produtoSelecionado);
                this.produtoSelecionado = null;
                this.Close();
            }
        }
    }
}
