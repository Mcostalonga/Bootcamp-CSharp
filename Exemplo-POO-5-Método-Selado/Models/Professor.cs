namespace Exemplo_POO_5_Método_Selado.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou professor e recebo R$ {salario} mensalmente.");
        }
    }
}