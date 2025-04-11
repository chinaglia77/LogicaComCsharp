using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace MenuExercicios
{
    //Realizar um menu e executar todos os exercicios realizados em C#
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcaoMenu = 1;

            while (opcaoMenu != 0) 
            {
                Console.Clear();
                Console.WriteLine(@"
███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗  ██████╗░███████╗
████╗░████║██╔════╝████╗░██║██║░░░██║  ██╔══██╗██╔════╝
██╔████╔██║█████╗░░██╔██╗██║██║░░░██║  ██║░░██║█████╗░░
██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║  ██║░░██║██╔══╝░░
██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝  ██████╔╝███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░  ╚═════╝░╚══════╝

███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗░█████╗░██╗░█████╗░░██████╗
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║██╔══██╗██║██╔══██╗██╔════╝
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║██║░░╚═╝██║██║░░██║╚█████╗░
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║██║░░██╗██║██║░░██║░╚═══██╗
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║╚█████╔╝██║╚█████╔╝██████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░╚════╝░╚═╝░╚════╝░╚═════╝░
");
                EscreverMenu(1, "Ano Bissexto");
                EscreverMenu(2, "Calcular desconto da loja");
                EscreverMenu(3, "Comparar dois numeros");
                EscreverMenu(4, "Compra de ingressos");
                EscreverMenu(5, "Descobrir o dia da semana");
                EscreverMenu(6, "Encontrar menor numero");
                EscreverMenu(7, "Idade para dirigir");
                EscreverMenu(8, "Menor entre 3 numeros");
                EscreverMenu(9, "Maioridade penal");
                EscreverMenu(10, "Media da nota");
                EscreverMenu(11, "Notas de dinheiro");
                EscreverMenu(12, "Numero positivo ou negativo");
                EscreverMenu(13, "Posição de um numero");
                EscreverMenu(14, "Verificar multiplo de 3 ou 5");
                EscreverMenu(15, "Verificar perna maior");
                EscreverMenu(16, "Verificar senha do usuario");
                EscreverMenu(17, "Verificar temperatura");
                EscreverMenu(18, "Verificar triangulo");
                EscreverMenu(19, "Maior numero entre 20 numeros");
                EscreverMenu(20, "Ano de nascimento com idade");
                EscreverMenu(21, "Estoque de vinho");
                EscreverMenu(22, "Fabrica de peças");
                EscreverMenu(23, "Jogo da adivinhação");
                EscreverMenu(24, "Numeros impares");
                EscreverMenu(25, "Numeros Pares");
                EscreverMenu(26, "Altura francisco");
                EscreverMenu(27, "Calcular IMC");
                EscreverMenu(28, "Fahrenheit Celsius");
                EscreverMenu(29, "Formas de pagamento");
                EscreverMenu(30, "Quantidade de anos");
                EscreverMenu(31, "Quantidade de combustivel");
                EscreverMenu(32, "Quantidade de salario minimo");
                EscreverMenu(33, "Reajuste 5%");
                EscreverMenu(34, "Salario liquido");
                EscreverMenu(35, "Soma ou multiplicação");
                EscreverMenu(36, "Trocar variaveis");
                EscreverMenu(37, "Valores boolean");
                EscreverMenu(0, "Sair do programa");

                Console.ResetColor();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Selecione sua opção: ");
                Console.ResetColor();

                while (!int.TryParse(Console.ReadLine(), out opcaoMenu) || opcaoMenu < 0 || opcaoMenu >38) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Dado invalido, tente novamente");
                    Console.ResetColor();
                }

                switch (opcaoMenu)
                {
                    case 1:
                        AnoBissexto.encontrarAnoBissexto();
                        break;
                    case 2:
                        DescontoLoja.descontoDaLoja();
                        break;
                    case 3:
                        CompararDoisNumeros.CompararNumeros();
                        break;
                    case 4:
                        CompraIngresso.ComprarIngresso();
                        break;
                    case 5:
                        DiaSemana.encontrarDiaSemana();
                        break;
                    case 6:
                        EncontrarMenorNumero.menorNumero();
                        break;
                    case 7:
                        IdadeDirigir.idadeParaDirigir();
                        break;
                    case 8:
                        MenorEntreTresNumeros.menorEntreTresNumeros();
                        break;
                    case 9:
                        MaioridadePenal.maioridadePenal();
                        break;
                    case 10:
                        MediaNota.mediaNota();
                        break;
                    case 11:
                        NotasDinheiho.notasDinheiro();
                        break;
                    case 12:
                        NumeroPositivoNegativo.numeroPositivoNegativo();
                        break;
                    case 13:
                        PosicaoNumero.posicaoNumero();
                        break;
                    case 14:
                        MultiploCincoOuTres.multiplos();
                        break;
                    case 15:
                        PernaMaior.verificarPernaMaior();
                        break;
                    case 16:
                        SenhaUsuario.verificarSenha();
                        break;
                    case 17:
                        Temperatura.verificarTemperatura();
                        break;
                    case 18:
                        Triangulo.verificarTriangulo();
                        break;
                    case 19:
                        MaiorEntreVinteNumeros.encontrarMaiorNumero();
                        break;
                    case 20:
                        AnoNascimento.encontrarIdade();
                        break;
                    case 21:
                        EstoqueVinho.controleVinho();
                        break;
                    case 22:
                        FabricaPecas.aprovarPecas();
                        break;
                    case 23:
                        JogoAdivinhacao.iniciarJogo();
                        break;
                    case 24:
                        NumerosImpares.impares();
                        break;
                    case 25:
                        NumerosPares.Pares();
                        break;
                    case 26:
                        AlturaFrancisco.altura();
                        break;
                    case 27:
                        CalcularIMC.Imc();
                        break;
                    case 28:
                        fahrenheit.converterTemperatura();
                        break;
                    case 29:
                        FormasPagamento.formaPagamento();
                        break;
                    case 30:
                        QuantidadeAnos.qunatidadeAnos();
                        break;
                    case 31:
                        QuantidadeCombustivel.qtdCombustivel();
                        break;
                    case 32:
                        QuantidadeSalarioMinimo.SalarioMinimo();
                        break;
                    case 33:
                        ReajusteCincoPorcento.Reajuste();
                        break;
                    case 34:
                        SalarioLiquido.salario();
                        break;
                    case 35:
                        SomaOuMultiplicacao.opcaoCalculo();
                        break;
                    case 36:
                        TrocarVariaveis.trocarVarivel();
                        break;
                    case 37:
                        ValoresBoolean.ValorBoolean();
                        break;
                    case 0:
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Saindo do programa");
                        for (int i = 0; i <= 3; i++) 
                        {
                            Thread.Sleep(400);
                            Console.Write(".");
                        }
                        Console.ResetColor();
                        break;
                    default:
                        break;
                }

                if (opcaoMenu != 0) 
                {
                    Console.WriteLine();
                    Console.Write("Pressione qualquer tecla para continuar: ");
                    Console.ReadKey();
                }
            }

        }
        static void EscreverMenu(int numero, string descricao)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{numero} - ");
            Console.ResetColor();
            Console.WriteLine(descricao);
        }
    }
}
