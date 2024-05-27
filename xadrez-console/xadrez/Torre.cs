using Tabuleiro;


namespace xadrez
{
    internal class Torre : Peca
    {
        public Torre(Tabuleiro_ tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }

    }
}
