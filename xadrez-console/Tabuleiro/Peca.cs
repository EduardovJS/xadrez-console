namespace Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }    
        public Cor cor { get; protected set; }  
        public int qteMovimentos { get; protected set; }
        public Tabuleiro_ tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro_ tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab; 
            this.cor = cor;
            this.qteMovimentos = 0; 
        }





    }
}
