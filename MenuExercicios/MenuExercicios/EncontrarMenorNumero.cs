using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class EncontrarMenorNumero
    {
        public static void menorNumero() 
        {
            Console.Clear();
            Console.WriteLine(@"
███████╗███╗░░██╗░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██████╗░  ███╗░░░███╗███████╗███╗░░██╗░█████╗░██████╗░
██╔════╝████╗░██║██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ████╗░████║██╔════╝████╗░██║██╔══██╗██╔══██╗
█████╗░░██╔██╗██║██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝███████║██████╔╝  ██╔████╔██║█████╗░░██╔██╗██║██║░░██║██████╔╝
██╔══╝░░██║╚████║██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░██║██╔══██╗
███████╗██║░╚███║╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║██║░░██║██║░░██║  ██║░╚═╝░██║███████╗██║░╚███║╚█████╔╝██║░░██║
╚══════╝╚═╝░░╚══╝░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚════╝░╚═╝░░╚═╝

███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");
            double numero1, numero2, numero3;

            Console.Write("\nDigite o primeiro numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            numero3 = int.Parse(Console.ReadLine());


            if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("Menor numero: " + numero1);
            }

            else if (numero2 < numero1 && numero2 < numero3)
            {
                Console.WriteLine("Menor numero: " + numero2);
            }
            else
            {
                Console.WriteLine("Menor numero " + numero3);
            }
        }
    }
}
