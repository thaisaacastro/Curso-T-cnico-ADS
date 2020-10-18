using System;

namespace Boletim_Escolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double pb, sb, tb, qb, r;
            string nome, curso, disciplina;

            Console.Write("Digite o nome do aluno:");
            nome = Console.ReadLine();

            Console.Write("Digite a disciplina do aluno: ");
            curso = Console.ReadLine();

            Console.Write("Digite a disciplina: ");
            disciplina = Console.ReadLine();

            Console.Write("1º Bimestre: ");
            pb = Convert.ToDouble(Console.ReadLine());

            Console.Write("2º Bimestre: ");
            sb = Convert.ToDouble(Console.ReadLine());

            Console.Write("3º Bimestre: ");
            tb = Convert.ToDouble(Console.ReadLine());

            Console.Write("4º Bimestre: ");
            qb = Convert.ToDouble(Console.ReadLine());

            r = (pb + sb + tb + qb) / 4;

            Console.Write("A média do aluno é: ");
            Console.WriteLine(r);

            Console.ReadKey();


        }
    }
}