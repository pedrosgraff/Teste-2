using System;
using System.Globalization;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tamanho da matriz: ");
            string[] tamanhoMatriz = Console.ReadLine().Split(' ');
            int linha = int.Parse(tamanhoMatriz[0]);
            int coluna = int.Parse(tamanhoMatriz[1]);

            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite o numero que deseja procurar: ");
            int x = int.Parse(Console.ReadLine());
            int countL = 0;
            
            for (int i = 0; i < linha; i++)
            {
                int countC = 0;
                for (int j = 0; j < coluna; j++)
                {
                    
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position: " + countL + ", " + countC);
                        Console.WriteLine("Left: " + matriz[i, (j - 1)]);
                        Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        Console.WriteLine("Down: " + matriz[(i+1), j]);
                    }
                    countC++;
                }
                countL++;
                countL++;
            }

        }
    }
}