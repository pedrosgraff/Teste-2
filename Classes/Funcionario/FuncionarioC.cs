using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioClasse f1 = new FuncionarioClasse();
            Console.WriteLine("Nome:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Salário Bruto");
            f1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Imposto");
            f1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + f1.Nome + " $ " + f1.SalarioLiquido());
            Console.WriteLine("Digite a porcentagem de aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados atualizados: " + f1.Nome + ", " + f1.AumentaSalario(porcentagem));

        }
    }
}