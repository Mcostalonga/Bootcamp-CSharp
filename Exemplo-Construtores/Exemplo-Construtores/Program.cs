using Exemplo_Construtores.Models;

namespace Exemplo_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um construtor público    

            // Pessoa p1 = new Pessoa(); // Construtor "Padrão": instancia todas as propriedades com um valor nulo, vazio ou zero.
            // p1.Apresentar();
            Pessoa p2 = new Pessoa("João", "Silva");
            p2.Apresentar();

            // Tentando instanciar um construtor privado

            Log log = Log.GetInstance();
            log.PropriedadeLog = "Teste instância";

            Log log2 = Log.GetInstance();
            Console.WriteLine(log2.PropriedadeLog);

            // Herança - Construtores

            Aluno p3 = new Aluno("Juca", "Zeferino", "C#");
            p3.Apresentar();
        }
    }
}