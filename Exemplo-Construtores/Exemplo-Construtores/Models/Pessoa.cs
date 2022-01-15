namespace Exemplo_Construtores.Models
{
    public class Pessoa // Classe Pessoa
    {
        private string nome;
        private string sobrenome;
        // public Pessoa() // Construtor Pesssoa (o construtor apresenta o mesmo nome da classe): Exemplo de construtor padrão
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }
        public Pessoa(string nome, string sobrenome) // Construtor Pessoa: necessita de dois parâmetros para instanciar a classe "Pessoa"
        // caso você defina um construtor, você precisar inserir os parâmetros indicados para instanciar a classe.
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            Console.WriteLine("Construtor classe pessoa");
        }

        public void Apresentar() // Método
        {
            Console.WriteLine($"Olá, o meu nome é {nome} {sobrenome}");
        }

    }
}