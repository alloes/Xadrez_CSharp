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
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Branca), new Posicao(2, 7));

                Tela.imprimirTabuleiro(tabuleiro);

                Console.WriteLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message); ;
            }

            //PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);

            //Console.WriteLine(posicaoXadrez);

            //Console.WriteLine(posicaoXadrez.toPosicao());

            //posicaoXadrez = new PosicaoXadrez('c', 4);

            //Console.WriteLine(posicaoXadrez);

            //Console.WriteLine(posicaoXadrez.toPosicao());

        }
    }
}