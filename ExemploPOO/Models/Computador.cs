namespace ExemploPOO.Models
{
    public class Computador : System.Object // classe System.Object pode ser reescrita (é a mãe de todas as classes)
    {
        public override string ToString()
        {
            return "Sou uma classe Computador"; //reecrevemos a classe ToString() pertencente a classe Object
        }
    }
}