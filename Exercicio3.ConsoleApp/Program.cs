using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal horaAtual;
            Console.WriteLine("Digite a hora atual!");
            horaAtual = Convert.ToDecimal(Console.ReadLine());

            if (horaAtual > 0 && horaAtual < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horaAtual >= 12 && horaAtual < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else if (horaAtual < 24)
            {
                Console.WriteLine("Boa noite!");
            }
            else
            {
                Console.WriteLine("A hora digitada é inválida!");

            }
            Console.ReadLine();
        }
    }
}
