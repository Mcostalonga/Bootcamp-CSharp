namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }
        public override void Apresentar() // Usado para sobrescrever o método "Apresentar" que herdou de "Pessoa"
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor e recebo R$ {salario} mensalmente.");
        }
    }
}