using CalcSalario;
using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Digite um nome: ");
            f1.nome = Console.ReadLine();

            Console.WriteLine("Digite um salario: ");
            f1.salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um nome: ");
            f2.nome = Console.ReadLine();

            Console.WriteLine("Digite um salario: ");
            f2.salario = int.Parse(Console.ReadLine());

            double media = (f2.salario + f1.salario) / 2;
            Console.WriteLine(media);

        }
    }
}