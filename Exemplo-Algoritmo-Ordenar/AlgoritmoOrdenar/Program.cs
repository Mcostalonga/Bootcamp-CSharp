using AlgoritmoOrdenar.Helper;

// Instanciando a classe "OperacoesArray"
OperacoesArray op = new OperacoesArray();

// Declarando o array
int[] arrayInteiros = {3, 5, 1, 7, 9};
int[] array2 = {2, 5, 6, 9, 10, 12};
int[] arrayCopia = new int[10];
int valorProcurado = 1;
int valorReferencia = 1;
bool existe = op.Existe(arrayInteiros, valorProcurado);
bool todosMaiorQue = op.TodosMaiorQue(arrayInteiros, valorReferencia);

Console.WriteLine("\nArray Original:");
op.ImprimirArray(arrayInteiros);

// Aplicando o algoritmo Bubble sort para ordenar o array
op.BubbleSort(ref arrayInteiros);

Console.WriteLine("\nArray ordenado (Bubble sort implementado):");
op.ImprimirArray(arrayInteiros);

// Aplicando o método que usa a classe Array para ordenar o array.
op.Ordenar(ref arrayInteiros);

Console.WriteLine("\nArray ordenado (Classe Array):");
op.ImprimirArray(arrayInteiros);

// Imprimindo o array que irá receber as informações de outro array
Console.WriteLine("\nArray antes da cópia:");
op.ImprimirArray(arrayCopia);

// Copiando um array para outro
op.Copiar(ref arrayInteiros, ref arrayCopia);
Console.WriteLine($"\nArray depois da cópia:");
op.ImprimirArray(arrayCopia);

// Verificando se um número existe dentro de um array
if (existe)
{
    Console.WriteLine($"O valor {valorProcurado} existe dentro do array escolhido.");
}
else
{
    Console.WriteLine($"O valor {valorProcurado} não existe dentro do array escolhido.");
}

// Verificando se todos os números dentro do array indicado são maiores ou iguais ao número escolhido
if (todosMaiorQue)
{
    Console.WriteLine($"Todos os números são maios que {valorReferencia}.");
}
else
{
    Console.WriteLine($"Nem todos os valores são maiores ou iguais a {valorReferencia}.");
}

// Buscar um valor no vetor.
int valorBuscado = 7;
int valorAchado = op.ObterValor(arrayInteiros, valorBuscado);
if (valorAchado > 0)
{
    Console.WriteLine($"Encontrei o valor {valorBuscado} dentro do array.");
}
else
{
    Console.WriteLine($"Não encontrei o valor {valorBuscado} dentro do array.");
}

// Buscar um valor no vetor.
int posicaoValorBuscado = op.ObterIndice(arrayInteiros, valorBuscado);
if (posicaoValorBuscado > -1)
{
    Console.WriteLine($"O valor {valorBuscado} está na posição {posicaoValorBuscado} dentro do array.");
}
else
{
    Console.WriteLine($"Não encontrei o valor {valorBuscado} dentro do array.");
}

// Redimensionando o array "array2"
int novoTamanhoArray2 = 8;
Console.WriteLine($"Capacidade atual do array: {array2.Length}.");
op.Redimensionar(ref array2, novoTamanhoArray2);
Console.WriteLine($"Capacidade do array após o redimensionamento: {array2.Length}.");

// Convertendo valores do array para string
string[] arrayString = op.ConverterParaString(array2);
Console.WriteLine("\nImprimindo o array no formato string.");
foreach (var element in arrayString)
{
    Console.WriteLine(element);
}