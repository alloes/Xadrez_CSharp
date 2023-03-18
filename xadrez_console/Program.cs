using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 2));
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(2, 3));

                Tela.imprimirTabuleiro(tabuleiro);

                Console.WriteLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }
        }
    }
}