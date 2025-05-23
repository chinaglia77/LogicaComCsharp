﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_IMC
{
    /*
     5-	Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, 
        leia o seu peso e sua altura e imprima na tela sua condição 
        de acordo com a tabela abaixo:
        Fórmula do IMC = peso / (altura) ²
        Tabela Condições IMC
  
     Abaixo de 18,5   | Abaixo do peso          
     Entre 18,6 e 24,9 | Peso ideal (parabéns)  
     Entre 25,0 e 29,9 | Levemente acima do peso
     Entre 30,0 e 34,9 | Obesidade grau I 
     Entre 35,0 e 39,9 | Obesidade grau II (severa)
     Maior ou igual a 40 | Obesidade grau III (mórbida)

     */
    internal class Program
    {
        static void Main(string[] args)
        {


            // Exibindo o arte ASCII
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
            ╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗
            ║                                                                                                                                                                    ║
            ║                                                                                                                                                                    ║
            ║                                                                $$$$$$\ $$\      $$\  $$$$$$\                                                                       ║
            ║                                                                \_$$  _|$$$\    $$$ |$$  __$$\                                                                      ║        
            ║                                                                  $$ |  $$$$\  $$$$ |$$ /  \__|                                                                     ║
            ║                                                                  $$ |  $$\$$\$$ $$ |$$ |                                                                           ║
            ║                                                                  $$ |  $$ \$$$  $$ |$$ |                                                                           ║           
            ║                                                                  $$ |  $$ |\$  /$$ |$$ |  $$\                                                                      ║
            ║                                                                $$$$$$\ $$ | \_/ $$ |\$$$$$$  |                                                                     ║
            ║                                                                \______|\__|     \__| \______/                                                                      ║
            ║                                                                                                                                                                    ║   
            ║                                                                                                                                                                    ║
            ╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Faça um algoritmo que calcule o IMC (Índice de Massa Corporal) de uma pessoa, \r\nleia o seu peso e sua altura e imprima na tela sua condição \r\nde acordo com a tabela abaixo:\r\nFórmula do IMC = peso / (altura) ²\r\nTabela Condições IMC\r\n\r\nAbaixo de 18,5   | Abaixo do peso\r\nEntre 18,6 e 24,9 | Peso ideal (parabéns)  \r\nEntre 25,0 e 29,9 | Levemente acima do peso\r\nEntre 30,0 e 34,9 | Obesidade grau I \r\nEntre 35,0 e 39,9 | Obesidade grau II (severa)\r\nMaior ou igual a 40 | Obesidade grau III (mórbida)");
            Console.ResetColor();

            
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
            else if (imc >= 30 && imc <= 34.9 ) 
            {
                Console.WriteLine("Obesidade I");
                Console.WriteLine("IMC: " + imc.ToString("F2"));
            }
            else if (imc >= 35 && imc <=39.9)
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
