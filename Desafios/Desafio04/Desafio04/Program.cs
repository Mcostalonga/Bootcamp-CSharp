// DESAFIO 04
// Kogu está buscando as esferas do dragão para invocar Xenlonguinho
// e pedir para ele reviver seu amigo Kuriri, que infelizmente morreu
// na última batalha dos guerreiros Zê.
// Porém Kogu está tendo muita dificuldade para encontrar as esferas,
// por isso Xenlonguinho que é seu conhecido há muito tempo, decidiu abrir
// uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas cujo
// o número de divisores da quantidade de estrelas da esfera sejam par.
// Por exemplo se existem sete esferas, Kogu não precisaria encontrar as 
// esferas de uma e quatro estrelas, pois elas tem uma quantidade ímpar de divisores,
// então ele só precisa pegar 5 esferas para invocar Xenlonguinho.
// Como Kogu não é muito bom em contas, ele pediu para você escrever
// um programa que dado o total de esferas existentes, mostre a quantidade
// mínima de esferas que ele precisa procurar.

// Entrada
//A primeira linha consiste de um inteiro C que representa a quantidade de casos
// de teste. As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 1000) que representa
// a quantidade de esferas necessárias para invocar Xenlonguinho.

//Saída
//Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int C, N;
            List<int> divLista = new List<int>();
            List<int> isokLista = new List<int>();
            int cont = 0;

            for (int i = 0; i < 2001; i++)
            {
                divLista.Add(0);
                isokLista.Add(0);
                cont = 0;
                for (int j = i; j > 0; j--)
                {
                    if(i % j == 0)
                    {
                        cont++;
                    }
                }
                if (cont % 2 != 0)
                {
                    divLista[i] = 1;
                }
                for (int j = i; j > 0; j--)
                {
                    if (divLista[j] == 0)
                    {
                        isokLista[i]++;
                    }
                }
            }
            C = Int32.Parse(Console.ReadLine());
            while(C > 0)
            {
                C--;
                N = Int32.Parse(Console.ReadLine());
                Console.WriteLine(isokLista[N]);
            }
        }
    }
}