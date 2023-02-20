using Xadrez;

namespace Projeto_Xadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);

            tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}