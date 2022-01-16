using System.Collections.Generic;
using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorios(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*2.txt", SearchOption.AllDirectories); // * é um tipo de filtro (sozinho é tudo, antes e depois de caractere é qualquer coisa)

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarArquivos) //bool true para apgar tudo que esta no diretorio
        {
            Directory.Delete(caminho, apagarArquivos); //apaga direto o arquivo, nao vai para a lixeira
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo) //stream é a melhor maneira de trabalhar com arquivos grandes
        {            
            using(var stream = File.CreateText(caminho)) //using é para quando terminar a escrita não pode deixar o arquivo aberto. Tem que fechá-lo para que outro processo o use. O USING é responsavel por terminar essa stream (garante que o arquivo seja liberado para outro processo)
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha); //stream é a intermediaria da escrita do arquivo para que nao seja escrito tudo de uma vez (escreve em partes)
                }
            }
        }

        public void AdicionarTexto(string caminho, string conteudo) //sem stream
        {
            File.AppendAllText(caminho, conteudo); //AppendAllText adiciona ao texto já existente
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo) // com stream
        {            
            using(var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha); 
                }
            }
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho); //carrega todo o arquivo na memória. Carrega tudo de uma vez só

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }


        //mais recomendado para arquivos grandes:
        public void LerArquivoStream(string caminho) //carrega o arquivo a cada linha
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}