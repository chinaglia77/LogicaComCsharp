using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class MediaNota
    {
        public static void mediaNota() 
        {
            Console.Clear();
            Console.WriteLine(@"
███╗░░░███╗███████╗██████╗░██╗░█████╗░  ██████╗░░█████╗░  ███╗░░██╗░█████╗░████████╗░█████╗░
████╗░████║██╔════╝██╔══██╗██║██╔══██╗  ██╔══██╗██╔══██╗  ████╗░██║██╔══██╗╚══██╔══╝██╔══██╗
██╔████╔██║█████╗░░██║░░██║██║███████║  ██║░░██║███████║  ██╔██╗██║██║░░██║░░░██║░░░███████║
██║╚██╔╝██║██╔══╝░░██║░░██║██║██╔══██║  ██║░░██║██╔══██║  ██║╚████║██║░░██║░░░██║░░░██╔══██║
██║░╚═╝░██║███████╗██████╔╝██║██║░░██║  ██████╔╝██║░░██║  ██║░╚███║╚█████╔╝░░░██║░░░██║░░██║
╚═╝░░░░░╚═╝╚══════╝╚═════╝░╚═╝╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝  ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝");
            int idade;

            Console.Write("\nDigite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Menor de idade penal");
            }
            else
            {
                Console.WriteLine("Maior de idade penal");
            }
        }
    }
}
