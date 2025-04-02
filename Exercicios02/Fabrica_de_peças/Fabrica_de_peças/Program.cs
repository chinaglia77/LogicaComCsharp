﻿        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrica_de_peças
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 	Uma fábrica tem uma linha de produção capaz de produzir 400 peças/dia. Um funcionário controla a qualidade, cadastrando o número da peça e o seu estado (aprovado ou reprovado). Criar um programa para cadastrar o controle de qualidade e imprimir o total de peças aprovadas e reprovadas no final do dia.
            int contador, reprovadas, aprovadas, numPecas;
            string estado;

            contador = 1;
            reprovadas = 0;
            aprovadas = 0;

            while(contador <= 400)
            {
                Console.WriteLine("Digite o numero da " + contador + " peça: ");
                numPecas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite se a peça foi está aprovada ou reprovada(a para aprovada / r para reprovada): ");
                estado = Console.ReadLine();

                if(estado == "a")
                {
                    aprovadas++;
                }
                else
                {
                    reprovadas++;
                }
                contador++;
            }
            Console.WriteLine("Total de peças aprovadas: " + aprovadas);
            Console.WriteLine("Total de peças reprovadas: " + reprovadas);
        }
    }
}
