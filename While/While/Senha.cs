using System;
using System.Globalization;

namespace While
{
    class senha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma senha valida: ");
            int tentativa = int.Parse(Console.ReadLine());
            int senha = 2002;


            while (senha != tentativa)
            {
                Console.WriteLine("Senha invalida");
                Console.WriteLine("Digite uma senha valida: ");
                tentativa = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta");
        }
    }
}