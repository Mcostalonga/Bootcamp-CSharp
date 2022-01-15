
namespace ExemploColections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInteiros = new int[3];

            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                arrayInteiros[i] = i * 10;
            }

            Console.WriteLine("Imprimindo o array usando o for:");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }

            Console.WriteLine("Imprimindo o array usando o foreach:");
            foreach (var item in arrayInteiros)
            {
                Console.WriteLine(item);
            }

            int[,] matriz = new int[4,2] // Podemos declarar os elementos da forma abaixo. matriz[linha, coluna]
            {
                {8, 16},
                {4, 8},
                {2, 4},
                {1, 2}
            };

            Console.WriteLine("Imprimindo a matriz usando o for:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Linha {i}, Coluna {j} = {matriz[i,j]}");
                }
            }
            
        }
    }
}