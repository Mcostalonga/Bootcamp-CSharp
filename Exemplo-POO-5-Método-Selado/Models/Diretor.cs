namespace Exemplo_POO_5_Método_Selado.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar() // Erro, pois a função herdade da classe "Professor" é "sealed".
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou diretor e recebo R$ {salario} mensalmente.");
        } 
    }
}