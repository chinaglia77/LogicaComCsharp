using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Trabalhando com Arrays");
            Console.ResetColor();

            String[] clientes = {"Maria", "Jose", "Cleyton"};
            int[] idades = {19, 15, 35 };

            Console.WriteLine("Nome: " + clientes[1]);
            Console.WriteLine("Idade: " + idades[1]);

            clientes[1] = "José";

            Console.WriteLine("Nome: " + clientes[1]);
            Console.WriteLine("Idade: " + idades[1]);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total de clientes: " + clientes.Length);
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\nLISTAGEM DE CLIENTES");
            Console.WriteLine("ID\tNome\t\tIdade");
            Console.ResetColor();

            for (int i = 0; i < clientes.Length; i++) 
            {
                Console.Write(i);
                Console.Write("\t");
                Console.Write(clientes[i]);
                Console.Write("\t\t");
                Console.WriteLine(idades[i]);
            }
        }
    }
}
