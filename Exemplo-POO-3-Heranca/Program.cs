// See https://aka.ms/new-console-template for more information
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Bob";
            p1.Idade = 20;
            p1.Nota = 8;
            p1.Apresentar();
            p1.DizerNota();

            Professor p2 = new Professor();
            p2.Nome = "Juca";
            p2.Idade = 31;
            p2.salario = 3000.00;
            p2.Apresentar();
            p2.DizerSalario();
        }
    }
}