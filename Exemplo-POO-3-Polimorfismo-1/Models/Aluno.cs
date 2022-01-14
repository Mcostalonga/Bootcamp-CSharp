namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public override void Apresentar() // Usado para sobrescrever o método "Apresentar" que herdou de "Pessoa"
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou aluno e tirei {Nota} na prova.");
        }
    }
}