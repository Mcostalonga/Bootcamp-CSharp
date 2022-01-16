// DESAFIO 02
// Você terá o desafio de escrever um algoritmo que leia 2 números e imprima 
//o resultado da divisão do primeiro pelo segundo. Caso não for possível, 
//mostre a mensagem “divisao impossivel” para os valores em questão.

//Entrada
//A entrada contém um número inteiro N. Este N será a quantidade de pares de
//valores inteiros (X e Y) que serão lidos em seguida.

//Saída
//Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal,
//ou “divisao impossivel” caso não seja possível efetuar o cálculo.

using System.Globalization;

namespace Desafio02
{
    class Program
    {
        static void Main()
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();    
            setPrecision.NumberDecimalDigits = 1;
            double X = 0;
            double Y = 0;
            double divisao = 0;
            Console.WriteLine("\nInforme o número de pares: ");
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                Console.WriteLine($"\nPar {i+1}: Informe os números separados por espaço: ");
                string[] line = Console.ReadLine().Split(" ");
                if (line.Length > 1)
                {
                    X = double.Parse(line[0]);
                    Y = double.Parse(line[1]);
                    divisao = X / Y;
                }
                else
                {
                    int y = 0;
                    Y = y;
                }

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                } 
                else 
                {
                    Console.WriteLine(divisao.ToString("N", setPrecision));
                }
            }
            Console.WriteLine("\nPrograma encerrado.");
        }
    }
}