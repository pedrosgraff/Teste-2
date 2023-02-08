using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p1.idade = int.Parse(Console.ReadLine());



            Console.WriteLine("Digite o nome: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if(p1.idade < p2.idade)
            {
                Console.WriteLine(p2.nome + " é a mais velha");
            }else if(p1.idade == p2.idade)
            {
                Console.WriteLine("Idades iguais");
            }
            else
            {
                Console.WriteLine(p1.nome + " é mais velha");
            }
        }
    }
}