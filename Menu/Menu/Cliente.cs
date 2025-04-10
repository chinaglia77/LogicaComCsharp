using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Menu
{
    internal class Cliente
    {
        public static void CadastrarCliente() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nNome do cliente: ");
            Console.ResetColor();
            string nomeCliente = Console.ReadLine();

            while (String.IsNullOrEmpty(nomeCliente))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Preencha o corretamente campo por favor: ");
                Console.ResetColor();
                nomeCliente = Console.ReadLine();
            }

            Console.Write("\n");

            Console.Write("Aguarde salvando nome do cliente");
            for (int i = 0; i < 4; i++) 
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

            Console.WriteLine("\n");

            Console.Write($"Cliente ");
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.Write($"{nomeCliente.ToUpper()}");
            Console.ResetColor();
            Console.Write(", cadastrado com sucesso !");

            Console.WriteLine("\n");
        }

    }
}
