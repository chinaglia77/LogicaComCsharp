using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCadastroBandas
{
    /*
     se / enquanto / para / caso
     if    while     for   switch
 
      Crie um sistema de cadastro de álbuns de um artista / banda em que será possivel cadastrar um número X de músicas informada pelo usuário.
      Crie um menu de opções para isso.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 3) 
            {
                Console.Clear();
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗  ██████╗░███████╗
████╗░████║██╔════╝████╗░██║██║░░░██║  ██╔══██╗██╔════╝
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║  ██║░░██║█████╗░░
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║  ██║░░██║██╔══╝░░
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝  ██████╔╝███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n1 - ");
                Console.ResetColor();
                Console.WriteLine("Cadastrar album da banda");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("2 - ");
                Console.ResetColor();
                Console.WriteLine("Cadastrar album do artista");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("3 - ");
                Console.ResetColor();
                Console.WriteLine("Sair do programa");

                Console.Write("-> ");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao <= 0 || opcao > 3) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite a opcao corretamente, tente novamente: ");
                    Console.ResetColor();
                }
                
                switch (opcao) 
                {
                    case 1:
                        cadastrarMusicaBanda();
                        break;
                        
                    case 2:
                        cadastrarMusicaArtista();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Saindo do programa");

                        for (int i = 0; i < 3; i++) 
                        {
                            Thread.Sleep(500);
                            Console.Write(".");
                        }
                        Console.ResetColor();
                        break;

                    default: 
                        Console.WriteLine();
                        break;
                }

                if (opcao != 3) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nDigite qualquer tecla para continuar: ");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }

        static void cadastrarMusicaBanda() 
        {
            Console.Clear();
            Console.Write(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░  ██████╗░░█████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║  ██║░░██║███████║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║  ██║░░██║██╔══██║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║  ██████╔╝██║░░██║
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome da banda: ");
            Console.ResetColor();
            string nomeBanda = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome do album: ");
            Console.ResetColor();
            string nomeAlbum = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Quantas músicas o album {nomeAlbum.ToUpper()} possui: ");
            Console.ResetColor();
            int qtdMusicas = 0;

            while (!int.TryParse(Console.ReadLine(), out qtdMusicas) || qtdMusicas < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dado invalido digite um numero, tente novamente: ");
                Console.ResetColor();
            }

            Console.Write("\n");

            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Nome da {i}ª música: ");
                Console.ResetColor();

                string nomeMusica = Console.ReadLine();

                while (String.IsNullOrEmpty(nomeMusica)) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite uma música válida, por favor: ");
                    Console.ResetColor();

                    nomeMusica = Console.ReadLine();
                }

            }

            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Salvando dados");

                for (int i = 0; i < 3; i++) 
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
            Console.ResetColor();

            Thread.Sleep(1500);

            Console.WriteLine("\n");

            Console.Write($"Todas as {qtdMusicas} musicas do {nomeAlbum.ToUpper()} foram salvas com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" sucesso !\n");
            Console.ResetColor();
           
        }

        static void cadastrarMusicaArtista()
        {
            Console.Clear();
            Console.WriteLine(@"

░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░░█████╗░  ██████╗░░█████╗░
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝███████║  ██║░░██║██║░░██║
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██╔══██║  ██║░░██║██║░░██║
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██║░░██║  ██████╔╝╚█████╔╝
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═╝░░╚═╝  ╚═════╝░░╚════╝░

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nNome do artista: ");
            Console.ResetColor();
            string nomeArtista = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Nome do album do artista {nomeArtista}: ");
            Console.ResetColor();
            string nomeAlbum = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Quantas musicas o album {nomeAlbum} possui: ");
            Console.ResetColor();

            int qtdMusicas = 0;
            while (!int.TryParse(Console.ReadLine(), out qtdMusicas) || qtdMusicas < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dado invalido digite um numero, tente novamente: ");
                Console.ResetColor();
            }

            Console.Write("\n");
            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Nome da {i}ª música: ");
                Console.ResetColor();

                string nomeMusica = Console.ReadLine();

                while (string.IsNullOrWhiteSpace(nomeMusica))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite uma música válida, por favor: ");
                    Console.ResetColor();

                    nomeMusica = Console.ReadLine();
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nSalvando dados");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500); 
                Console.Write(".");
            }

            Thread.Sleep(1000);

            Console.WriteLine("\n");
            Console.ResetColor();
            Console.Write($"Todos as {qtdMusicas} musicas do(a) artista {nomeArtista.ToUpper()} foram salvas com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" sucesso !\n");
            Console.ResetColor();
        }
    }
}
