// See https://aka.ms/new-console-template for more information
using Exemplo_POO_4.Models;

namespace Exemplo_POO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Corrente c = new Corrente();
            c.Creditar(100);
            c.ExibirSaldo();

        }
    }
}
