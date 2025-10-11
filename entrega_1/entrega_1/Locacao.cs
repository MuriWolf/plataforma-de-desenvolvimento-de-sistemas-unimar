using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_1
{
    public class Locacao
    {
        public Cliente Cliente { get; private set; }
        public Filme Filme { get; private set; }

        public Locacao(Cliente cliente, Filme filme, int quantidade)
        {
            if (quantidade > filme.UnidadesDisponiveis)
            {
                throw new ArgumentException("Quantidade de filmes para alugar é maior que a quantidade disponível.");
            }
            this.Cliente = cliente;
            this.Filme = filme;
            filme.UnidadesDisponiveis -= quantidade;
        }
    }
}
