// DESAFIO 03
// Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido
// o valor de seu raio (R). A fórmula para calcular o volume é: (4/3) * pi * R3.
// Considere (atribua) para pi o valor 3.14159.

// Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3),
// pois algumas linguagens (dentre elas o C++), assumem que o resultado da
// divisão entre dois inteiros é outro inteiro.

// Entrada
// O arquivo de entrada contém um valor de ponto flutuante (dupla precisão),
// correspondente ao raio da esfera.

// Saída
// A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.

using System.Globalization;

namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            
            NumberFormatInfo setPrecision = new NumberFormatInfo();    
            setPrecision.NumberDecimalDigits = 3;
            Console.WriteLine("Informe o valor do raio da esfera: ");
            raio = double.Parse(Console.ReadLine());
            volume = 4 * pi * Math.Pow(raio, 3) / 3;
            string volumestring = volume.ToString("N", setPrecision).Replace(",", "");
            Console.WriteLine($"VOLUME = {volumestring}");
        }
    }
}