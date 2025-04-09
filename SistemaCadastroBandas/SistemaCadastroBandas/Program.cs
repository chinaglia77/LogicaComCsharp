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
                Console.WriteLine("1 - Cadastrar album da banda");
                Console.WriteLine("2 - Cadastrar album do artista");
                Console.WriteLine("3 - Sair do programa");

                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 3) 
                {
                    Console.WriteLine("Digite a opcao corretamente, tente novamente");
                }
                
                switch (opcao) 
                {
                    case 1:
                        cadastrarAlbumBanda();
                        break;
                        
                    case 2:
                        cadastrarAlgumArtista();
                        break;

                    case 3:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default: 
                        Console.WriteLine();
                        break;
                }

                if (opcao != 3) 
                {
                    Console.WriteLine("Digite qualquer tecla para continuar");
                    Console.ReadKey();
                }
            }
        }

        static void cadastrarAlbumBanda() 
        {
            Console.WriteLine("\nCadastro do album da banda");
            Console.Write("Nome da banda: ");
            string nomeBanda = Console.ReadLine();

            Console.Write($"Quantos albuns da banda {nomeBanda} você gostaria de adicionar: ");
            int qtdAlbuns = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdAlbuns; i++) 
            {
                Console.WriteLine($"Nome do {i} album: ");
                string nomeAlbum = Console.ReadLine();
            }

            Console.WriteLine($"Todos os {qtdAlbuns} albunns foram adicionado com sucesso !");
        }

        static void cadastrarAlgumArtista() 
        {
            Console.WriteLine("\nCadastro do album do artista");
            Console.Write("Nome do artista: ");
            string nomeArtista = Console.ReadLine();

            Console.Write($"Quantos albuns do artista {nomeArtista} você gostaria de adicionar: ");
            int qtdAlbuns = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdAlbuns; i++)
            {
                Console.WriteLine($"Nome do {i} album: ");
                string nomeAlbum = Console.ReadLine();
            }

            Console.WriteLine($"Todos os {qtdAlbuns} albunns foram adicionado com sucesso !");

        }
    }
}
