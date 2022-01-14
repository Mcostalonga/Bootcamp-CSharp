namespace Exemplo_POO_4.Models
{
    public class Corrente : Conta // Herdar de "Conta"
    {
        public override void Creditar(double valor)
        {
            base.saldo = base.saldo + valor;
        }
    }
}