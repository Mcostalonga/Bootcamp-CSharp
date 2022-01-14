// See https://aka.ms/new-console-template for more information
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();
            Retangulo r2 = new Retangulo();
            
            r1.DefinirMedidas(30, 30);
            Console.WriteLine($"A área do retangulo é igual a: {r1.ObterArea()} m².");

            r2.DefinirMedidas(-30, 30);
            Console.WriteLine($"A área do retangulo é igual a: {r2.ObterArea()} m².");
        }
    }
}
