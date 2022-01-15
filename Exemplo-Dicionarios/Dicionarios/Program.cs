// .NET 6.0
// Trabalhando com dicionários (Dictionaries)

// Declarando um dicionário. Podemos inicializar com valores, como nas listas, filas e pilhas.
Dictionary<string, string> estados = new Dictionary<string, string>();
Dictionary<string, List<string>> dicEstados = new Dictionary<string, List<string>>();

// Adicionando valores ao dicionário. Usando Add(CHAVE, VALOR)
estados.Add("SP", "São Paulo");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

Console.WriteLine("\nImprimindo o dicionário original.");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
}

// Retornando o valor de uma chave procurada.
string valorProcurado = "BA";
Console.WriteLine($"\nBuscando o valor associado à chave: {valorProcurado}.");
Console.WriteLine(estados[valorProcurado]);

// Atualizar o valor de um dicionando:
Console.WriteLine($"\nValor original: {estados[valorProcurado]}.");

estados[valorProcurado] = "BA - valor atualizado"; // Atualiazando o valor em si.

Console.WriteLine($"\nValor atualizado: {estados[valorProcurado]}.");

// Removendo um elemento do dicionário:
Console.WriteLine($"\nRemovendo o valor associado à chave: {valorProcurado}.");
estados.Remove(valorProcurado);

Console.WriteLine($"\nImprimindo o dicionário após remover a chave {valorProcurado}.");
foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}.");
}

// Acessando o dicionário de maneira segura
if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
{
    Console.WriteLine($"O valor associado à chave {valorProcurado} é : {estadoEncontrado}.");
}
else
{
    Console.WriteLine($"Chave {valorProcurado} não existe no dicionário.");
}

// Teste dicionário: Criando dicionário com valores na forma de listas e imprimindo as informações de cada chave.
string Chave1 = "Sigla";
List<string> listaSiglas = new List<string> {"SP", "MG", "BA"};

string Chave2 = "Nome do estado";
List<string> listaNomes = new List<string> {"São Paulo", "Minas Gerais", "Bahia"};

dicEstados.Add(Chave1, listaSiglas);
dicEstados.Add(Chave2, listaNomes);

Console.WriteLine("\nImprimindo um dicionário que contém valor de listas.");
foreach( var chave in dicEstados.Keys)
{        
    foreach(var valor in dicEstados[chave])
    {
        Console.WriteLine("Chave : " + chave + ", Valor :" + valor);
    }
    Console.WriteLine("\n");
}