using System;

namespace ExemploPOO.Models
{
    //public sealed class Professor : Pessoa //sealed: classe não pode ser herdada (final da herança)
    public class Professor : Pessoa
    {
        public int Salario { get; set; }
        public override void Apresentar() //override: metodo sobreescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e meu salário é de R${Salario}");
        }
    }
}