using tabuleiro;

namespace xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] posicoesPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // NO
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            }

            // NE
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;
                posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            }

            // SE
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            }
            
            // SO
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor) break;
                posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            }

            return posicoesPossiveis;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}