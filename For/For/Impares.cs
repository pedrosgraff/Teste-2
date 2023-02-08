using System;
using System.Globalization;

namespace For
{
    class impares
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite de 1 a 1000");
            int numero = int.Parse(System.Console.ReadLine());

            for (int i = 0; i <= numero; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}