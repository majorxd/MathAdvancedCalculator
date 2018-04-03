using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
	class Program
	{


		public static void Main()
		{
			// Código para dizer o valor da sequência de  Fibonacci pela sua posição.
			// WriteLina é utilizado para escrever o texto no console.
			Console.WriteLine("Digite o termo ao qual você deseje o número Fibonacci: ");
			int number = Convert.ToInt32(Console.ReadLine());


			Console.WriteLine(Fibonacci(number));

			// ReadKey é utilizado para esperar um enter finalizar o console.
			Console.ReadKey();
		}

		static int Fibonacci(int x) // A variável x assume o valor da varíável number.
		{
			// Se x for menor ou igual a 1 o valor 1 será retornado .
			if (x <= 1)
			{
				return 1;
			}
			// Se não retornará o número da sequência.
			else
			{
				return Fibonacci(x - 1) + Fibonacci(x - 2);
			}
		}
	}
}