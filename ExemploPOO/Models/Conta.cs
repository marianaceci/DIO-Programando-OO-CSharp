namespace ExemploPOO.Models
{
    public abstract class Conta //abstract: deve ser sobreescrito/implementado
    {
        protected double saldo; //protected: somente a propria classe e as filhas podem acessar
    
        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}