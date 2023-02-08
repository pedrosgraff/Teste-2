using System;
using System.Globalization;

namespace For
{
    class inteiros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());
            int divisores = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisores = i;
                    Console.WriteLine(divisores);
                }
            }


        }
    }
}