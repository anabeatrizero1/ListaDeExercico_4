using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int coluna = 50;
            int linha = 10;

            for (int i = 0; i < linha; i++)
            {
                if (linha % 2 == 0)
                {
                    for (int j = 0; j < coluna; j++)
                    {
                        Console.Write("A");
                    }
                    Console.WriteLine("\n");
                }
                else
                {
                    for (i = 0; i < coluna; i++)
                    {
                        Console.WriteLine("B");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
