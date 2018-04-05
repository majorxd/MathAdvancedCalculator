using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao
{
    class Equacao2Grau
    {
        public static void Main()
        {
            // Código para calcular uma equação do segundo grau.

            // Definindo variáveis.
            double a;
            double b;
            double c;
            double RaizUm;
            double RaizDois;
            double DeltaUm;

            // WriteLine é utilizado para escrever o  texto no console.
            Console.WriteLine("Digite o valor de 'a': ");
            a = Double.Parse(Console.ReadLine()); // 
            Console.WriteLine("Digite o valor de 'b': ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de 'c': ");
            c = Double.Parse(Console.ReadLine());

            DeltaUm = (Math.Pow(b, 2)) - (4 * a * c);
            if (DeltaUm < 0)
            {
                Console.Write("Delta menor que Zero não existe Raiz. Tecle Qualquer Tecla para Sair");

            }
            else
            {
                RaizUm = (-(b) + Math.Sqrt(DeltaUm)) / (2 * a);
                RaizDois = (-(b) - Math.Sqrt(DeltaUm)) / (2 * a);

                Console.WriteLine("o resultado da equação " + a + "x²+" + b + "x+" + c + "=0 é:" + "\n" + "x¹:" + RaizUm + "\n" + "x²:" + RaizDois + ".");
                Console.WriteLine("Digite Qualquer Tecla para sair!");
            }
            // Console.ReadKey é utilizado para esperar um enter finalizar o console.
            Console.ReadKey();

  
            // Fim do código.


        }
    }
}