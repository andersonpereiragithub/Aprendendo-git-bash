using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            c = new Conta(numConta, nome);

            Console.Write("Haverá deposito incial (s/n)? ");
            char resp = char.Parse(Console.ReadLine().ToLower());

            if (resp == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(c);

            Console.Write("\nEntre um valor para depósito: ");
            c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.Write("\nEntre um valor para saque: ");
            c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
