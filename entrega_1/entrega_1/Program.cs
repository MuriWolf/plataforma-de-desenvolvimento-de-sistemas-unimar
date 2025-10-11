namespace entrega_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme01 = new("Scarface", "romance", 20);
            Filme filme02 = new("Singing in the rain", "sci-fi terror", 10);

            Cliente cliente01 = new("Ronaldinho");
            Cliente cliente02 = new("Johann Sebastian Bach");

            List<Locacao> locacoes = [];

            Locacao locacao01 = new(cliente01, filme01, 4);
            Locacao locacao02 = new(cliente01, filme02, 2);
            Locacao locacao03 = new(cliente02, filme01, 3);

            locacoes.Add(locacao01);
            locacoes.Add(locacao02);
            locacoes.Add(locacao03);

            Console.WriteLine("Relação clientes e filmes alugados: ");
            Console.WriteLine("Cliente, Filme");
            foreach (var locacao in locacoes)
            {
                Console.WriteLine($"{locacao.Cliente.Nome}, {locacao.Filme.Titulo}");
            }

        }
    }
}
