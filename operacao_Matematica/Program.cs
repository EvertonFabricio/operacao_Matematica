using System;

namespace operacao_Matematica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
			int n1 = (int.Parse(Console.ReadLine()));

			Console.WriteLine("\nDigite outro numero inteiro:");
			int n2 = (int.Parse(Console.ReadLine()));

			Console.WriteLine("\nEscolha uma operação matemática para ser feita.\nDigite + para somar, - para subtrair, * para multiplicar ou / para dividir!");						
			var operador = (char.Parse(Console.ReadLine()));
         
			if (operador == '+')
				Console.WriteLine($"\nA soma dos numeros é {n1 + n2}");
			else if (operador == '-')
				Console.WriteLine($"\nA subtração dos numeros é {n1 - n2}");
			else if (operador == '*')
				Console.WriteLine($"\nA multiplicação dos numeros é {n1 * n2}");
			else if (operador == '/' & n2 != 0)
				Console.WriteLine($"\nA divisão dos numeros é {n1 + n2}");
			else 
				Console.WriteLine($"\nimpossivel dividir por zero!");

		}
    }
}




