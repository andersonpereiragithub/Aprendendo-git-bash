using System;
using System.Globalization;
namespace ContaBancaria
{
    class Conta
    {
        private readonly double taxa = 5.00;
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double saldo { get; private set; }

        public Conta(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        public Conta(double depositoInicial)
        {
            this.Depositar(depositoInicial);
        }
        
        public void Depositar(double valor)
        {
            if (valor > 0)
                saldo += valor;
        }
        public void Sacar(double valor)
        {
            saldo -= valor + taxa;
        }
        public override string ToString()
        {
            return "Conta " + NumConta
                 + ", Titular: " + Titular 
                 + ", Saldo $ " + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
