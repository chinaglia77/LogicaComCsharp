using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class SalarioLiquido
    {
        public static void salario() 
        {
            Console.Clear();
            Console.WriteLine(@"
░██████╗░█████╗░██╗░░░░░░█████╗░██████╗░██╗░█████╗░  ██╗░░░░░██╗░██████╗░██╗░░░██╗██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║░░░░░██╔══██╗██╔══██╗██║██╔══██╗  ██║░░░░░██║██╔═══██╗██║░░░██║██║██╔══██╗██╔══██╗
╚█████╗░███████║██║░░░░░███████║██████╔╝██║██║░░██║  ██║░░░░░██║██║██╗██║██║░░░██║██║██║░░██║██║░░██║
░╚═══██╗██╔══██║██║░░░░░██╔══██║██╔══██╗██║██║░░██║  ██║░░░░░██║╚██████╔╝██║░░░██║██║██║░░██║██║░░██║
██████╔╝██║░░██║███████╗██║░░██║██║░░██║██║╚█████╔╝  ███████╗██║░╚═██╔═╝░╚██████╔╝██║██████╔╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░╚════╝░  ╚══════╝╚═╝░░░╚═╝░░░░╚═════╝░╚═╝╚═════╝░░╚════╝░");
            Console.Write("\nDigite o valor da hora-aula (em R$): ");
            double horaAula = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número de aulas lecionadas no mês: ");
            int numeroAulas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o percentual de desconto do INSS (%): ");
            double percentualINSS = Convert.ToDouble(Console.ReadLine());

            double salarioBruto = horaAula * numeroAulas;

            double descontoINSS = salarioBruto * (percentualINSS / 100);

            double salarioLiquido = salarioBruto - descontoINSS;

            Console.WriteLine("O salário líquido do professor é R$ " + salarioLiquido.ToString("F2") + ".");
        }
    }
}
