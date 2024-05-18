﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
