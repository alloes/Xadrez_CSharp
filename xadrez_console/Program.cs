using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.putPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 7));

            Tela.imprimirTabuleiro(tabuleiro);

            Console.WriteLine();
        }
    }
}