namespace Exemplo_Delegate.Models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            Console.WriteLine($"Adição: {x} + {y} = {x + y}");
        }
        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtração: {x} - {y} = {x - y}");
        }
    }
}