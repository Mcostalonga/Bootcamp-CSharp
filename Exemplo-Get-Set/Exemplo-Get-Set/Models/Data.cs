namespace Exemplo_Get_Set.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                mesValido = true;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
        // Não há necessidade de criar Métodos para realizar o "Get e Set", pois já existe uma propriedade para isso.
        // public int Mes { get; set; } // forma de chamar a propriedade padrão, mas podemos especificar o que cada propriedade irá fazer.
        public int Mes 
        { 
            get
            {
                return this.mes;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            } 
        }
        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                Console.WriteLine(this.mes);
            }
            else
            {
                Console.WriteLine("Mês inválido");
            }
        }
    }
}