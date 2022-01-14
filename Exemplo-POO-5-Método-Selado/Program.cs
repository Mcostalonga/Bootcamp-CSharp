// See https://aka.ms/new-console-template for more information
// Testendo métodos "sealed". Nenhuma de suas classes filhas pode herdar ou sobrescrever o método.
using Exemplo_POO_5_Método_Selado.Models;

// Neste exemplo, podemos verificar que não é possível sobrescrever o método "Apresentar" da
// classe "Diretor" porquê a função herdada é "sealed" na classe "Professor".
// Logo, não será possível obter rodar o script.

namespace Exemplo_POO_5_Método_Selado
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor();
            p1.Nome = "Juca";
            p1.Idade = 30;
            p1.salario = 3000;
            p1.Apresentar();

            Diretor p2 = new Diretor();
            p2.Nome = "José";
            p2.Idade = 40;
            p2.salario = 9000;
            p2.Apresentar();
        }
    }
}


