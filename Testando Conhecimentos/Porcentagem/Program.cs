using System;

namespace Porcentagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da compra: ");
			double compra = double.Parse(Console.ReadLine());
            double desconto = 0;

            if (compra < 100)
            {
                desconto = compra*0.95;
            }
            else if (compra> 100 && compra<500)
            {
                desconto = compra*0.90;
            }
            else 
            {
                desconto = compra*0.80;
            }

            Console.WriteLine("O valor da compra com desconto será R$" +desconto);
        }
    }
}
