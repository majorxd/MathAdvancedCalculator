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
            // Código para fazer o fatorial de um número.
            // Declaração de variável.
            int Number;
            int Fatorial;

            // WriteLine é utilizado para escrever o texto no console.
            Console.WriteLine("Digite o número que será fatorial:");
            Number = int.Parse(Console.ReadLine());

            Fatorial = Number;
            
            // Comando de repetição.
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

