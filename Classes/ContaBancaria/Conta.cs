using ContaBancaria;
using System;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta n1;

            Console.Write("Entre o número da conta: ");
            int nConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Deposito S ou N? ");
            char existeDeposito = char.Parse(Console.ReadLine());

            if (existeDeposito == 'S' || existeDeposito == 's')
            {
                Console.Write("Digite o valor: ");
                double deposito = double.Parse(Console.ReadLine());
                n1 = new Conta(nConta, titular, deposito);


            }
            else
            {
                n1 = new Conta(nConta, titular);
            }

            Console.Write("Dados da Conta: ");
            Console.WriteLine(n1.ToString());

            Console.Write("Entre com um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            n1.Deposito(quantia);

            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(n1.ToString());


            Console.Write("Entre com um valor para saque: ");
            quantia = double.Parse(Console.ReadLine());
            n1.Saque(quantia);


            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(n1.ToString());



        }
    }
}