using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equacao
{
    class euqacaoSegundoGrau
    {
        public static void Main()
        {
            double a, b, c, raizUm, raizDois, deltaUm;
            Console.Write("ztDigite o valor de 'a': ");
            a = Double.Parse(Console.ReadLine());
            Console.Write("ztDigite o valor de 'b': ");
            b = Double.Parse(Console.ReadLine());
            Console.Write("ztDigite o valor de 'c': ");
            c = Double.Parse(Console.ReadLine());

            deltaUm = (Math.Pow(b, 2)) - (4 * a * c);
            if (deltaUm < 0)
            {
                Console.Write("Delta menor que Zero não existe Raiz. Tecle Qualquer Tecla para Sair");

            }
            else
            {
                raizUm = (-(b) + Math.Sqrt(deltaUm)) / (2 * a);
                raizDois = (-(b) - Math.Sqrt(deltaUm)) / (2 * a);

                Console.WriteLine("o resultado da equação " + a + "x²+" + b + "x+" + c + "=0 é:"+ "\n" + "x¹:" + raizUm  +"\n"+"x²:"  + raizDois + ".");
                Console.Write("Digite Qualquer Tecla para sair!");
            }
            Console.ReadKey();



        }
    }
}