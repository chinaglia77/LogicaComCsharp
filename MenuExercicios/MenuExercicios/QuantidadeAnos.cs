using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class QuantidadeAnos
    {
        public static void qunatidadeAnos() 
        {
            Console.Clear();
            Console.WriteLine(@"
░██████╗░██╗░░░██╗░█████╗░███╗░░██╗████████╗██╗██████╗░░█████╗░██████╗░███████╗  ██████╗░███████╗
██╔═══██╗██║░░░██║██╔══██╗████╗░██║╚══██╔══╝██║██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝
██║██╗██║██║░░░██║███████║██╔██╗██║░░░██║░░░██║██║░░██║███████║██║░░██║█████╗░░  ██║░░██║█████╗░░
╚██████╔╝██║░░░██║██╔══██║██║╚████║░░░██║░░░██║██║░░██║██╔══██║██║░░██║██╔══╝░░  ██║░░██║██╔══╝░░
░╚═██╔═╝░╚██████╔╝██║░░██║██║░╚███║░░░██║░░░██║██████╔╝██║░░██║██████╔╝███████╗  ██████╔╝███████╗
░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝  ╚═════╝░╚══════╝

░█████╗░███╗░░██╗░█████╗░░██████╗
██╔══██╗████╗░██║██╔══██╗██╔════╝
███████║██╔██╗██║██║░░██║╚█████╗░
██╔══██║██║╚████║██║░░██║░╚═══██╗
██║░░██║██║░╚███║╚█████╔╝██████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░╚═════╝░");
            int anoNascimento, anoAtual, idadeAnos, idadeMeses, idadeDias;

            Console.Write("\nDigite o ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            idadeAnos = anoAtual - anoNascimento;
            idadeMeses = idadeAnos * 12;
            idadeDias = idadeAnos * 365;

            // Imprimir idade em anos, meses e dias
            Console.WriteLine("Você tem " + idadeAnos + " anos, " + idadeMeses + " meses e " + idadeDias + " dias de vida.");
        }
    }
}
