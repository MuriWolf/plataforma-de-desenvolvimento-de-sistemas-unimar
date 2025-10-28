using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_batalha
{
    public class Guerreiro : Personagem
    {
        private const int PORCENTAGEM_MAXIMA_DANO_RECEBIDO = 70;
        private const int PORCENTAGEM_MINIMA_DANO_RECEBIDO = 20;

        public override double Atacar(bool apresentarMensagem)
        {
            double dano = Nivel * 5 * 2;
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
            Console.WriteLine($"\nATAQUE\nO guerreiro {Nome} realizou um ataque de {Math.Round(dano, 2)} de dano");
            Console.WriteLine("—|=====>");
        }

        public override void ApresentarDefesa(double danoRecebido)
        {
            Console.WriteLine($"\nDEFESA\nO guerreiro {Nome} se defendeu com seu escudo. Sofreu {Math.Round(danoRecebido, 2)} de dano. Vida: {Math.Round(Vida, 2)}");
        }

        public override void ApresentarMorte()
        {
            Console.WriteLine($"\nGAME OVER\nO guerreiro {Nome} recebeu um ataque e morreu! RIP");
        }

        public override string ToString()
        {
            return "Classe: guerreiro, " + base.ToString();
        }
    }
}
