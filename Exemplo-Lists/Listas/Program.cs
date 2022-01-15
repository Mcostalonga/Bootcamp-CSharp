using Listas.Helper;

// Instanciando "OperacoesLista"
OperacoesLista opLista = new OperacoesLista();

// Declarando listas: deve-se declarar o tipo de elemento que a lista tera entre <> e não é necessário
// declarar o tamanho da mesma.
List<string> estados = new List<string>();
string[] estadosArray = new string[2] {"SC", "MT"};

// Podemos atribuir valores à lista na sua inicialização.
// List<string> estados = new List<string> {"SP", "MG", "BA", "ES", "RJ"};

Console.WriteLine($"\nQuantidade de elementos da lista: {estados.Count}.");
// Adicionando elementos na lista
estados.Add("SP");
estados.Add("MG");
estados.Add("BA");
estados.Add("ES");
estados.Add("RJ");
// Verificando o tamanho da lista após a adição de elementos.
Console.WriteLine($"\nQuantidade de elementos da lista: {estados.Count}.");

// Imprimindo elementos da lista.
opLista.ImprimirListaString(estados);

// Remover elementos da lista
Console.WriteLine("\nRemovendo o elemento");
estados.Remove("MG");
// Imprimindo elementos da lista após remover "MG".
opLista.ImprimirListaString(estados);

// Adicionando elementos de uma lista2 na lista1, sem perder os elementos originais da lista1
Console.WriteLine("\nAdicionando novos elementos.");
estados.AddRange(estadosArray); // Adiciona todos os elementos do array na lista original presente em "estados"

// Imprimindo elementos da lista após remover "MG".
opLista.ImprimirListaString(estados);

// Adicionar elementos em índices específicos.
Console.WriteLine("\nAdicionando um novo elemento no índice 1.");
estados.Insert(1, "PA");

// Imprimindo elementos da lista após remover "MG".
opLista.ImprimirListaString(estados);

