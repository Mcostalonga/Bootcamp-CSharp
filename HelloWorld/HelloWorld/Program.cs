// See https://aka.ms/new-console-template for more information
// Segundo a documentação, a partir do .NET 6, novos projetos C# usando o console modelo
// geram código diferente das versões anteriores:

Console.WriteLine("Hello, World!");

//A nova saída usa recursos recentes do C# que simplificam o código que você precisa
//escrever para um programa. Tradicionalmente, o modelo de aplicativo de console
//gerou o seguinte código:

//using System;

//namespace MyApp // Note: actual namespace depends on the project name.
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

// Podemos declarar variáveis:

string a = "Hello, ";
string b = "World!";

// Concatenando as strings:

string c = a + b;

// Imprimindo novamente a frase a partir da variável string "c"

Console.WriteLine(c + " (Podemos concatenar a string dentro da função para imrprimir)");