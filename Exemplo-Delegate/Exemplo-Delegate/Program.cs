using Exemplo_Delegate.Models;

namespace Exemplo_Delegate
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        public delegate void MultiOperacao(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("\nDelegate:");
            //Operacao op_soma = Calculadora.Somar; // Outra maneira de passar o método para o delegate
            Operacao op_soma = new Operacao(Calculadora.Somar);

            //op_soma(10,10); // Outra maneira de chamar o delegate
            op_soma.Invoke(10,10);

            Console.WriteLine("\nMulti Cast Delegate:");
            MultiOperacao op = Calculadora.Somar;
            op += Calculadora.Subtrair; // += atribui mais um método ao delegate.
            op.Invoke(10,10); // Ao chamar o multi cast delegate, o mesmo obedece a ordem FIFO - First in, First Out.
        }
    }
}
