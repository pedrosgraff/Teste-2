using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Aluno a1= new Aluno();
            Console.WriteLine("Nome do aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres notas do aluno: ");
            a1.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final: " + a1.mostraNota());

            if(a1.mostraNota() < 60)
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltou: " + a1.faltaPonto() + " pontos.");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}