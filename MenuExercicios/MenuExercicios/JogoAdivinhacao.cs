using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class JogoAdivinhacao
    {
        public static void iniciarJogo() 
        {
            Console.Clear();
            Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░  ██████╗░░█████╗░
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ██╔══██╗██╔══██╗
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██║░░██║███████║
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║░░██║██╔══██║
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██████╔╝██║░░██║
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═════╝░╚═╝░░╚═╝

░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║███████║██║░░╚═╝███████║██║░░██║
██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══██║██║░░██╗██╔══██║██║░░██║
██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            int num1, num2, contador, tentativa = 0;

            Console.WriteLine("\nDigite o numero para ser adivinhado: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Clear();

            for (contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("\nDigite a " + contador + "° tentativa: ");
                num2 = int.Parse(Console.ReadLine());

                if (num2 == num1)
                {
                    Console.WriteLine("Você acertou o número em: " + tentativa + " tentativas");
                    break;
                }
                else
                {
                    tentativa = contador + 1;
                    Console.WriteLine("\nTente novamente");
                }
            }
        }
    }
}
