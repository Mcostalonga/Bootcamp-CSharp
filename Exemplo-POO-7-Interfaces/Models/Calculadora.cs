using Exemplo_POO_7_Interfaces.Interfaces;

namespace Exemplo_POO_7_Interfaces.Models
{
    public class Calculadora : ICalculadora // Calculadora implementa a interface "ICalculadora", isso é
    // A classe Calculadora precisa preencher os métodos da interface.
    {
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}