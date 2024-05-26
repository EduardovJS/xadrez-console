using System;
using Tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro_ tab = new Tabuleiro_(8, 8);    
            
            Tela.imprimirTabuleiro(tab);
        }
    }
}
