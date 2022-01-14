// See https://aka.ms/new-console-template for more information
// Usando polimorfismo em tempo de compilação (early binding).
using ExemploPOO.Models;
using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
        Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));
    }
    }
}


