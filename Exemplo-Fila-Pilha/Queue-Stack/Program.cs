using Queue_Stack.Helper;

// Instanciando OperacoesFile
OperacoesFila opFila = new OperacoesFila();

// Trabalhando com filas (queues)
// A declaração de filas (queues) funciona como a lista. Podemos declarar alguns valores na inicialização.
Queue<string> fila = new Queue<string>();

// Imprimindo o tamanho da fila atual:
opFila.ContarFila(fila);

// Adicionando elementos na fila
// Adicionando um único elemento:
fila.Enqueue("Alex");
opFila.ContarFila(fila);

// Adicionando mais elementos:
fila.Enqueue("Bárbara");
fila.Enqueue("Camila");
opFila.ContarFila(fila);

// Removendo elementos da fila (FIFO - First in, First out)
Console.WriteLine("\nRemovendo pessoas da fila.");

while (fila.Count > 0)
{
    Console.WriteLine($"\nVez de: {fila.Peek()}.");
    Console.WriteLine($"{fila.Dequeue()} atendido(a).");
    opFila.ContarFila(fila);
}

// Trabalhando com pilhas (stacks)
// A declaração de pilha (stacks) funciona como a lista. Podemos declarar alguns valores na inicialização.
Stack<string> pilha = new Stack<string>();

// Adicionando elementos à pilha.
pilha.Push(".NET");
pilha.Push("DDD");
pilha.Push("Código limpo");

// Removento elementos da pilha (FILO - First in, Last Out);
Console.WriteLine($"\nLivros para leitura: {pilha.Count}.");
while (pilha.Count > 0)
{
    Console.WriteLine($"\nPróximo livro para leitura: {pilha.Peek()}");
    Console.WriteLine($"{pilha.Pop()} lido com sucesso.");
}
Console.WriteLine($"\nLivros para leitura: {pilha.Count}.");