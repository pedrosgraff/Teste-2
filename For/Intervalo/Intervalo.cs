using System;
using System.Globalization;

namespace For
{
    class intervalo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int quantidade = int.Parse(Console.ReadLine());
            int x = 0;
            int a = 0;
            int b = 0;

            for (int i = 0; i < quantidade; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    a++;
                }
                else
                {
                    b++;
                }
            }

            Console.WriteLine(a + " in");
            Console.WriteLine(b + " out");

        }
    }
}