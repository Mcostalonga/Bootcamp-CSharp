namespace Exemplo_POO_4.Models
{
    public abstract class Conta
    {
        protected double saldo = 100;
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + saldo);
        }
    }
}