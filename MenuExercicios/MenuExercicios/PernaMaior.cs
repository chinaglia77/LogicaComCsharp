using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class PernaMaior
    {
        public static void verificarPernaMaior() 
        {
            Console.Clear();
            Console.WriteLine(@"
██╗░░░██╗███████╗██████╗░██╗███████╗██╗░█████╗░░█████╗░██████╗░  ██████╗░███████╗██████╗░███╗░░██╗░█████╗░
██║░░░██║██╔════╝██╔══██╗██║██╔════╝██║██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔════╝██╔══██╗████╗░██║██╔══██╗
╚██╗░██╔╝█████╗░░██████╔╝██║█████╗░░██║██║░░╚═╝███████║██████╔╝  ██████╔╝█████╗░░██████╔╝██╔██╗██║███████║
░╚████╔╝░██╔══╝░░██╔══██╗██║██╔══╝░░██║██║░░██╗██╔══██║██╔══██╗  ██╔═══╝░██╔══╝░░██╔══██╗██║╚████║██╔══██║
░░╚██╔╝░░███████╗██║░░██║██║██║░░░░░██║╚█████╔╝██║░░██║██║░░██║  ██║░░░░░███████╗██║░░██║██║░╚███║██║░░██║
░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝

███╗░░░███╗░█████╗░██╗░█████╗░██████╗░
████╗░████║██╔══██╗██║██╔══██╗██╔══██╗
██╔████╔██║███████║██║██║░░██║██████╔╝
██║╚██╔╝██║██╔══██║██║██║░░██║██╔══██╗
██║░╚═╝░██║██║░░██║██║╚█████╔╝██║░░██║
╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝");
            double medidaPernaDireita, medidaPernaEsquerda;

            Console.Write("\nMedida da perna direita: ");
            medidaPernaDireita = double.Parse(Console.ReadLine());

            Console.Write("Medida da perna esquerda: ");
            medidaPernaEsquerda = double.Parse(Console.ReadLine());

            if (medidaPernaDireita > medidaPernaEsquerda)
            {
                Console.WriteLine("Cotó na perna esquerda");
            }
            else if (medidaPernaEsquerda > medidaPernaDireita)
            {
                Console.WriteLine("Cotó na perna direira");
            }
            else
            {
                Console.WriteLine("Normal");
            }
        }
    }
}
