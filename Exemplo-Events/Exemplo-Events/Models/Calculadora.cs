namespace Exemplo_Events.Models
{
    public class Calculadora
    {
        // Antes de declarar um evento, deve-se declarar um delegate.
        // Delegate:
        public delegate void DelegateCalculadora();
        // Evento:
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                Console.WriteLine($"Adição: {x} + {y} = {x + y}");
                EventoCalculadora();
            }
            else
            {
                Console.WriteLine("Nenhum inscrito.");
            }            
        }
        public static void Subtrair(int x, int y)
        {
            Console.WriteLine($"Subtracao: {x} - {y} = {x - y}");
        }
    }
}