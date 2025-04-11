using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class AlturaFrancisco
    {
        public static void altura() 
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░██╗░░░░░████████╗██╗░░░██╗██████╗░░█████╗░
██╔══██╗██║░░░░░╚══██╔══╝██║░░░██║██╔══██╗██╔══██╗
███████║██║░░░░░░░░██║░░░██║░░░██║██████╔╝███████║
██╔══██║██║░░░░░░░░██║░░░██║░░░██║██╔══██╗██╔══██║
██║░░██║███████╗░░░██║░░░╚██████╔╝██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝

███████╗██████╗░░█████╗░███╗░░██╗░█████╗░██╗░██████╗░█████╗░░█████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔══██╗██║██╔════╝██╔══██╗██╔══██╗
█████╗░░██████╔╝███████║██╔██╗██║██║░░╚═╝██║╚█████╗░██║░░╚═╝██║░░██║
██╔══╝░░██╔══██╗██╔══██║██║╚████║██║░░██╗██║░╚═══██╗██║░░██╗██║░░██║
██║░░░░░██║░░██║██║░░██║██║░╚███║╚█████╔╝██║██████╔╝╚█████╔╝╚█████╔╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═╝╚═════╝░░╚════╝░░╚════╝░");
            Console.WriteLine("\nEste programa calcula quando Francisco será maior que Sara em altura.");
            Console.ResetColor();
           
            double franciscoAltura = 1.50; 
            double saraAltura = 1.10; 
            double franciscoCrescimento = 0.02;  
            double saraCrescimento = 0.03;  
            
            int anos = 0;
            Console.WriteLine("Após " + anos + " anos, Francisco será maior que Sara.");
            Console.WriteLine("Altura de Francisco: " + franciscoAltura + " metros.");
            Console.WriteLine("Altura de Sara: " + saraAltura + " metros.");
            
            while (franciscoAltura <= saraAltura)
            {
                franciscoAltura += franciscoCrescimento;
                saraAltura += saraCrescimento;
                anos++;
            }

           
            Console.WriteLine("Francisco será maior que Sara em " + anos + " anos.");
        }
    }
}
