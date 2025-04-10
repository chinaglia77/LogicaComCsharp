using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            while (String.IsNullOrEmpty(nomeFuncionario))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Preencha o corretamente campo por favor: ");
                Console.ResetColor();
                nomeFuncionario = Console.ReadLine();
            }

            Console.Write("\n");

            Console.Write("Aguarde salvando nome do cliente");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            Console.Write($"Funcionario, ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{nomeFuncionario.ToUpper()}");
            Console.ResetColor();
            Console.Write(" cadastrado com sucesso !");

            Console.WriteLine("\n");

        }
    }
}
