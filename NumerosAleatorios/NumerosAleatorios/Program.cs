using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    internal class Program
    {

        public class Ficha
        {
            public string nomeDoJogador;
            public string nomeDoPersonagem;
            public string raca;
            public string classe;
            public int vida;

            public void imprimirFicha()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Nome do jogador: ");
                Console.ResetColor();
                Console.WriteLine(nomeDoJogador);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Nome do personagem: ");
                Console.ResetColor();
                Console.WriteLine(nomeDoPersonagem);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Raça: ");
                Console.ResetColor();
                Console.WriteLine(raca);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Classe: ");
                Console.ResetColor();
                Console.WriteLine(classe);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Vida: ");
                Console.ResetColor();
                Console.WriteLine(vida);
            }

        }

        static void Main(string[] args)
        {
            Random random = new Random();
            string nomeJogador;
            string nomePersonagem;
            string raca;
            string classe;

            int d6Jogador = random.Next(1, 6);
            int d6Inimigo = random.Next(1, 6);

            Ficha personagemPrincipal = new Ficha();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome do jogador: ");
            Console.ResetColor();
            nomeJogador = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nome do personagem: ");
            Console.ResetColor();
            nomePersonagem = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Raça: ");
            Console.ResetColor();
            raca = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Classe: ");
            Console.ResetColor();
            classe = Console.ReadLine();

            Console.Clear();

            personagemPrincipal.nomeDoJogador = nomeJogador;
            personagemPrincipal.nomeDoPersonagem = nomePersonagem;
            personagemPrincipal.raca = raca;
            personagemPrincipal.classe = classe;
            personagemPrincipal.vida = 100;

            //imprimir a ficha
            personagemPrincipal.imprimirFicha();

            Console.WriteLine("\n======AVENTURA COMEÇA======");
            Console.WriteLine("Você esta bebendo em uma taverna");
            Console.WriteLine("Uma pessoa esbarra em você. O que você faz?\n[ 1 ] se vira \n[ 2 ] continua como se nada fosse");

            string decisao = Console.ReadLine();

            if (decisao == "1")
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("Agora começa a treta !");

                Ficha inimigo = new Ficha();
                inimigo.nomeDoJogador = "NPC";
                inimigo.nomeDoPersonagem = "Baltazar";
                inimigo.raca = "ORC";
                inimigo.classe = "Ladrão";
                inimigo.vida = 50;

                while (inimigo.vida > 0 && personagemPrincipal.vida > 0)
                {
                    //Rola os dados
                    d6Jogador = random.Next(1, 6);
                    d6Inimigo = random.Next(1, 6);

                    //Comparo os valores
                    if (d6Jogador > d6Inimigo)
                    {
                        inimigo.vida -= 10;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Boa, consegui acertar");
                        Console.ResetColor();
                    }
                    else if (d6Jogador < d6Inimigo)
                    {
                        personagemPrincipal.vida -= 10;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eita, essa doeu");
                        Console.ResetColor();

                        Console.Write("Gostaria de fugir da luta [ S ] / [ N ]: ");
                        string fugirLuta = Console.ReadLine();

                        if (fugirLuta.ToUpper() == "S")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Fugiu com sucesso");
                            Console.ResetColor();
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Nada acontece");
                    }
                    //Pausa para exibir
                    Thread.Sleep(1500);

                }
                if (personagemPrincipal.vida < 0)
                {
                    Console.WriteLine("Você morreu !");
                }
                else if (inimigo.vida < 0)
                {
                    {
                        Console.WriteLine("Você ganhou, matou o inimigo");
                    }

                    Console.WriteLine("\nVida do jogador: " + personagemPrincipal.vida);
                    Console.WriteLine("Vida do inimigo:  " + inimigo.vida);
                }


            }
            else
            {
                Console.WriteLine("Você continua a beber");
            }

            Thread.Sleep(2000);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{nomePersonagem} tome cuidado !");
            Console.ResetColor();

            Thread.Sleep(2000);

            Console.WriteLine("Parceiro do baltazar apareceu e quer lutar com você");
            Console.Write("Deseja lutar ou fugir. [S] / [N]: ");
            string opcaoLuta = Console.ReadLine();

            if (opcaoLuta.ToUpper() == "S") 
            {
                Console.Clear();
                Console.WriteLine("Luta iniciada !");
                Ficha chefaoInimigo = new Ficha();

                chefaoInimigo.nomeDoPersonagem = "Kairo";
                chefaoInimigo.raca = "Demonio";
                chefaoInimigo.classe = "Guerreiro";
                chefaoInimigo.vida = 200;

                d6Inimigo = random.Next(1, 6);
                d6Jogador = random.Next(1, 6);

                if (d6Jogador < d6Inimigo) 
                {
                    personagemPrincipal.vida -= 15;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Eita, essa doeu");
                    Console.ResetColor();

                }
            }
        }
    }
}
