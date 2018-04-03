using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            // Código para soma de dois números.

            // Definindo variáveis.
            string a;
            double Porcento;

            // WriteLine é utilizado para escrever o  texto no console.
            Console.WriteLine("Digite o valor que deseja calcular: ");
            // ReadLine é utilizado para ler a variável digitada pelo usuário.
            a = Console.ReadLine();

            Double.Parse(a);

            double aNovo = Double.Parse(a);
            // Realizando a multiplicação para definir o resultado.
            Porcento = aNovo * 0.1;
            Console.WriteLine("Resultado é :" + Porcento);
            Console.ReadLine();

            // Fim do código.
        }
    }
}
