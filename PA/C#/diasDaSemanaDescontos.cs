using System;

namespace DespesasConsole
{
    class Program
    {
        static void Main(string[] args)

        {

            int diasemana;
            double valordaCompra, valorDesconto;

            Console.WriteLine("Supermercado Vida - Mr. João");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Digite o valor da compra: ");
            valordaCompra = Double.Parse(Console.ReadLine());

            Console.WriteLine("Dias da Semana");
            Console.WriteLine("---------------");
            Console.WriteLine("\nDigite um número de 1 a 7: ");

            diasemana = int.Parse(Console.ReadLine());

            switch (diasemana) // começo do Switch
            {
                case 1:
                    Console.WriteLine("Você escolheu Domingo");
                    valorDesconto = valordaCompra - (valordaCompra * 6) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;

                case 2:
                    Console.WriteLine("Você escolheu Segunda");
                    valorDesconto = valordaCompra - (valordaCompra * 7) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;

                case 3:
                    Console.WriteLine("Você escolheu Terça");
                    valorDesconto = valordaCompra - (valordaCompra * 8) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;


                case 4:
                    Console.WriteLine("Você escolheu Quarta");
                    valorDesconto = valordaCompra - (valordaCompra * 9) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;

                case 5:
                    Console.WriteLine("Você escolheu Quinta");
                    valorDesconto = valordaCompra - (valordaCompra * 10) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;

                case 6:
                    Console.WriteLine("Você escolheu Sexta");
                    valorDesconto = valordaCompra - (valordaCompra * 11) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;

                case 7:
                    Console.WriteLine("Você escolheu Sábado");
                    valorDesconto = valordaCompra - (valordaCompra * 12) / 100;
                    Console.WriteLine("Valor a Pagar com desconto: ");
                    Console.WriteLine(valorDesconto);
                    break;
                default:
                    Console.WriteLine("/nNúmero inválido, digite novamente o intervalo de 1 a 7");
                    break;


            } // fim
            Console.ReadKey();

        }
    }
}