using System;
namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //Aluno esta herdando da classe Pessoa
    {
        public int Nota { get; set; } //atributo de Aluno

        public override void Apresentar() //override: metodo sobreescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e minha nota é {Nota}");
        }
    }
}