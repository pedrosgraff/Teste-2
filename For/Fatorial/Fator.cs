using System;
using System.Globalization;

namespace For
{
    class fatorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());
            int calc = 0;

            if (n == 0)
            {
                Console.WriteLine("Fator = 1 ");
            }
            else
            {
                for (int i = 1; i < n; i++)
                {
                    calc += n * (n - i);
                }
                Console.WriteLine(calc);

            }
        }
    }
}