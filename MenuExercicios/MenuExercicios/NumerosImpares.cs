﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class NumerosImpares
    {
        public static void impares() 
        {
            Console.Clear();
            Console.WriteLine(@"
███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░  ██╗███╗░░░███╗██████╗░░█████╗░██████╗░███████╗░██████╗
████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗  ██║████╗░████║██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝
██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║  ██║██╔████╔██║██████╔╝███████║██████╔╝█████╗░░╚█████╗░
██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║  ██║██║╚██╔╝██║██╔═══╝░██╔══██║██╔══██╗██╔══╝░░░╚═══██╗
██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝  ██║██║░╚═╝░██║██║░░░░░██║░░██║██║░░██║███████╗██████╔╝
╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░  ╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═════╝░");
            int contador;

            for (contador = 1; contador <= 100; contador++)
            {
                if (contador % 2 != 0)
                {
                    Console.WriteLine(contador + "\n");
                }
            }
        }
    }
}
