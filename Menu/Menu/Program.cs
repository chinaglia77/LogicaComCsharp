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

                Console.WriteLine("\nMenu de cadastro\n");
                Console.WriteLine("1 - Cadastro de cliente");
                Console.WriteLine("2 - Código de fornecedor");
                Console.WriteLine("3 - Cadastro de funcionario");
                Console.WriteLine("4 - Cadastro de produto");
                Console.WriteLine("5 - Cadastro de pedido");
                Console.WriteLine("0 - Sair do programa");

                Console.Write("\nEscolha uma das opções: ");

                //Try serve para comparar e eliminar textos
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 5)
                {
                    Console.WriteLine("Opção invalida, digite novamente");
                }

                switch (opcao) 
                {
                    case 1:
                        CadastrarCliente();
                        break;
                    case 2:
                        cadastrarCodigo();
                        break;

                    case 3:
                        cadastrarFuncionario();
                        break;

                    case 4:
                        cadastrarProduto();
                        break;

                    case 5:
                        cadastrarPedido();
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
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }


            }

            }
        static void CadastrarCliente() 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCadastro Clientes");
            Console.ResetColor();
            Console.Write("Nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine($"Cliente {nomeCliente}, cadastrado com sucesso !");
        }

        static void cadastrarCodigo() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nCódigo do fornecedor");
            Console.ResetColor();

            Console.Write("Código do fornecedor: ");

            while (!int.TryParse(Console.ReadLine(), out codigoFornecedor))
            {
                Console.WriteLine("O codigo recebe apenas numeros, tente novamente...");
            }

            Console.WriteLine($"Codigo {codigoFornecedor}, cadastrado com sucesso !");
        }

        static void cadastrarFuncionario() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nCadastro funcionario");
            Console.ResetColor();
            Console.Write("Nome do funcionario: ");

            string nomeFuncionario = Console.ReadLine();

            Console.WriteLine($"Funcionario {nomeFuncionario}, cadastrado com sucesso !");
        }

        static void cadastrarProduto()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nCadastro produto");
            Console.ResetColor();
            Console.Write("Nome do produto: ");

            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"Produto {nomeProduto}, cadastrado com sucesso !");
        }
        
        static void cadastrarPedido() 
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nCadastro de pedido");
            Console.ResetColor();

            Console.Write("Cadastro do pedido: ");
            string cadastroPedido = Console.ReadLine();

            Console.WriteLine($"Pedido {cadastroPedido}, cadastrado com sucesso !");
        }
    }
    }

