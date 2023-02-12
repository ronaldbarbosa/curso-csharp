using System.Globalization;
using Exercicio_proposto.Entities;
using Exercicio_proposto.Entities.Exceptions;

namespace Exercicio_proposto
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);

                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Withdraw Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}