using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class EstoqueVinho
    {
        public static void controleVinho() 
        {
            Console.Clear();
            Console.WriteLine(@"
███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗  ██╗░░░██╗██╗███╗░░██╗██╗░░██╗░█████╗░
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝  ██║░░░██║██║████╗░██║██║░░██║██╔══██╗
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░  ╚██╗░██╔╝██║██╔██╗██║███████║██║░░██║
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░  ░╚████╔╝░██║██║╚████║██╔══██║██║░░██║
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗  ░░╚██╔╝░░██║██║░╚███║██║░░██║╚█████╔╝
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝  ░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░");
            int contador, quantidadeBranco = 0, quantidadeTinto = 0;
            string vinhos;

            Console.Write("\n");
            for (contador = 1; contador > 0; contador++)
            {
                Console.WriteLine("Digite qual o tipo de vinho ou digite 'f' para finalizar o programa \n Digite ('t' para vinho tinto e 'b' para vinho branco): ");
                vinhos = Console.ReadLine();

                if (vinhos == "b")
                {
                    quantidadeBranco++;
                }
                if (vinhos == "t")
                {
                    quantidadeTinto++;
                }
                Console.Clear();
                if (vinhos == "f")
                {
                    Console.WriteLine("O total de vinhos brancos em estoque são: " + quantidadeBranco + "\ne o de vinhos tintos são: " + quantidadeTinto);
                    break;
                }
            }
        }
    }
}
