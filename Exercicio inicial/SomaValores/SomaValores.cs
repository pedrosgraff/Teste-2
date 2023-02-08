using System;
namespace SomaValores
{
    class soma
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("Soma: " + soma);
        }
    }
}