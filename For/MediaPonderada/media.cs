using System;
using System.Globalization; 

namespace For
{
    class media
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade de casos: ");
            int qtdCasos = int.Parse(Console.ReadLine());
            double media = 0;
       
            for(int i = 0; i< qtdCasos; i++)
            {
                Console.WriteLine("Digite os valores");
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = ((a * 2) + (b * 3) + (C * 5)) / 10;
                Console.WriteLine(media);

            }
            
            
       
        }
    }
}