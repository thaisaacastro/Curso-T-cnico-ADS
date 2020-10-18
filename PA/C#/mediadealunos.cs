using System;

namespace Boletim
{
    class Program
    {
        public static void Main(string[] args)
        {
            double al1, al2, al3, al4;
            double soma;

            Console.Write("Digite a nota aluno: ");
            al1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite a nota aluno: ");
            al2 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite a nota aluno: ");
            al3 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Digite a nota aluno: ");
            al4 = Convert.ToDouble(Console.ReadLine());

            soma = (al1 + al2 + al3 + al4) / 4;

            Console.Write("A média do aluno é: ");
            Console.WriteLine(soma);

            Console.ReadKey();

        }
    }
}