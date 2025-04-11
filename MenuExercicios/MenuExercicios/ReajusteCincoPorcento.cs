using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class ReajusteCincoPorcento
    {
        public static void Reajuste() 
        {
            Console.Clear();
            Console.WriteLine(@"
██████╗░███████╗░█████╗░░░░░░██╗██╗░░░██╗░██████╗████████╗███████╗  ███████╗██╗░██╗
██╔══██╗██╔════╝██╔══██╗░░░░░██║██║░░░██║██╔════╝╚══██╔══╝██╔════╝  ██╔════╝╚═╝██╔╝
██████╔╝█████╗░░███████║░░░░░██║██║░░░██║╚█████╗░░░░██║░░░█████╗░░  ██████╗░░░██╔╝░
██╔══██╗██╔══╝░░██╔══██║██╗░░██║██║░░░██║░╚═══██╗░░░██║░░░██╔══╝░░  ╚════██╗░██╔╝░░
██║░░██║███████╗██║░░██║╚█████╔╝╚██████╔╝██████╔╝░░░██║░░░███████╗  ██████╔╝██╔╝██╗
╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═════╝░░░░╚═╝░░░╚══════╝  ╚═════╝░╚═╝░╚═╝");
            double valor, valorReajustado;

            Console.Write("\nDigite um valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor normal: " + valor);
            valorReajustado = (valor * 0.05) + valor;

            Console.WriteLine("Valor reajustado: " + valorReajustado);
        }
    }
}
