namespace Queue_Stack.Helper
{
    public class OperacoesFila
    {
        public void ContarFila(Queue<string> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("\nNão existe ninguém na fila.");
            }
            else if (lista.Count == 1)
            {
                Console.WriteLine($"\nExiste {lista.Count} pessoa na fila.");
            }
            else
            {
                Console.WriteLine($"\nExistem {lista.Count} pessoas na fila.");
            }
        }
    }
}