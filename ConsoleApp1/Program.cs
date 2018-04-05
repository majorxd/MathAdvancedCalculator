using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Código para soma de dois números.

            // Definindo variáveis.
            string a;
            string b;
            double SomaNova;

            // WriteLine é utilizado para escrever o texto no console.
            Console.WriteLine("Digite o primeiro valor");
            // ReadLine é utilizado para ler a variável digitada pelo usuário.
            a = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor");
            b = Console.ReadLine();


            Double.Parse(b);
            Double.Parse(a);


            double bNovo = Double.Parse(b);
            double aNovo = Double.Parse(a);

            // Realizando a soma para dar o resultado.
            SomaNova = aNovo + bNovo;
            Console.WriteLine("Resultado da soma é :" + SomaNova);
            Console.ReadLine();
            // Fim do código.
        }
    }
}
