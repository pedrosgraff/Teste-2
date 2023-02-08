using System;
using System.Globalization;

namespace PrimeirosProjetos
{
    class pontoFlutuante
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o valor de A, B e C: ");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);


            double triangulo =  a * c / 2; 
            double circulo = (c * c )*  Math.PI;
            double trapezio = (a + b) / 2 * c;
            double quadrado = b * 4;
            double retangulo = a * b ;

            System.Console.WriteLine("Triangulo " + triangulo.ToString("F2"), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Circulo " + circulo.ToString("F2"), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Trapezio " + trapezio.ToString("F2"), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Quadrado " + quadrado.ToString("F2"), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Retangulo " + retangulo.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}