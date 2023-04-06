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
                    try
                    {
                        Console.Clear();
                        Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partidaDeXadrez.turno);
                        Console.WriteLine("Aguardando jogada: " + partidaDeXadrez.jogadorAtual);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partidaDeXadrez.tabuleiro.Peca(origem).MovimentosPossiveis();
                        Console.Clear();
                        Tela.imprimirTabuleiro(partidaDeXadrez.tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partidaDeXadrez.validarPosicaoDeDestino(origem, destino);

                        partidaDeXadrez.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
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