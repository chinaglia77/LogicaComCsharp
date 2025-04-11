using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class ValoresBoolean
    {
        public static void ValorBoolean() 
        {
            Console.Clear();
            Console.WriteLine(@"
██╗░░░██╗░█████╗░██╗░░░░░░█████╗░██████╗░███████╗░██████╗  ██████╗░░█████╗░░█████╗░██╗░░░░░███████╗░█████╗░███╗░░██╗
██║░░░██║██╔══██╗██║░░░░░██╔══██╗██╔══██╗██╔════╝██╔════╝  ██╔══██╗██╔══██╗██╔══██╗██║░░░░░██╔════╝██╔══██╗████╗░██║
╚██╗░██╔╝███████║██║░░░░░██║░░██║██████╔╝█████╗░░╚█████╗░  ██████╦╝██║░░██║██║░░██║██║░░░░░█████╗░░███████║██╔██╗██║
░╚████╔╝░██╔══██║██║░░░░░██║░░██║██╔══██╗██╔══╝░░░╚═══██╗  ██╔══██╗██║░░██║██║░░██║██║░░░░░██╔══╝░░██╔══██║██║╚████║
░░╚██╔╝░░██║░░██║███████╗╚█████╔╝██║░░██║███████╗██████╔╝  ██████╦╝╚█████╔╝╚█████╔╝███████╗███████╗██║░░██║██║░╚███║
░░░╚═╝░░░╚═╝░░╚═╝╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝╚═════╝░  ╚═════╝░░╚════╝░░╚════╝░╚══════╝╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝");
            bool valor1, valor2;

            Console.Write("\nDigite um valor boolean (true/false): ");
            valor1 = bool.Parse(Console.ReadLine().ToLower());


            Console.Write("Digite outro valor boolean (true/false): ");
            valor2 = bool.Parse(Console.ReadLine().ToLower());

            if (valor1 == valor2)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

        }
    }
}
