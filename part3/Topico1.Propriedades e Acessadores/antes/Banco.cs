using Topico1;

namespace Topico1
{
    public class Banco
    {
        public Banco()
        {
            Conta conta = new Conta();
            conta.Saldo = 1000;
            System.Console.WriteLine(conta.Saldo);
        }
    }
    public class Conta 
    {
        public Conta()
        {
            this.Saldo = 1000;
            System.Console.WriteLine(this.Saldo);
        }
        public void Sacar(decimal saque)
        {
            Saldo = Saldo - saque;
        }
        private decimal Saldo { get; set; }
    }


    public class ContaCorrente : conta
    {
        public ContaCorrente()
        {
            this.Saldo = 1000;
            System.Console.WriteLine(this.Saldo);
        }
    }

}