using System;
class MainClass
{
	// Este código realiza a sequência de Fibonacci, e gera um novo número sempre que apertadoa tecla enter. 

	public static void Main(string[] args)
	{
		// Criação das das variáveis.
		int NumeroAnterior = 0;
		int NumeroAtual = 1;
		int NovoNumero;
		int Fibonacci;

		Console.WriteLine("Aperte Enter e um número será gerado na sequência de Fibonacci:");

		// Estrutura de repetição.
		for (int i = 0; i < 100; i++)
		{
			// A variável Fibonacci recebe o número anterior e soma com o número atual.
			Fibonacci = NumeroAnterior + NumeroAtual;
			// O console.WriteLine imprime no console.
			Console.WriteLine(Fibonacci);
			NumeroAnterior = NumeroAtual;
			NumeroAtual = Fibonacci;
			// O console.ReadKey 
			Console.ReadKey();
			//Fim do código.
		}

	}
}