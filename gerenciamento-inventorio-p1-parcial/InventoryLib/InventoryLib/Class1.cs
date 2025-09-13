namespace InventoryLib
{
    public class InventoryManager
    {
        private static List<Produto> _produtos = [];

        public static void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public static void RemoverProduto(Produto produto)
        {
            _produtos.Remove(produto);
        }


        public static List<Produto> ConsultarProdutos()
        {
            return _produtos;
        }

        public static int ConsultarEstoque()
        {
            return _produtos.Sum((produto) => produto.Quantidade);
        }
    }

    public class Produto
    {
        public required string Nome { get; set;  }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
    }
}

