using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                Console.Write("O codigo recebe apenas numeros, tente novamente: ");
                Console.ResetColor();
            }

            Console.Write("Codigo");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" {codigoFornecedor}");
            Console.ResetColor();
            Console.Write(", cadastrado com sucesso !\n");
        }
    }
}
