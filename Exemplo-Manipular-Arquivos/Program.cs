// See https://aka.ms/new-console-template for more information
using Exemplo_Manipular_Arquivos.Helper;

namespace Exemplo_Manipular_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = ".\\Teste";
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta3","novo arquivo.txt");
            var caminhoPathCombine = Path.Combine(caminho, "Pasta4", "SubPasta4");
            var caminhoApagar = Path.Combine(caminho, "Pasta4");
            var caminhoArquivo = Path.Combine(caminho,"arquivo teste.txt");
            var caminhoArquivo2 = Path.Combine(caminho,"arquivo teste backup.txt");
            var conteudoArquivo = "Conteúdo para o arquivo de texto.";
            var listaString1 = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
            var listaString2 = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
            FileHelper helper = new FileHelper();
            Console.WriteLine("\nLista de pastas: ");
            helper.ListarDiretorios(caminho);
            Console.WriteLine("\nLista de arquivos:");
            helper.ListarArquivosDiretorios(caminho);
            Console.WriteLine("\nCriando um diretório.");
            helper.CriarDiretorio(caminhoPathCombine);
            helper.LerArquivo(caminhoArquivo);
            // Criando arquivos de texto e escrevendo
            helper.ApagarDiretorio(caminhoApagar, true);
            helper.CriarArquivoTexto(caminhoArquivo,conteudoArquivo);
            helper.CriarArquivoTextoStream(caminhoArquivo,listaString1);
            helper.AdicionarTexto(caminhoArquivo,"Texto adicionado\n");
            helper.AdicionarTextoStream(caminhoArquivo,listaString2);
            // Movendo arquivo
            helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo, true);
            // Copiando arquivo
            helper.CopiarArquivo(novoCaminhoArquivo,caminhoArquivo, true);
            Console.WriteLine("Arquivo copiado.");
            helper.CopiarArquivo(caminhoArquivo, caminhoArquivo2, true);
            Console.WriteLine("Arquivo copiado.");
            // Lendo arquivo de forma Stream
            helper.LerArquivo(caminhoArquivo);
            Console.WriteLine("\nUsando LerArquivoStream");
            helper.LerArquivoStream(caminhoArquivo);
            // Deletar arquivo
            helper.DeletarArquivo(caminhoArquivo2);
        }
    }
}
