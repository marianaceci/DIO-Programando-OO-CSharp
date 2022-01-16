using System;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar() //override: metodo sobreescrito
        {
            Console.WriteLine($"Diretor");
        }
    }
}