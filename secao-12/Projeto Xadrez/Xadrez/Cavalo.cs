using tabuleiro;

namespace xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
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
            
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;

            return posicoesPossiveis;
        }

        public override string ToString()
        {
            return "C";
        }
    }
}