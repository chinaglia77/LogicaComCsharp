using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class AnoNascimento
    {
        public static void encontrarIdade() 
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░███╗░░██╗░█████╗░  ██████╗░███████╗
██╔══██╗████╗░██║██╔══██╗  ██╔══██╗██╔════╝
███████║██╔██╗██║██║░░██║  ██║░░██║█████╗░░
██╔══██║██║╚████║██║░░██║  ██║░░██║██╔══╝░░
██║░░██║██║░╚███║╚█████╔╝  ██████╔╝███████╗
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░  ╚═════╝░╚══════╝

███╗░░██╗░█████╗░░██████╗░█████╗░██╗███╗░░░███╗███████╗███╗░░██╗████████╗░█████╗░
████╗░██║██╔══██╗██╔════╝██╔══██╗██║████╗░████║██╔════╝████╗░██║╚══██╔══╝██╔══██╗
██╔██╗██║███████║╚█████╗░██║░░╚═╝██║██╔████╔██║█████╗░░██╔██╗██║░░░██║░░░██║░░██║
██║╚████║██╔══██║░╚═══██╗██║░░██╗██║██║╚██╔╝██║██╔══╝░░██║╚████║░░░██║░░░██║░░██║
██║░╚███║██║░░██║██████╔╝╚█████╔╝██║██║░╚═╝░██║███████╗██║░╚███║░░░██║░░░╚█████╔╝
╚═╝░░╚══╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░░╚════╝░");
            int idade, contador, ano_atual;

            for (contador = 1; contador > 0; contador++)
            {
                Console.Write("\nDigite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o ano atual: ");
                ano_atual = int.Parse(Console.ReadLine());

                Console.WriteLine("Seu ano de nascimento é: " + (ano_atual - idade));

                if (idade == 0)
                {
                    Console.Write("Fim do programa, idade 0");
                    break;
                }
            }
        }
    }
}
