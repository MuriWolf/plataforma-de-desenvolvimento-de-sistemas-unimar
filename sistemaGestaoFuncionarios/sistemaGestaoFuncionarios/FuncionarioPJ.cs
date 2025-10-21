using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestaoFuncionarios
{
    public class FuncionarioPJ : Funcionario
    {
        public int QtdeProjetosEntregues { get; set; } = 0;

        public FuncionarioPJ(string nome, double salarioBase, int qtdeProjetosEntregues) : base(nome, salarioBase) => this.QtdeProjetosEntregues = qtdeProjetosEntregues;

        public override double CalcularSalario()
        {
            double bonus = (this.SalarioBase * 0.1) * this.QtdeProjetosEntregues;
            return this.SalarioBase + bonus;
        }
    }
}
