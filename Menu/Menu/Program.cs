using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    /*
     Crie  um sistema de menu em cada opção cadastre um item,
     Controlando o acesso do teclado
     */
    internal class Program
    {
        static int codigoFornecedor = 1;
        static void Main(string[] args)
        {
            int opcao = 1;

            while (opcao != 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"
                ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
                ████╗░████║██╔════╝████╗░██║██║░░░██║
                ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
                ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
                ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
                ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░"
        );
                Console.ResetColor();

                // Exibe os números em verde e o texto na cor padrão
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1 ");
                Console.ResetColor();
                Console.WriteLine("- Cadastro de cliente");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("2 ");
                Console.ResetColor();
                Console.WriteLine("- Código de fornecedor");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("3 ");
                Console.ResetColor();
                Console.WriteLine("- Cadastro de funcionario");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("4 ");
                Console.ResetColor();
                Console.WriteLine("- Cadastro de produto");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("5 ");
                Console.ResetColor();
                Console.WriteLine("- Cadastro de pedido");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0 ");
                Console.ResetColor();
                Console.WriteLine("- Sair do programa");

                Console.Write("\nEscolha uma das opções: ");

                //Try serve para comparar e eliminar textos
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção invalida, digite novamente");
                }

                switch (opcao) 
                {
                    case 1:
                        Cliente.CadastrarCliente();
                        break;
                    case 2:
                        CodigoFornecedor.cadastrarCodigo();
                        break;

                    case 3:
                        Funcionario.cadastrarFuncionario();
                        break;

                    case 4:
                        Produto.cadastrarProduto();
                        break;

                    case 5:
                        Pedido.cadastrarPedido();
                        break;

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Saindo do programa...");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                        
                }
                
                if (opcao != 0) 
                {
                    Console.Write("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }


            }

            }
    }
    }

