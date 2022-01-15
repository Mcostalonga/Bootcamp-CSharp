namespace Exemplo_Construtores.Models
{
    public class Log
    {
        private static Log _log; 
        public string PropriedadeLog { get; set; } // Sempre será a mesma instância
        private Log()
        // Geralmente é utilizado para acessar bancos de dados e registrar os eventos na aplicação 
        // Padrão de projeto singleton
        {
            
            Console.WriteLine("Construtor privado chamado");
        }

        public static Log GetInstance()
        {
            if (_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}