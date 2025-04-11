using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class AnoBissexto
    {
        public static void encontrarAnoBissexto() 
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░██╗░██████╗░██████╗███████╗██╗░░██╗████████╗░█████╗░
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██║██╔════╝██╔════╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔══██╗
███████║██╔██╗██║██║░░██║  ██████╦╝██║╚█████╗░╚█████╗░█████╗░░░╚███╔╝░░░░██║░░░██║░░██║
██╔══██║██║╚████║██║░░██║  ██╔══██╗██║░╚═══██╗░╚═══██╗██╔══╝░░░██╔██╗░░░░██║░░░██║░░██║
██║░░██║██║░╚███║╚█████╔╝  ██████╦╝██║██████╔╝██████╔╝███████╗██╔╝╚██╗░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚═╝╚═════╝░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░");
            int ano;

            Console.Write("\nDigite o ano: ");
            ano = int.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else if (ano % 400 == 0)
            {
                Console.WriteLine("Ano bissexto");
            }
            else
            {
                Console.WriteLine("Não bissexto");
            }

        }
    }
}
