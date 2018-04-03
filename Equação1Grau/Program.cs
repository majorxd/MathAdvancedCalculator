using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equação_1_Grau
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código para calculo de uma equação do 1° grau.

            // WriteLine é utilizado para escrever o texto no console.
            // Inserindo valor de A.
            Console.WriteLine("Digite o valor de A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            // Inserindo valor de B.
            Console.WriteLine("Digite o valor de B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            // Definindo variável da resposta.
            double x;
            // Cálculo da equação.
            x = -(b / a);

            Console.WriteLine("O valor de x na equação é: " + x);
            // Console.ReadKey é utilizado para esperar um enter finalizar o console.
            Console.ReadKey();

            // Fim do código.
        }
    }
}
