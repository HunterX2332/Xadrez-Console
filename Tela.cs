﻿using System;
using tabuleiro;

namespace Xadrez_Console
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    
                    if (tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else {
                        imprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void imprimirPeca(Peca peca) 
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
        }
    }
}
