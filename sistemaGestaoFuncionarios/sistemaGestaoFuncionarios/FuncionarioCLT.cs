using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestaoFuncionarios
{
    public class FuncionarioCLT : Funcionario
    {

        public FuncionarioCLT(string nome, double salarioBase) : base(nome, salarioBase)
        {
        }

        public override double CalcularSalario()
        {
            return base.CalcularSalario();
        }
    }
}
