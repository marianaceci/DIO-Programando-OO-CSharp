using System;
using System.Collections.Generic;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\workspace\\DIO-POO-CSharp\\Manipulando-arquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo-teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo-teste-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "Arquivo-teste-stream.txt"); //optamos por mover com o mesmo nome
            
            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };


            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //System.Console.WriteLine("Criando diretorio: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);




            // ICalculadora calc = new Calculadora(); //interface não pode ser instanciada
            // System.Console.WriteLine(calc.Somar(10, 20));


            // Computador comp = new Computador();
            // System.Console.WriteLine(comp.ToString());


            // Corrente c = new Corrente();
            // c.Creditar(100);
            // c.ExibirSaldo();
            

            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultafo da primeira soma: " + calc.Somar(10, 10));
            // System.Console.WriteLine("Resultafo da segunda soma: " + calc.Somar(10, 10, 10));


            // Aluno p1 = new Aluno();
            // p1.Nome = "Mariana";
            // p1.Idade = 32;
            // p1.Documento = "123456789";
            // p1.Nota = 10;
            // p1.Apresentar(); //método

            // Professor p2 = new Professor();
            // p2.Nome = "Mariana";
            // p2.Idade = 32;
            // p2.Salario = 2000;
            // p2.Apresentar();


            // // Valores validos
            // Retangulo r = new Retangulo();
            // r.DefenirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}"); 

            // // Valores invalidos
            // Retangulo r2 = new Retangulo();
            // r2.DefenirMedidas(0, 30);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}"); 


            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Mariana";
            // p1.Idade = 32;
            // p1.Apresentar();
        }
    }
}
