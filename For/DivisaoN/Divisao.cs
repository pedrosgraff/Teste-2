using System;
using System.Globalization;

namespace For
{
    class divisao
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para dividir com os demais");
            int n = int.Parse(Console.ReadLine());
            double tela = 0;
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = int.Parse(s[0], CultureInfo.InvariantCulture);
                int b = int.Parse(s[1], CultureInfo.InvariantCulture);

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {
                    tela = a / b;
                    Console.WriteLine(tela);

                }


            }
            
        }
    }
}