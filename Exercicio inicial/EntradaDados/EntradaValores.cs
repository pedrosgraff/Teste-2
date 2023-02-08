using System;
using System.Globalization;

namespace EntradaDados
{
    class EntradaValores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa: ");
            int qtdQuartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');
            string primeiroNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2],CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(idade);   
            Console.WriteLine(altura);
            Console.WriteLine(nome);


        }
    }
}

    