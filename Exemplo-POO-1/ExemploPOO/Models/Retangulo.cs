namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        public void DefinirMedidas(double comprimento, double largura)
        {
            this.comprimento = comprimento;
            this.largura = largura;
        }
        public double ObterArea()
        {
            return comprimento * largura;
        }
    }
}