using System;
using System.Globalization;

namespace For
{
    class positivo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());
            int linha = 1;

            for (int i = 1; i <= n; i++)
            {
                
                int cubo = i * i * i;
                int quadrado = i * i;
                Console.WriteLine(linha +" " + quadrado + " " + cubo);
                linha++;

            }
        }
    }
}