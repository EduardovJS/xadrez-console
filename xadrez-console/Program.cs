using System;
using Tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro_ tab = new Tabuleiro_(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(1, 3));

    
            
            Tela.imprimirTabuleiro(tab);
        }
    }
}
