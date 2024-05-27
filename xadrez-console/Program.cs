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
            PosicaoXadrez pos = new PosicaoXadrez('C', 7);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
