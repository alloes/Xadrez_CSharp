﻿namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        public Peca Peca(Posicao posicao)
        {
            return pecas[posicao.linha, posicao.coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                throw new TabuleiroException("Esta posição esta ocupada!");
            }
            pecas[posicao.linha, posicao.coluna] = peca;
            peca.posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (Peca(posicao) == null)
            {
                return null;
            }
            Peca aux = Peca(posicao);
            aux.posicao = null;
            pecas[posicao.linha, posicao.coluna] = null;
            return aux;
        }
        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            if (posicao.linha < 0 || posicao.linha >= linhas || posicao.coluna < 0 || posicao.coluna >= colunas)
            {
                return false;
            }
            else { return true; }
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição inválida!");
            }
        }
    }
}
