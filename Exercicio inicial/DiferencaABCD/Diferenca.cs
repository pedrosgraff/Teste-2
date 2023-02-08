using System;
using System.Globalization;
namespace PrimeirosProjetos
{
    class inteiros
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor A");
            double a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor B");
            double b = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor C");
            double c = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor D");
            double d = double.Parse(Console.ReadLine());

            double diferenca = a * b - c * d;
            Console.WriteLine("Diferenca: " + diferenca);


        }
    }
}