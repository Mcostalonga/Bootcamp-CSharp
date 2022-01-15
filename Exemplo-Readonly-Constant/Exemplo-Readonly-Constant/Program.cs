// See https://aka.ms/new-console-template for more information
using Exemplo_Readonly_Constant.Models;

Pessoa p1 = new Pessoa("Juca", "Josefino");
p1.Apresentar();

// Só é possível inserir valor na inicialização da variável.
// Não é possível criar uma variável constante sem valor nenhum. (A não ser que queira uma constante igual a zero).
const double pi = 3.1415; 
Console.WriteLine($"Realizando a leitura de pi: pi = {pi}");
// pi = 0; // Não permite a atribuição de novos valores