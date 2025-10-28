using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_batalha
{

    public class Personagem
    {
        
        public string Nome { get; set; } = "";
        public int Nivel { get; set; }
        public double Vida { get; protected set; } = 100;
        protected Random random = new();

        public virtual double Atacar(bool apresentarMensagem)
        {
            double dano = Nivel * 5;
            if (apresentarMensagem) ApresentarAtaque(dano);
            return dano;
        }

        public virtual bool Defender(double danoRecebido, bool apresentarMensagem)
        {
            Vida -= danoRecebido;

            if (Vida <= 0) {
                if (apresentarMensagem) ApresentarMorte();
                return false;
            }
            else
            {
                if (apresentarMensagem) ApresentarDefesa(danoRecebido);
                return true;
            }
        }

        public virtual void ApresentarAtaque(double dano)
        {
            Console.WriteLine($"\nATAQUE\n{Nome} realizou um ataque de {Math.Round(dano, 2)} de dano!");
        }

        public virtual void ApresentarDefesa(double danoRecebido)
        {
            Console.WriteLine($"\nDEFESA\n{Nome} sofreu {Math.Round(danoRecebido, 2)} de dano. Vida: {Math.Round(Vida, 2)}");
        }

        public virtual void ApresentarMorte()
        {
            Console.WriteLine($"\nGAME OVER\n{Nome} recebeu um ataque e morreu!");
        }

        public override string ToString()
        {
            return $"\nNome: {Nome}, Nivel: {Nivel}, Vida: {Math.Round(Vida, 2)}";
        }
    }
}
