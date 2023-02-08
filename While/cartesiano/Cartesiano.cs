using System;
using System.Globalization;

namespace While
{
    class planoCartesiano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            
                while (x != 0 || y != 0)
                {
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("Primeiro");
                    }
                    else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("Quarto");
                    }
                    else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("Terceiro");
                    }
                    else if( x <0 && y > 0)
                    {
                        Console.WriteLine("Segundo");
                    }
                    Console.WriteLine("Digite as coordenadas");
                    x = int.Parse(Console.ReadLine());
                    y = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}