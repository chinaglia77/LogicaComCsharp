using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class DescontoLoja
    {
        public static void descontoDaLoja() 
        {
            Console.Clear();
            Console.WriteLine(@"");
            double precoProduto, descontoPreco;

            Console.Write("Digite o preço do produto: ");
            precoProduto = double.Parse(Console.ReadLine());

            if (precoProduto > 100)
            {
                descontoPreco = precoProduto * 0.10;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
            else
            {
                descontoPreco = precoProduto * 0.5;
                Console.WriteLine(descontoPreco + " reais de desconto");
            }
        }
    }
}
