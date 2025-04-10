using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Pedido
    {
        public static void cadastrarPedido()
        {
            Console.Clear();
            string cadastroPedido = "";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░███████╗██████╗░██╗██████╗░░█████╗░
██╔══██╗██╔════╝██╔══██╗██║██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██║██║██║░░██║██║░░██║
██╔═══╝░██╔══╝░░██║░░██║██║██║░░██║██║░░██║
██║░░░░░███████╗██████╔╝██║██████╔╝╚█████╔╝
╚═╝░░░░░╚══════╝╚═════╝░╚═╝╚═════╝░░╚════╝░
");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nNome do pedido: ");
            Console.ResetColor();

            cadastroPedido = Console.ReadLine();

            Console.Write($"\nPedido ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{cadastroPedido.ToUpper()}");
            Console.ResetColor();
            Console.Write(" cadastrado com sucesso!");

            Console.WriteLine("\n");
        }
    }
    }


