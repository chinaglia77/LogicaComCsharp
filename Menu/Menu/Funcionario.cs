using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Funcionario
    {
        public static void cadastrarFuncionario()
        {
            Console.Clear();
            string nomeFuncionario =  "";
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░██╗░█████╗░
██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗██║██╔══██╗
█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝██║██║░░██║
██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗██║██║░░██║
██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║██║╚█████╔╝
╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("\nNome do funcionario: ");
            Console.ResetColor();

            nomeFuncionario = Console.ReadLine();

            Console.Write($"\nFuncionario, ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{nomeFuncionario.ToUpper()}");
            Console.ResetColor();
            Console.Write(" cadastrado com sucesso !");
        }
    }
}
