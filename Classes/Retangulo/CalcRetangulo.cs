using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do rentangulo: ");
            ret1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area : " + ret1.Area());
            Console.WriteLine("Perimetro : " + ret1.Perimetro());
            Console.WriteLine("Diagonal : " + ret1.Diagonal());

        }
    }
}