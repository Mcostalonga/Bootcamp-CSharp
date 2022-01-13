// Programa usado para empilhar objetos:
// Conceito Primeiro que entra, último que sai (FILO - First In, Last Out)
using EstruturaDoPrograma.Exemplos;

namespace EstruturaDoPrograma
{
    class EstruturaDoPrograma
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilha("A");
            s.Empilha("B");
            s.Empilha("C");
            s.Empilha("D");
            s.Empilha("E");
            s.Empilha("F");
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            // Console.WriteLine(s.Desempilha()); // Fazer com que a exceção surja.
        }
    }
}