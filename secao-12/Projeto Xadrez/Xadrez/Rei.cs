using tabuleiro;

namespace xadrez 
{
    class Rei : Peca 
    {
        private PartidaDeXadrez Partida;
        public Rei(Tabuleiro tab, Cor cor, PartidaDeXadrez partida) : base(tab, cor) 
        {
            Partida = partida;
        }

        private bool PodeMover(Posicao pos) 
        {
            Peca p = Tabuleiro.Peca(pos);
            return p == null || p.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.QteMovimentos ==0;
        }

        public override bool[,] MovimentosPossiveis() 
        {
            bool[,] posicoesPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // ne
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // se
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // so
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }
            // no
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            // Jogada especial: roque
            if (QteMovimentos == 0 && !Partida.Xeque)
            {
                // Roque pequeno
                Posicao posicaoT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posicaoT1))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if (Tabuleiro.Peca(posicao1) == null && Tabuleiro.Peca(posicao2) == null) posicoesPossiveis[Posicao.Linha, Posicao.Coluna + 2] = true;
                }

                // Roque grande
                Posicao posicaoT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posicaoT2))
                {
                    Posicao posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao posicao3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.Peca(posicao1) == null && Tabuleiro.Peca(posicao2) == null && Tabuleiro.Peca(posicao3) == null)
                    { 
                        posicoesPossiveis[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return posicoesPossiveis;
        }

        public override string ToString() 
        {
            return "R";
        }
    }
}
