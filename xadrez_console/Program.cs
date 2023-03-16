using Tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro.Tabuleiro tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tabuleiro);

            Console.WriteLine();
        }
    }
}