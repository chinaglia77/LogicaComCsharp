using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class CalcularIMC
    {
        public static void Imc() 
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░  ██╗███╗░░░███╗░█████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗  ██║████╗░████║██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██████╔╝  ██║██╔████╔██║██║░░╚═╝
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██╔══██╗  ██║██║╚██╔╝██║██║░░██╗
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██║░░██║  ██║██║░╚═╝░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝╚═╝░░░░░╚═╝░╚════╝░");
            double peso, altura, imc;

            Console.Write("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Peso ideal (Parabéns)");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Levemente acima do peso");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Obesidade I");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Obesidade II (severa)");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Obesidade III (mórbida)");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
        }
    }
}
