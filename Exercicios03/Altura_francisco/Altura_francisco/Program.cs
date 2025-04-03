using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altura_francisco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exibindo o arte ASCII
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
            ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
            ║                                                                                                                                                                    ║
            ║                                                       _____      _            _                       _ _                                                          ║
            ║                                                      / ____|    | |          | |                /\   | | |                                                         ║
            ║                                                     | |     __ _| | ___ _   _| | __ _ _ __     /  \  | | |_ _   _ _ __ __ _                                        ║
            ║                                                     | |    / _` | |/ __| | | | |/ _` | '__|   / /\ \ | | __| | | | '__/ _` |                                       ║
            ║                                                     | |___| (_| | | (__| |_| | | (_| | |     / ____ \| | |_| |_| | | | (_| |                                       ║
            ║                                                      \_____\__,_|_|\___|\__,_|_|\__,_|_|    /_/    \_\_|\__|\__,_|_|  \__,_|                                       ║
            ║                                                                                                                                                                    ║
            ║                                                                                                                                                                    ║
            ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Este programa calcula quando Francisco será maior que Sara em altura.");
            Console.ResetColor();

            // Inicializa as variáveis de altura e crescimento
            double franciscoAltura = 1.50;  // em metros
            double saraAltura = 1.10;  // em metros
            double franciscoCrescimento = 0.02;  // em metros por ano (2 cm)
            double saraCrescimento = 0.03;  // em metros por ano (3 cm)


            // Exibindo o resultado da altura
            int anos = 0;
            Console.WriteLine("Após " + anos + " anos, Francisco será maior que Sara.");
            Console.WriteLine("Altura de Francisco: " + franciscoAltura + " metros.");
            Console.WriteLine("Altura de Sara: " + saraAltura + " metros.");
            // Contador de anos

            // Loop até Francisco ultrapassar Sara em altura
            while (franciscoAltura <= saraAltura)
            {
                franciscoAltura += franciscoCrescimento;
                saraAltura += saraCrescimento;
                anos++;
            }

            // Concatenando a resposta com o número de anos
            Console.WriteLine("Francisco será maior que Sara em " + anos + " anos.");
        }
    }
}
