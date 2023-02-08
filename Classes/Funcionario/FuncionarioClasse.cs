using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes

{
    internal class FuncionarioClasse
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentaSalario(double porcentagem)
        {
            return (SalarioBruto * (porcentagem / 100)) + SalarioLiquido();
        }
    }
}
