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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = this.textBoxNome.Text;
            bool sucessPreco = Double.TryParse(this.textBoxPreco.Text, out double preco);
            bool sucessQtde = Int32.TryParse(this.textBoxQuantidade.Text, out int quantidade);

            if (sucessPreco && sucessQtde)
            {
                Produto novoProduto = new() { Nome = nome, Preco = preco, Quantidade = quantidade };

                InventoryManager.AdicionarProduto(novoProduto);

                this.Close();
            }
        }
    }
}
