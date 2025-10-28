using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_batalha
{
    public class TotalizadorDeDano
    {
        public double DanoTotal { get; private set; } = 0;

        public void RegistrarAtaque(double dano)
        {
            DanoTotal += dano;
        }
    }
}
