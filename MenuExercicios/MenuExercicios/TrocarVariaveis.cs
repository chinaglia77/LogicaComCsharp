using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class TrocarVariaveis
    {
        public static void trocarVarivel() 
        {
            Console.Clear();
            Console.WriteLine(@"
████████╗██████╗░░█████╗░░█████╗░░█████╗░██████╗░
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
░░░██║░░░██████╔╝██║░░██║██║░░╚═╝███████║██████╔╝
░░░██║░░░██╔══██╗██║░░██║██║░░██╗██╔══██║██╔══██╗
░░░██║░░░██║░░██║╚█████╔╝╚█████╔╝██║░░██║██║░░██║
░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝

██╗░░░██╗░█████╗░██████╗░██╗░█████╗░██╗░░░██╗███████╗██╗░██████╗
██║░░░██║██╔══██╗██╔══██╗██║██╔══██╗██║░░░██║██╔════╝██║██╔════╝
╚██╗░██╔╝███████║██████╔╝██║███████║╚██╗░██╔╝█████╗░░██║╚█████╗░
░╚████╔╝░██╔══██║██╔══██╗██║██╔══██║░╚████╔╝░██╔══╝░░██║░╚═══██╗
░░╚██╔╝░░██║░░██║██║░░██║██║██║░░██║░░╚██╔╝░░███████╗██║██████╔╝
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═╝╚═════╝░");
            int A, B, temp;

            Console.Write("\nDigite o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());

            // Trocar os valores de A e B
            temp = A;
            A = B;
            B = temp;

            // Imprimir os valores trocados
            Console.WriteLine("Após a troca, o valor de A é: " + A + " e o valor de B é: " + B);
        }
    }
}
