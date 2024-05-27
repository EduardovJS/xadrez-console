using System;
using tabuleiro;
using Tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro_ tab = new Tabuleiro_(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 0));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 0));
                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
