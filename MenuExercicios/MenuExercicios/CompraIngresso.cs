using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class CompraIngresso
    {
        public static void ComprarIngresso() 
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░███╗░░░███╗██████╗░██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗████╗░████║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝██║░░██║██╔████╔██║██████╔╝██████╔╝███████║  ██║░░██║█████╗░░
██║░░██╗██║░░██║██║╚██╔╝██║██╔═══╝░██╔══██╗██╔══██║  ██║░░██║██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚═╝░██║██║░░░░░██║░░██║██║░░██║  ██████╔╝███████╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

██╗███╗░░██╗░██████╗░██████╗░███████╗░██████╗░██████╗░█████╗░░██████╗
██║████╗░██║██╔════╝░██╔══██╗██╔════╝██╔════╝██╔════╝██╔══██╗██╔════╝
██║██╔██╗██║██║░░██╗░██████╔╝█████╗░░╚█████╗░╚█████╗░██║░░██║╚█████╗░
██║██║╚████║██║░░╚██╗██╔══██╗██╔══╝░░░╚═══██╗░╚═══██╗██║░░██║░╚═══██╗
██║██║░╚███║╚██████╔╝██║░░██║███████╗██████╔╝██████╔╝╚█████╔╝██████╔╝
╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝░░╚═╝╚══════╝╚═════╝░╚═════╝░░╚════╝░╚═════╝░");
            double valorIngresso, valorIngressoDesconto;

            Console.Write("\nDigite o valor do ingresso: ");
            valorIngresso = double.Parse(Console.ReadLine());

            if (valorIngresso > 200)
            {
                valorIngressoDesconto = valorIngresso - (valorIngresso * 0.10);
                Console.WriteLine(valorIngressoDesconto + " reais");
            }
            else
            {
                Console.WriteLine("Ingresso não possui desconto");
            }
        }
    }
}
