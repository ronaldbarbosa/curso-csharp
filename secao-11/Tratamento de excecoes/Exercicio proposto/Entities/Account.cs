using Exercicio_proposto.Entities.Exceptions;

namespace Exercicio_proposto.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            WithdrawLimit = withdrawLimit;

            Deposit(balance);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit.");
            }
            if(amount > Balance)
            {
                throw new DomainException("Not enough balance.");
            }
        }
    }
}