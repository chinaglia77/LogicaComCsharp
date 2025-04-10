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
            Console.Clear(); // Limpa a tela para uma nova interação
            string cadastroPedido = "";

            // Título estilizado para o pedido
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"

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
            Console.WriteLine(" cadastrado com sucesso!");
        }
    }
    }


