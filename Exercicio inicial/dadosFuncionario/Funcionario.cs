using System;
using System.Globalization;

namespace PrimeirosProjetos
{
    class funcionario
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero do funcionario");
            double numero = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite as horas trabalhadas do funcionario");
            double horas = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o salario do funcionario");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Numero : " + numero);
            System.Console.WriteLine("Salario: " + (horas * salario).ToString("F2"), CultureInfo.InvariantCulture);
                 
        }
    }
}