using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class FabricaPecas
    {
        public static void aprovarPecas() 
        {
            Console.Clear();
            Console.WriteLine(@"
███████╗░█████╗░██████╗░██████╗░██╗░█████╗░░█████╗░  ██████╗░███████╗
██╔════╝██╔══██╗██╔══██╗██╔══██╗██║██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
█████╗░░███████║██████╦╝██████╔╝██║██║░░╚═╝███████║  ██║░░██║█████╗░░
██╔══╝░░██╔══██║██╔══██╗██╔══██╗██║██║░░██╗██╔══██║  ██║░░██║██╔══╝░░
██║░░░░░██║░░██║██████╦╝██║░░██║██║╚█████╔╝██║░░██║  ██████╔╝███████╗
╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚══════╝

██████╗░███████╗░█████╗░░█████╗░░██████╗
██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░╚═╝███████║╚█████╗░
██╔═══╝░██╔══╝░░██║░░██╗██╔══██║░╚═══██╗
██║░░░░░███████╗╚█████╔╝██║░░██║██████╔╝
╚═╝░░░░░╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░");
            int contador, reprovadas, aprovadas, numPecas;
            string estado;

            contador = 1;
            reprovadas = 0;
            aprovadas = 0;

            Console.Write("\n");
            while (contador <= 400)
            {
                Console.WriteLine("Digite o numero da " + contador + " peça: ");
                numPecas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite se a peça foi está aprovada ou reprovada(a para aprovada / r para reprovada): ");
                estado = Console.ReadLine();

                if (estado == "a")
                {
                    aprovadas++;
                }
                else
                {
                    reprovadas++;
                }
                contador++;
            }
            Console.WriteLine("Total de peças aprovadas: " + aprovadas);
            Console.WriteLine("Total de peças reprovadas: " + reprovadas);
        }
    }
}
