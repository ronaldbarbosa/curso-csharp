using Xadrez;

namespace Projeto_Xadrez
{
    class Program
    {
        public static void Main(string[] args)
        {
            PosicaoXadrez posicaoXadrez = new PosicaoXadrez('a', 1);
            System.Console.WriteLine(posicaoXadrez);
            System.Console.WriteLine(posicaoXadrez.ToPosicao());
        }
    }
}