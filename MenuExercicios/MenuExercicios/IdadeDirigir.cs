using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class IdadeDirigir
    {
        public static void idadeParaDirigir() 
        {
            Console.Clear();
            Console.WriteLine(@"
██╗██████╗░░█████╗░██████╗░███████╗  ██████╗░░█████╗░██████╗░░█████╗░
██║██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██║██║░░██║███████║██║░░██║█████╗░░  ██████╔╝███████║██████╔╝███████║
██║██║░░██║██╔══██║██║░░██║██╔══╝░░  ██╔═══╝░██╔══██║██╔══██╗██╔══██║
██║██████╔╝██║░░██║██████╔╝███████╗  ██║░░░░░██║░░██║██║░░██║██║░░██║
╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝  ╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░██╗██████╗░██╗░██████╗░██╗██████╗░
██╔══██╗██║██╔══██╗██║██╔════╝░██║██╔══██╗
██║░░██║██║██████╔╝██║██║░░██╗░██║██████╔╝
██║░░██║██║██╔══██╗██║██║░░╚██╗██║██╔══██╗
██████╔╝██║██║░░██║██║╚██████╔╝██║██║░░██║
╚═════╝░╚═╝╚═╝░░╚═╝╚═╝░╚═════╝░╚═╝╚═╝░░╚═╝");
            int idade;

            Console.Write("\nDigite a idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Não pode dirigir");
            }
            else
            {
                Console.WriteLine("Pode dirigir");
            }
        }
    }
}
