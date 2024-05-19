using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    internal class Tela
    {
        public static void imprimirPartida(PartidaDeXadrez partida)
        {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine("Turno: " + partida.turno);
            Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
            if (partida.xeque)
            {
                Console.WriteLine("XEQUE!");
            }
        }
        public static void imprimirPecasCapturadas(PartidaDeXadrez partida)
        {
            Console.WriteLine("Peças capturadas: ");

            Console.Write("Brancas: ");
            ConsoleColor aux = Console.ForegroundColor;
            ConsoleColor aux2 = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.ForegroundColor = aux;
            Console.BackgroundColor = aux2;
            
            Console.Write("Pretas: ");
            ConsoleColor aux3 = Console.ForegroundColor;
            ConsoleColor aux4 = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux3;
            Console.BackgroundColor = aux4;
            
            Console.WriteLine();
        }
        public static void imprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach (Peca x in conjunto)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("]");
        }
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                        imprimirPeca(tab.peca(i, j));
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkYellow;


            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (posicoesPossiveis[i, j])
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor= fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;

                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
            Console.BackgroundColor = fundoOriginal;
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }

        public static void imprimirPeca(Peca peca) 
        { 
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.cor == Cor.Branca)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    ConsoleColor aux2 = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                    Console.BackgroundColor = aux2;
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    ConsoleColor aux2 = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                    Console.BackgroundColor = aux2;
                }
                Console.Write(" ");
            }      
        }
    }
}
