using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class FormasPagamento
    {
        public static void formaPagamento() 
        {
            Console.Clear();
            Console.WriteLine(@"
███████╗░█████╗░██████╗░███╗░░░███╗░█████╗░░██████╗  ██████╗░███████╗
██╔════╝██╔══██╗██╔══██╗████╗░████║██╔══██╗██╔════╝  ██╔══██╗██╔════╝
█████╗░░██║░░██║██████╔╝██╔████╔██║███████║╚█████╗░  ██║░░██║█████╗░░
██╔══╝░░██║░░██║██╔══██╗██║╚██╔╝██║██╔══██║░╚═══██╗  ██║░░██║██╔══╝░░
██║░░░░░╚█████╔╝██║░░██║██║░╚═╝░██║██║░░██║██████╔╝  ██████╔╝███████╗
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░░██████╗░░█████╗░███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔════╝░██╔══██╗████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
██████╔╝███████║██║░░██╗░███████║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██╔═══╝░██╔══██║██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
██║░░░░░██║░░██║╚██████╔╝██║░░██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            double valorProduto, valorDesconto, valorJuros;
            int opcaoPagamento = 0;

            const ConsoleColor FONTCOLORGREEN = ConsoleColor.Green;
            const ConsoleColor FONTCOLORYELLOW = ConsoleColor.Yellow;
            const ConsoleColor FONTCOLORBLUE = ConsoleColor.Blue;
            const ConsoleColor FONTCOLORRED = ConsoleColor.Red;

            Console.WriteLine("\nFORMAS DE PAGAMENTO\n" + "1 - Á Vista em dinheiro ou pix, recebe 15% de desconto\n" +
                "2 - Á Vista no cartão de crédito, recebe 10% de desconto\n" +
                "3 - Parcelando no cartão de em duas vezes, preço normal do produto sem juros\n" +
                "4 - Parcelando no cartão em três vezes ou mais, preço normal do produto mais juros de 10%\n" +
                "5 - Sair do programa\n"
                );

            Console.Write("Opção de pagamento: ");
            opcaoPagamento = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (opcaoPagamento)
            {
                case 1:
                    Console.WriteLine("Á Vista em dinheiro ou pix, recebe 15% de desconto");
                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = double.Parse(Console.ReadLine());
                    valorDesconto = valorProduto - (valorProduto * 0.15);

                    Console.ResetColor();
                    Console.ForegroundColor = FONTCOLORGREEN;

                    Console.WriteLine("Valor do produto com desconto: R$ " + valorDesconto);
                    Console.ResetColor();
                    break;

                case 2:
                    Console.WriteLine("Á Vista no cartão de crédito, recebe 10% de desconto");
                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = double.Parse(Console.ReadLine());
                    valorDesconto = valorProduto - (valorProduto * 0.10);
                    Console.ForegroundColor = FONTCOLORYELLOW;

                    Console.ResetColor();
                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Valor do produto com desconto: R$" + valorDesconto);
                    Console.ResetColor();
                    break;

                case 3:
                    Console.WriteLine("Parcelado no cartão em duas vezes, preço normal do produto sem juros");

                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");
                    valorProduto = double.Parse(Console.ReadLine());
                    double valorParcelas = valorProduto / 2;

                    Console.ResetColor();

                    Console.ForegroundColor = FONTCOLORBLUE;
                    Console.WriteLine("Valor da 1 parcela: R$" + valorParcelas);
                    Console.WriteLine("Valor da 2 parcela: R$" + valorParcelas);

                    Console.ResetColor();

                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Total: R$" + valorProduto);
                    break;

                case 4:
                    Console.WriteLine("Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%");

                    Console.ForegroundColor = FONTCOLORYELLOW;
                    Console.Write("Valor do produto: ");

                    valorProduto = int.Parse(Console.ReadLine());
                    valorJuros = valorProduto + (valorProduto * 0.10);

                    Console.ForegroundColor = FONTCOLORGREEN;
                    Console.WriteLine("Total: " + valorJuros);
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = FONTCOLORRED;
                    Console.WriteLine("Saindo do programa...");
                    Console.ResetColor();
                    break;

                default:
                    Console.WriteLine("Digite a opção corretamente, tente novamente");
                    break;
            }
        }
    }
}
