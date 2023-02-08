using System;
using System.Globalization;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos quartos serão ocupados: ");
            int quantidade = int.Parse(Console.ReadLine());

            Quartos[] estudantes = new Quartos[10];


            for (int i = 0; i < quantidade; i++)
            {
                int calc = i + 1;
                Console.WriteLine("Aluguel #" + calc + ":");
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite o quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                quarto -= 1;
                estudantes[quarto] = new Quartos(nome, email);
            }

            Console.WriteLine("Quartos ocupados");
            for (int i = 0; i < 10; i++)
            {
                int calc = i + 1;
                if (estudantes[i] != null)
                {
                    Console.WriteLine(calc + ": " + estudantes[i].nome + ", " + estudantes[i].email);
                }
            }


        }
    }
}