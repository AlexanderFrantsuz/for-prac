using System;
namespace task5
{
    interface DepWithdraw
    {
        void Deposit(double deposit);
        void Withdrawal(double withdrawal);
    }
    interface Transfer
    {
        void Trans(Account account1, Account account2, double sum);
    }
    class Account : DepWithdraw, Transfer
    {
        public double Balance { get; set; }
        public Account(int balance)
        {
            Balance = balance;
        }
        public void Deposit(double deposit)
        {
            Balance += deposit;
        }
        public void Withdrawal(double withdrawal)
        {
            if (withdrawal > Balance)
            {
                Console.WriteLine("Ошибка: сумма снятия не может превышать баланс.");
                return;
            }
            Balance -= withdrawal;
        }
        public void Trans(Account account1, Account account2, double sum)
        {
            if (sum > account1.Balance)
            {
                Console.WriteLine("Ошибка: сумма перевода не может превышать баланс.");
                return;
            }
            account1.Balance -= sum;
            account2.Balance += sum;
        }
    }
    internal class task5
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(10000);
            Account account2 = new Account(100000);
            account2.Trans(account2, account1, 40000);
            Console.WriteLine($"Баланс первого аккаунта: {account1.Balance}");
            Console.WriteLine($"Баланс второго аккаунта: {account2.Balance}");
        }
    }
}
