namespace Calculadora
{
    class Operacoes
    {
        static void Soma(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("O resultado da operação " + a + " + " + b + " é igual a " + c);
        }
        static void Subtracao(double a, double b)
        {
            double c = a - b;
            Console.WriteLine("O resultado da operação " + a + " - " + b + " é igual a " + c);
        }
        static void Multiplicacao(double a, double b)
        {
            double c = a * b;
            Console.WriteLine("O resultado da operação " + a + " x " + b + " é igual a " + c);
        }
        static void Divisao(double a, double b)
        {
            double c = a / b;
            Console.WriteLine("O resultado da operação " + a + " / " + b + " é igual a " + c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo à calculadora criada usando C#");
            Console.WriteLine("Escolha o tipo de operação que deseja realizar: ");
            Console.WriteLine("1- Soma (X + Y)\n2- Substração (X - Y)\n3- Multiplicação (X * Y)\n4- Divisão (X / Y)");
            int tipoOperacao = Convert.ToInt32(Console.ReadLine());

            // Verificando o valor informado pelo usuário.
            if (tipoOperacao == 0 || tipoOperacao > 4)
            {
                while (tipoOperacao == 0 || tipoOperacao > 4)
                {
                    Console.WriteLine("Operação indisponível. Escolha novamente uma opção.");
                    Console.WriteLine("1- Soma (X + Y)\n2- Substração (X - Y)\n3- Multiplicação (X * Y)\n4- Divisão (X / Y)");
                    int x = Convert.ToInt32(Console.ReadLine());
                    tipoOperacao = x;
                }
                    
            }

            if (tipoOperacao == 1)
            {
                Console.WriteLine("Informe o valor de X:");
                var X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                var Y = Convert.ToInt32(Console.ReadLine());
                Soma(X, Y);
            }
            else if (tipoOperacao == 2)
            {
                Console.WriteLine("Informe o valor de X:");
                var X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                var Y = Convert.ToInt32(Console.ReadLine());
                Subtracao(X, Y);
            }
            else if (tipoOperacao == 3)
            {
                Console.WriteLine("Informe o valor de X:");
                var X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                var Y = Convert.ToInt32(Console.ReadLine());
                Multiplicacao(X, Y);
            }
            else if (tipoOperacao == 4)
            {
                Console.WriteLine("Informe o valor de X:");
                var X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o valor de Y:");
                var Y = Convert.ToInt32(Console.ReadLine());
                while (Y == 0)
                {
                    Console.WriteLine("O Valor de Y não pode ser igual a zero.\nInforme um outro valor para Y:");
                    var y = Convert.ToInt32(Console.ReadLine());
                    Y = y;
                }
                Divisao(X, Y);
            }
            else
            {
                Console.WriteLine("Operação indisponível");
            }
        }
    }
}
