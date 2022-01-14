namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }
        public void DizerSalario()
        {
            Console.WriteLine($"{Nome} recebe R$ {salario} mensalmente.");
        }
    }
}