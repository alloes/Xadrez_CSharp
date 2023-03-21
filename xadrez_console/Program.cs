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
                PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez();

                while (!partidaDeXadrez.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().toPosicao();

                    bool[,] posicoesPossiveis = partidaDeXadrez.tabuleiro.Peca(origem).MovimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro, posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().toPosicao();

                    partidaDeXadrez.executarMovimento(origem, destino);
                }


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