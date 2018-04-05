using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código para dizer se o número digitado é ímpar ou par.

            // WriteLine é utilizado para escrever o  texto no console.
            Console.WriteLine("Digite o número que deseja:");
            double VarN = Convert.ToDouble(Console.ReadLine());

            // Realiza a divisão.
            if (VarN % 2 == 0)
            {
                // Se módulo for igual a 0 (zero) o número digitado é par.
                Console.WriteLine("O número digitado é par");
            }
            else
            {
                // Se módulo for igual a 0 (zero) o número digitado é par.
                Console.WriteLine("O número digitado é impar");
            }
            // Console.ReadKey é utilizado para esperar um enter finalizar o console.
            Console.ReadKey();

            // Fim do código.
        }
    }
}

