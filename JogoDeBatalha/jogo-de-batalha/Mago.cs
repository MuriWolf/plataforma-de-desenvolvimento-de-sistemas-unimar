using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_batalha
{
    public class Mago : Personagem
    {
        private const int PORCENTAGEM_MAXIMA_DANO_RECEBIDO = 85;
        private const int PORCENTAGEM_MINIMA_DANO_RECEBIDO = 25;

        public Mago()
        {
            Vida = 80;
        }

        public override double Atacar(bool apresentarMensagem)
        {
            double dano = Nivel * 5 * 3;
            if (apresentarMensagem) ApresentarAtaque(dano);
            return dano;
        }

        public override bool Defender(double danoRecebido, bool apresentarMensagem)
        {
            double danoFinal = danoRecebido * (0.01 * random.Next(PORCENTAGEM_MINIMA_DANO_RECEBIDO, PORCENTAGEM_MAXIMA_DANO_RECEBIDO));
            return base.Defender(danoFinal, apresentarMensagem);
        }

        public override void ApresentarAtaque(double dano)
        {
            Console.WriteLine($"\nATAQUE\nO mago {Nome} realizou um ataque de {Math.Round(dano, 2)} de dano");
            Console.WriteLine("&  --*   --*   --* ");
            Console.WriteLine("|\n|");
        }

        public override void ApresentarDefesa(double danoRecebido)
        {
            Console.WriteLine($"\nDEFESA\nO mago {Nome} conjurou uma magia de defesa. Sofreu {Math.Round(danoRecebido, 2)} de dano. Vida: {Math.Round(Vida, 2)}");
        }

        public override void ApresentarMorte()
        {
            Console.WriteLine($"\nGAME OVER\nO mago {Nome} recebeu um ataque e morreu! RIP");
        }

        public override string ToString()
        {
            return "Classe: mago, " + base.ToString();
        }
    }
}
