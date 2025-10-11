using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entrega_1
{
    public class Filme
    {
        public string Titulo { get; private set; }
        public string Genero { get; set; }
        public int UnidadesDisponiveis { get; set; }

        public Filme(string titulo, string genero, int unidadesDisponiveis)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.UnidadesDisponiveis = unidadesDisponiveis;
        }
    }
}
