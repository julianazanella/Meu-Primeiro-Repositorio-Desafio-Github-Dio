using System;

namespace Média_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string Nome = Console.ReadLine();

            Console.Write("Digite a primeira nota do aluno: ");
			double nota1 =  double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
			double nota2=  double.Parse(Console.ReadLine());
            
            double Media = (nota1+nota2)/2;

            if (Media>= 6)
            {
                Console.Write("Aluno Aprovado");
            }
            else if (Media< 4)
            {
                Console.Write("Aluno Reprovado");
            }
            else 
            {
                Console.Write("Aluno em Recuperação");
            }
            Console.WriteLine();
            Console.Write("O aluno ficou com média: "+Media);
        }
    }
}
