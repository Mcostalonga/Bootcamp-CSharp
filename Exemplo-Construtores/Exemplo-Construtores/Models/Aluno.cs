namespace Exemplo_Construtores.Models
{
    public class Aluno : Pessoa // Herdando 
    {
        public Aluno(string nome, string sobrenome, string disciplina) : base(nome, sobrenome)
        {
            Console.WriteLine("Construtor classe aluno");
        }
    }
}