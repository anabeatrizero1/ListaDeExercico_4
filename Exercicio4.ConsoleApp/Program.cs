using System;
/*
Desenvolver um algoritmo que leia 5 valores inteiros e calcule e escreva a
média aritmética dos valores lidos, a quantidade de valores positivos e a
quantidade de valores negativos.
*/

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] valores = new int [5];
            int media = 0;
            int positivos = 0, negativos = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                Console .WriteLine ("Digite o {0}º valor", i+1);
                valores[i] = Convert.ToInt32 (Console.ReadLine());
                media = media + valores[i];
                if (valores[i] >= 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }
            }
            media = media + Convert.ToInt32 (valores.Length);
            Console.WriteLine("A Média Aritmética é: " + media);
            Console.WriteLine("A quantidade de valores positivos é: " + positivos);
            Console.WriteLine("A quantidade de valores negativos é: " + negativos); 
        }
    }
}
