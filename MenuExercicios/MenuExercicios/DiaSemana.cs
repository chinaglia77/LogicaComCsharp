using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class DiaSemana
    {
        public static void encontrarDiaSemana() 
        {
            Console.Clear();
            Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░░█████╗░██████╗░██████╗░██╗██████╗░  ██████╗░██╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗  ██╔══██╗██║██╔══██╗
██║░░██║█████╗░░╚█████╗░██║░░╚═╝██║░░██║██████╦╝██████╔╝██║██████╔╝  ██║░░██║██║███████║
██║░░██║██╔══╝░░░╚═══██╗██║░░██╗██║░░██║██╔══██╗██╔══██╗██║██╔══██╗  ██║░░██║██║██╔══██║
██████╔╝███████╗██████╔╝╚█████╔╝╚█████╔╝██████╦╝██║░░██║██║██║░░██║  ██████╔╝██║██║░░██║
╚═════╝░╚══════╝╚═════╝░░╚════╝░░╚════╝░╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚═╝  ╚═════╝░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░  ░██████╗███████╗███╗░░░███╗░█████╗░███╗░░██╗░█████╗░
██╔══██╗██╔══██╗  ██╔════╝██╔════╝████╗░████║██╔══██╗████╗░██║██╔══██╗
██║░░██║███████║  ╚█████╗░█████╗░░██╔████╔██║███████║██╔██╗██║███████║
██║░░██║██╔══██║  ░╚═══██╗██╔══╝░░██║╚██╔╝██║██╔══██║██║╚████║██╔══██║
██████╔╝██║░░██║  ██████╔╝███████╗██║░╚═╝░██║██║░░██║██║░╚███║██║░░██║
╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
            int diaSemana;

            Console.Write("\nDigite o numero da semana: ");
            diaSemana = int.Parse(Console.ReadLine());

            if (diaSemana > 7)
            {
                Console.WriteLine("Dia da semana invalida, tente novamente");
            }
            else if (diaSemana == 1 || diaSemana == 7)
            {
                Console.WriteLine("Final de semana");
            }
            else
            {
                Console.WriteLine("Dia da semana normal");
            }
        }
    }
}
