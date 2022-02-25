using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int coluna = 50;
            int linha = 10;

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");

            }
            Console.ReadKey();

        }
    }
}
