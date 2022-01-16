using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora //"implementa" a interface ("herda" classe)
    {
        

        //métodos devem ser implementados nas classes ou interfaces (verificar condições)

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}