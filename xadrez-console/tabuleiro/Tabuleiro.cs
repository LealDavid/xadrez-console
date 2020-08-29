﻿namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            this.pecas = new Peca[linhas,colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            return this.pecas[linha,coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            this.pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }
    }
}
