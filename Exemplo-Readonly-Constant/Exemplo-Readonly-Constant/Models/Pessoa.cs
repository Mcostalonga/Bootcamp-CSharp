namespace Exemplo_Readonly_Constant.Models
{
    public class Pessoa
    {
        private readonly string nome = "Nome de inicialização";
        private readonly string sobrenome;
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public void Apresentar()
        {
            // this.nome = "Teste"; // Não é possível atribuir valor para variáveis "readonly" a não ser pela inicialização ou pelo construtor.
            Console.WriteLine($"Olá, meu nome é {nome} {sobrenome}.");
        }
    }
}