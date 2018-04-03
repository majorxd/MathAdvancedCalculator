using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;

            Console.WriteLine("Digite o número que será fatorial:");
            Number = int.Parse(Console.ReadLine());

            int Fatorial;

            Fatorial = Number;
            for (int i = Number - 1; i > 1; i--)
            {
                Fatorial *= i;
            }

            Console.WriteLine("Valor de " + Number + " fatorial é: " + Fatorial);

            Console.Read();
            // Fim do código.
        }
    }
}

