namespace Exemplo_POO_7_Interfaces.Interfaces
{
    public interface ICalculadora
    {
        int Somar (int num1, int num2);
        int Subtrair (int num1, int num2);
        int Multiplicar (int num1, int num2);
        double Dividir (double num1, double num2) // Como "Dividir" foi implementado na interface, não há necessidade de implementar na classe "Calculadora"
        {
            return num1/num2;
        }
    }
}