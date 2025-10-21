using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaGestaoFuncionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBase { get; set; }

        protected Funcionario(string nome, double salarioBase)
        {
            this.Nome = nome;
            this.SalarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return this.SalarioBase;
        }

        public override string ToString()
        {
            return $"{this.Nome} possui o salário base: {this.SalarioBase}";
        }
    }
}
