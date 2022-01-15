// See https://aka.ms/new-console-template for more information
using Exemplo_Get_Set.Models;

Data data1 = new Data();
data1.SetMes(2);
data1.ApresentarMes();

Data data2 = new Data();
data2.SetMes(13);
data2.ApresentarMes();

int data3 = data1.GetMes();
Console.WriteLine(data3);

Data data4 = new Data();
// Usando a propriedade para atribuir valor.
//(Quando se usa igual, utiliza a propriedade "set". Quando não se usa nada, está utilizando a propriedade "get")
// data4.Mes = value <= Função set
// data4.Mes <- Função get: Exemplo: Console.WriteLine(data4.Mes); Retorna o valor "value"
data4.Mes = 12;
data4.ApresentarMes();