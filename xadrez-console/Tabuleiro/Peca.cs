namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }    
        public Cor cor { get; protected set; }  
        public int qteMovimentos { get; protected set; }
        public Tabuleiro_ tab { get; protected set; }

        public Peca(Tabuleiro_ tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab; 
            this.cor = cor;
            this.qteMovimentos = 0; 
        }





    }
}
