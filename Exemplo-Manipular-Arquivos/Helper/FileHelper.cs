using System.IO;
namespace Exemplo_Manipular_Arquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var  retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }
        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories); // em "*" podemos especificar a extensão do arquivo. Ex.: "*.txt"
            // ou retornor arquivo que possuam alguma letra/palavra/número específico. Ex.: "*2.txt"
            // Se a extensão não importar, podemos usar "*2*", por exemplo.
            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho)
        {
            var nomeDiretorio = Directory.CreateDirectory(caminho);
            Console.WriteLine(nomeDiretorio.FullName);
        }
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Console.WriteLine($"Pasta no caminho {caminho} foi apagada.");
            Directory.Delete(caminho, apagarArquivos); // Devemos informar que queremos apagar o diretório, mesmo se houver conteúdo dentro.
                                                       // apagarArquivos = true: Apaga pasta e arquivos, apagarArquivos = false: Apaga somente pastas vazias.
        }
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if (!File.Exists(caminho)) // Verifica se existe um arquivo com o nome especificado. Caso exista, ele ignora, se não, ele cria o arquivo com o conteúdo indicado.
            {
                File.WriteAllText(caminho, conteudo);
                Console.WriteLine($"Criando um arquivo no caminho {caminho}");
            }
            Console.WriteLine("Arquivo não foi criado, pois já existe um arquivo com o nome no destino escolhido.");
        }
        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        { // Esse método ainda sobrescreve o arquivo se já existir.
           using (var stream =  File.CreateText(caminho))
           {
               foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
           }
        }
        public void AdicionarTexto(string caminho, string conteudo)
        {
            // Esse método escreve todo o conteúdo dentro de "conteudo" de uma vez
            File.AppendAllText(caminho, conteudo);
        }
        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        { // Esse escreve a lista de string declarada em "conteudo".
           using (var stream =  File.AppendText(caminho))
           {
               foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
           }
        }
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach (var linha in conteudo)
            {
                Console.WriteLine(linha); // Imprime o conteúdo do arquivo.
            }
        }
        public void LerArquivoStream(string caminho)
        { // Le o arquivo. Maneira mais recomendada para arquivos grandes.
            string linha = string.Empty;
            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     Console.WriteLine(linha);
                }
            }
        }
        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
            Console.WriteLine($"Moveu o arquivo {caminho} para {novoCaminho}.");
        }
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        { // Por padrão, se não for informado "true", o arquivo com o mesmo nome não é sobrescrito.
          // o método "Move" também tem esse mesmo parâmetro.
            File.Copy(caminho, novoCaminho, sobrescrever);
            Console.WriteLine($"Copiou o arquivo {caminho} para {novoCaminho}.");
        }
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
            Console.WriteLine("Arquivo excluído.");
        }
    }
}