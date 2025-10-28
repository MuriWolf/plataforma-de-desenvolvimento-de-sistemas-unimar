namespace jogo_de_batalha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago mago1 = new() { Nivel = 3, Nome = "Wousys, the black wizard" };
            Guerreiro guerreiro1 = new() { Nivel = 3, Nome = "Baldur, the harsh" };
            Arqueiro arqueiro1 = new() { Nivel = 3, Nome = "Leghollas, the archer" };
            TotalizadorDeDano totalizadorDeDano = new();
            Random random = new();

            List<Personagem> personagens = [];

            personagens.Add(mago1);
            personagens.Add(guerreiro1);
            personagens.Add(arqueiro1);

            while (personagens.Count >= 2)
            {
                Console.WriteLine("\n===========================================================");
                // Lista com indexes criado para eu poder manipulá-los.
                List<int> indicesPersonagens = Enumerable.Range(0, personagens.Count).ToList();

                int indicePersonagemAtacante = random.Next(indicesPersonagens.Count);
                double danoAtaque = personagens[indicesPersonagens[indicePersonagemAtacante]].Atacar(true);
                totalizadorDeDano.RegistrarAtaque(danoAtaque);

                // Índice removido para ter change do atacante atacar a si mesmo.
                indicesPersonagens.RemoveAt(indicePersonagemAtacante);
                Thread.Sleep(300);
                

                int indicePersonagemAtacado = random.Next(indicesPersonagens.Count);
                bool defesaBemSucedida = personagens[indicesPersonagens[indicePersonagemAtacado]].Defender(danoAtaque, true);

                
                if (!defesaBemSucedida) personagens.RemoveAt(indicesPersonagens[indicePersonagemAtacado]);

                string mensagemInput = personagens.Count < 2 ? "\nPrecione qualquer tecla para ver o resultado..." : "\nPrecione qualquer tecla para o próximo duelo...";

                Console.WriteLine(mensagemInput);
                Console.ReadKey();
            }

            Console.WriteLine("\n===========================================================");
            Console.WriteLine("SÚMARIO DA BATALHA: ");
            Console.WriteLine($"\nTotal de dano emitido: {totalizadorDeDano.DanoTotal}");
            Console.WriteLine($"Vencedor: {personagens[0].ToString()}");
            Console.WriteLine("===========================================================");
        }
    }
}
