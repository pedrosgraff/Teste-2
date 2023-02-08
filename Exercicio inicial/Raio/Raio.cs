using System;
using System.Globalization;
namespace PrimeirosProjetos
{
    class raio
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double calcRaio = pi * raio * raio;

            Console.WriteLine(calcRaio.ToString("F2"));
        }
    }
}