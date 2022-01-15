int[] arrayNumeros = new int[5] {6, 4, 9, 24, 15};

//Query syntax: (similar a SQL)
var numerosParesQuery =
    from num in arrayNumeros
    where num % 2 == 0
    orderby num
    select num;

// Method syntax:
var numerosParesMethod = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

Console.WriteLine("\nNúmeros pares (Query): " + string.Join(", ", numerosParesQuery));
Console.WriteLine("\nNúmeros pares (Method): " + string.Join(", ", numerosParesMethod));

// Usando LINQ para determinar valores mínimo, máximo e médio
int[] arrayNumeros2 = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100};

var minimo = arrayNumeros2.Min();
var maximo = arrayNumeros2.Max();
var media = arrayNumeros2.Average();

Console.WriteLine($"\nO valor mínimo do array é: {minimo}.");
Console.WriteLine($"\nA média dos valores do array é: {media}.");
Console.WriteLine($"\nO valor máximo do array é: {maximo}.");

// Usando LINQ para somar e retornar uma coleção de valores únicos.
var soma = arrayNumeros2.Sum();
Console.WriteLine($"\nA soma de todos os valores do array é: {soma}.");

var arrayValoresUnicos = arrayNumeros2.Distinct().ToArray();
// Imprimindo os valores únicos do arrayNumeros2
Console.WriteLine("\nArray original: " + string.Join(", ", arrayNumeros2));
Console.WriteLine("\nArray distinto (apenas um único valor de cada): " + string.Join(", ", arrayValoresUnicos));

// Ordenando os arrays em ordem crescente.
var arrayNumeros2Ord =
    from num in arrayNumeros2
    orderby num
    select num;

var arrayNumeros2UniOrd =
    from num in arrayValoresUnicos
    orderby num
    select num;

Console.WriteLine("\nArray original ordenado: " + string.Join(", ", arrayNumeros2Ord));
Console.WriteLine("\nArray distinto (apenas um único valor de cada) ordenado: " + string.Join(", ", arrayNumeros2UniOrd));