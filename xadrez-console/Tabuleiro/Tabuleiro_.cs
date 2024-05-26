namespace Tabuleiro
{
    internal class Tabuleiro_
    {
        public int linhas { get; set; }
        public int coluans { get; set; }
        private Peca[,] pecas;


        public Tabuleiro_(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.coluans = colunas;
            pecas = new Peca[linhas, colunas];
        }
    }
}
