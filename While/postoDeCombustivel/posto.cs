using System;
using System.Globalization;

namespace While
{
    class postoDeCombustivel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para Alcool, 2 para Gasolina e 3 para Diesel");
            int tipo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                    Console.WriteLine("Digite 1 para Alcool, 2 para Gasolina e 3 para Diesel");
                    tipo = int.Parse(Console.ReadLine());
                }
                else if (tipo == 2)
                {
                    gasolina++;
                    Console.WriteLine("Digite 1 para Alcool, 2 para Gasolina e 3 para Diesel");
                    tipo = int.Parse(Console.ReadLine());
                }
                else
                {
                    diesel++;
                    Console.WriteLine("Digite 1 para Alcool, 2 para Gasolina e 3 para Diesel");
                    tipo = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}