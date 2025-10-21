namespace sistemaGestaoFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuncionarioCLT funcionarioCLT = new("Joao", 2500);
            FuncionarioPJ funcionarioPJ = new("Maria", 3500, 3);
            Estagiario estagiario = new("Jose", 1500);

            List<Funcionario> funcionarios = new();

            funcionarios.Add(funcionarioCLT);
            funcionarios.Add(funcionarioPJ);
            funcionarios.Add(estagiario);

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Nome} tem salário total {funcionario.CalcularSalario()}");
            }
        }
    }
}
