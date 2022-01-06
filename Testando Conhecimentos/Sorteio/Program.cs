using System;

namespace Sorteio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número total de inscritos: ");
			int numero = int.Parse(Console.ReadLine());
        
            Random Sorteio = new Random();
            int sorteado = Sorteio.Next(1, numero);

            Console.WriteLine("O número sorteado é: "+sorteado);
        }
    }
}
