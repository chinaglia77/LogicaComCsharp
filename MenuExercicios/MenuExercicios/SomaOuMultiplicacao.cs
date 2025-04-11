using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class SomaOuMultiplicacao
    {
        public static void opcaoCalculo() 
        {
            Console.Clear();
            Console.WriteLine(@"");
            Console.Title = "Soma ou Multiplicar";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░██████╗░█████╗░███╗░░░███╗░█████╗░  ░█████╗░██╗░░░██╗
██╔════╝██╔══██╗████╗░████║██╔══██╗  ██╔══██╗██║░░░██║
╚█████╗░██║░░██║██╔████╔██║███████║  ██║░░██║██║░░░██║
░╚═══██╗██║░░██║██║╚██╔╝██║██╔══██║  ██║░░██║██║░░░██║
██████╔╝╚█████╔╝██║░╚═╝░██║██║░░██║  ╚█████╔╝╚██████╔╝
╚═════╝░░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝  ░╚════╝░░╚═════╝░

███╗░░░███╗██╗░░░██╗██╗░░░░░████████╗██╗██████╗░██╗░░░░░██╗░█████╗░░█████╗░░█████╗░░█████╗░░█████╗░
████╗░████║██║░░░██║██║░░░░░╚══██╔══╝██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║██║░░░░░░░░██║░░░██║██████╔╝██║░░░░░██║██║░░╚═╝███████║██║░░╚═╝███████║██║░░██║
██║╚██╔╝██║██║░░░██║██║░░░░░░░░██║░░░██║██╔═══╝░██║░░░░░██║██║░░██╗██╔══██║██║░░██╗██╔══██║██║░░██║
██║░╚═╝░██║╚██████╔╝███████╗░░░██║░░░██║██║░░░░░███████╗██║╚█████╔╝██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚══════╝░░░╚═╝░░░╚═╝╚═╝░░░░░╚══════╝╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B foremiguais, deverá somar os dois valores, caso contrário devera multiplicar A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir seu valor na tela.");
            Console.ResetColor();

            int a, b, c;

            Console.Write("\nDigite o primeiro numero: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Resultado: " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Resultado: " + c);
            }
        }
    }
}
