namespace AlgoritmoOrdenar.Helper
{
    public class OperacoesArray
    {
        bool existe = false;
        public void ImprimirArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {array[i]}");
            }
        }
        public void BubbleSort(ref int[] array) //ref retornará o mesmo array (não cria uma nova variável)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }
        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
        public bool Existe(int[] array, int number)
        {
            return Array.Exists(array, elemento => elemento == number);
            //return Array.Exists(array, elemento => elemento >= number); Verifica se existe um valor maior ou igual ao valor escolhido
        }
        public bool TodosMaiorQue(int[] array, int number)
        {
            return Array.TrueForAll(array, elemento  => elemento >= number);
        }
        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, elemento => elemento == valor);
            // Array.Find retorna a primeira ocorrência do valor procurado
            // Array.FindAll retorna um array com todos os valores procurados
            // ArrayIndex retorna a posição do valor buscado dentro do array
            // Array.FindLast retorna o útlimo valor encontrado
            // Array.FindLastIndex retorna a posição do último valor encontrado
        }
        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }
        public void Redimensionar(ref int[] array, int novoTamanho)
        {
            Array.Resize(ref array, novoTamanho);
        }
        public string[] ConverterParaString(int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}