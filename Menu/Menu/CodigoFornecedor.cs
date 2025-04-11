using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Menu
{
    internal class CodigoFornecedor
    {
        public static void cadastrarCodigo()
        {
            Console.Clear();
            int codigoFornecedor;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░██╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██║██╔════╝░██╔══██╗
██║░░╚═╝██║░░██║██║░░██║██║██║░░██╗░██║░░██║
██║░░██╗██║░░██║██║░░██║██║██║░░╚██╗██║░░██║
╚█████╔╝╚█████╔╝██████╔╝██║╚██████╔╝╚█████╔╝
░╚════╝░░╚════╝░╚═════╝░╚═╝░╚═════╝░░╚════╝░

███████╗░█████╗░██████╗░███╗░░██╗███████╗░█████╗░███████╗██████╗░░█████╗░██████╗░
██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗
█████╗░░██║░░██║██████╔╝██╔██╗██║█████╗░░██║░░╚═╝█████╗░░██║░░██║██║░░██║██████╔╝
██╔══╝░░██║░░██║██╔══██╗██║╚████║██╔══╝░░██║░░██╗██╔══╝░░██║░░██║██║░░██║██╔══██╗
██║░░░░░╚█████╔╝██║░░██║██║░╚███║███████╗╚█████╔╝███████╗██████╔╝╚█████╔╝██║░░██║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝░╚════╝░╚══════╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.Write("\nCódigo do fornecedor: ");
            Console.ResetColor();
            while (!int.TryParse(Console.ReadLine(), out codigoFornecedor) || codigoFornecedor < 0 || codigoFornecedor == 0)
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("Preencha o campo corretamente por favor: ");
                Console.ResetColor();
            }

            Console.Write("\n");

            Console.Write("Aguarde salvando o codigo do fornecedor");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(600);
                Console.Write(".");
            }

            Console.WriteLine("\n");

            Console.Write("Codigo");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" {codigoFornecedor}");
            Console.ResetColor();
            Console.Write(", cadastrado com sucesso !");

            Console.WriteLine("\n");
        }
    }
}
