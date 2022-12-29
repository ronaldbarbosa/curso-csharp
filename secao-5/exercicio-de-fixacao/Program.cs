using System;

namespace exercicio_de_fixacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());

            Conta c1;

            if (deposito.Equals('s') || deposito.Equals('S'))
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                c1 = new Conta(numeroConta, titular, depositoInicial);
            }
            else
            {
                c1 = new Conta(numeroConta, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(c1); ;

            Console.Write("\nEntre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            c1.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.Write("\nEntre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            c1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
        }
    }
}