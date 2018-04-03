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
            // Código para porcentagem de um número.

            // Definindo variáveis.
            string a;
            string b;
            double c;
            double Porcentagem;

            // WriteLine é utilizado para escrever o  texto no console.
            Console.WriteLine("Digite o que valor que deseja: ");
            // ReadLine é utilizado para ler a variável digitada pelo usuário.
            a = Console.ReadLine();

            Console.WriteLine("Digite a porcentagem que deseja: ");
            b = Console.ReadLine();

            Double.Parse(a);
            Double.Parse(b);

            double bNovo = Double.Parse(a);
            double aNovo = Double.Parse(b);
            // Realizando divisão.
            bNovo = bNovo / 100;
            c = bNovo;
            // Realizando a multiplicação para dar o resultado.
            Porcentagem = aNovo * c;
            Console.WriteLine("Resultado é :" + Porcentagem);
            Console.ReadLine();
            // Fim do código.
        }
    }
}