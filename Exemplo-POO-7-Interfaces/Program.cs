using Exemplo_POO_7_Interfaces.Interfaces;
using Exemplo_POO_7_Interfaces.Models;

// Usando uma interface que chama os métodos a partir da classe especificada.

namespace Exemplo_POO_7_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculadora calc = new Calculadora();
            Console.WriteLine($"A soma é: {calc.Somar(10,20)}");
            Console.WriteLine($"A divisão é: {calc.Dividir(10,20)}");
        }
    }
}