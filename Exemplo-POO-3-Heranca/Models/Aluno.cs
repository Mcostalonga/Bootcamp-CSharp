namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public void DizerNota()
        {
            Console.WriteLine($"{Nome} e tirou a nota {Nota} na prova.");
        }
    }
}