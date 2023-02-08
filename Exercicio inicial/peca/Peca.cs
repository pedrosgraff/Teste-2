using System;
using System.Globalization;

namespace PrimeirosProjetos
{
    class peca
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o numero da peca1");
            double cod1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero de pecas 1");
            double numero1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da peca 1");
            double vlr1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Digite o numero da peca 2");
            double cod2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero de pecas 2");
            double numero2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da peca 2");
            double vlr2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcCompra = (numero1 * vlr1) + (numero2 * vlr2);

            System.Console.WriteLine("Total a pagar: " + calcCompra);
        }
    }
}