namespace Listas.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<string> lista)
        {
            int i = 0;
            foreach (var item in lista)
            {
                Console.WriteLine($"Item {i}: {item}");
                i++;
            }
        }
    }
}