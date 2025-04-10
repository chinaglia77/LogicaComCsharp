using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 3) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Digite a opcao corretamente, tente novamente: ");
                    Console.ResetColor();
                }
                
                switch (opcao) 
                {
                    case 1:
                        cadastrarAlbumBanda();
                        break;
                        
                    case 2:
                        cadastrarAlbumArtista();
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saindo do programa...");
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

        static void cadastrarAlbumBanda() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░██████╗░  ██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝  ██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗  ██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║  ██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═════╝░░╚════╝░

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ██████╗░░█████╗░  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ██║░░██║███████║  ██████╦╝███████║██╔██╗██║██║░░██║███████║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██║░░██║██╔══██║  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ██████╔╝██║░░██║  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ╚═════╝░╚═╝░░╚═╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nNome da banda: ");
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
                Console.Write("Dado invalido digite um numero, tente novamente: \n");
                Console.ResetColor();
            }

            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"{i} - Musica: ");
                Console.ResetColor();

                string nomeMusica = Console.ReadLine();
            }

            Console.Write($"\nTodas as {qtdMusicas} musicas do {nomeAlbum.ToUpper()} foram adicionadas com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" sucesso !\n");
            Console.ResetColor();
           
        }

        static void cadastrarAlbumArtista()
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░░╚════╝░

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗  ██████╗░░█████╗░
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║  ██╔══██╗██╔══██╗
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║  ██║░░██║██║░░██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║  ██║░░██║██║░░██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║  ██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝  ╚═════╝░░╚════╝░

░█████╗░██████╗░████████╗██╗░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗╚══██╔══╝██║██╔════╝╚══██╔══╝██╔══██╗
███████║██████╔╝░░░██║░░░██║╚█████╗░░░░██║░░░███████║
██╔══██║██╔══██╗░░░██║░░░██║░╚═══██╗░░░██║░░░██╔══██║
██║░░██║██║░░██║░░░██║░░░██║██████╔╝░░░██║░░░██║░░██║
╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nNome do artista: ");
            Console.ResetColor();
            string nomeArtista = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Nome do album do artista {nomeArtista}: ");
            Console.ResetColor();
            string nomeAlbum = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"Quantas musicas o album {nomeAlbum} possui: ");
            Console.ResetColor();

            int qtdMusicas = 0;
            while (!int.TryParse(Console.ReadLine(), out qtdMusicas) || qtdMusicas < 0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Dado invalido digite um numero, tente novamente: ");
                Console.ResetColor();
            }

            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"Nome do {i} album: ");
                Console.ResetColor();

                string nomeMusica = Console.ReadLine();
            }

            Console.Write($"\nTodos as {qtdMusicas} musicas do(a) artista {nomeArtista.ToUpper()} foram adicionadas com");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" sucesso !");
            Console.ResetColor();
        }
    }
}
