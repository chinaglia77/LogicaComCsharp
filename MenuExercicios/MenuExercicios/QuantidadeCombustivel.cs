using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class QuantidadeCombustivel
    {
        public static void qtdCombustivel() 
        {
            Console.Clear();
            Console.WriteLine(@"
░██████╗░██╗░░░██╗░█████╗░███╗░░██╗████████╗██╗██████╗░░█████╗░██████╗░███████╗  ██████╗░███████╗
██╔═══██╗██║░░░██║██╔══██╗████╗░██║╚══██╔══╝██║██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝
██║██╗██║██║░░░██║███████║██╔██╗██║░░░██║░░░██║██║░░██║███████║██║░░██║█████╗░░  ██║░░██║█████╗░░
╚██████╔╝██║░░░██║██╔══██║██║╚████║░░░██║░░░██║██║░░██║██╔══██║██║░░██║██╔══╝░░  ██║░░██║██╔══╝░░
░╚═██╔═╝░╚██████╔╝██║░░██║██║░╚███║░░░██║░░░██║██████╔╝██║░░██║██████╔╝███████╗  ██████╔╝███████╗
░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░███╗░░░███╗██████╗░██╗░░░██╗░██████╗████████╗██╗██╗░░░██╗███████╗██╗░░░░░
██╔══██╗██╔══██╗████╗░████║██╔══██╗██║░░░██║██╔════╝╚══██╔══╝██║██║░░░██║██╔════╝██║░░░░░
██║░░╚═╝██║░░██║██╔████╔██║██████╦╝██║░░░██║╚█████╗░░░░██║░░░██║╚██╗░██╔╝█████╗░░██║░░░░░
██║░░██╗██║░░██║██║╚██╔╝██║██╔══██╗██║░░░██║░╚═══██╗░░░██║░░░██║░╚████╔╝░██╔══╝░░██║░░░░░
╚█████╔╝╚█████╔╝██║░╚═╝░██║██████╦╝╚██████╔╝██████╔╝░░░██║░░░██║░░╚██╔╝░░███████╗███████╗
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═════╝░░╚═════╝░╚═════╝░░░░╚═╝░░░╚═╝░░░╚═╝░░░╚══════╝╚══════╝");
            Console.Write("\nDigite o tempo da viagem (em horas): ");
            double tempo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade média (em km/h): ");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            double distancia = tempo * velocidadeMedia;

            double litrosGastos = distancia / 12;

            Console.WriteLine("A quantidade de litros gastos na viagem foi " + litrosGastos.ToString("F2") + " litros.");
        }
    }
}
