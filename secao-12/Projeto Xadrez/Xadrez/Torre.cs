using tabuleiro;

namespace xadrez 
{
    class Torre : Peca 
    {

        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) 
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

            // acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor) 
                {
                    break;
                }
                posicao.Linha = posicao.Linha - 1;
            }

            // abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor) 
                {
                    break;
                }
                posicao.Linha = posicao.Linha + 1;
            }

            // direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor) 
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna + 1;
            }

            // esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) 
            {
                posicoesPossiveis[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor) 
                {
                    break;
                }
                posicao.Coluna = posicao.Coluna - 1;
            }

            return posicoesPossiveis;
        }
        
        public override string ToString()
        {
            return "T";
        }
    }
}
