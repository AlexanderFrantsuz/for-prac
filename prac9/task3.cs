
using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank_account = new BankAccount("", 0);
            Console.Write("Введите имя: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str)) bank_account.OWNER = str;
            else
            {
                Console.WriteLine("Ошибка. Строка пуста или состоит только из пробелов");
                return;
            }
            Console.Write("Введите баланс: ");
            if (double.TryParse(Console.ReadLine(), out double userDeposit) && userDeposit >= 0) bank_account.BALANCE = userDeposit;
            else
            {
                Console.WriteLine("Баланс должен быть больше или равен 0.");
                return;
            }
            Console.WriteLine("Введите сумму увеличения баланса.");
            if (!double.TryParse(Console.ReadLine(), out double sum) || sum <= 0)
            {
                Console.WriteLine("Сумма должна быть больше нуля.");
                return;
            }
            bank_account.Deposit(sum);
            Console.WriteLine("Введите сумму уменьшения баланса.");
            if (!double.TryParse(Console.ReadLine(), out sum) || sum <= 0)
            {
                Console.WriteLine("Сумма должна быть больше нуля.");
                return;
            }
            if (sum <= bank_account.BALANCE) bank_account.Withdraw(sum);
            else Console.WriteLine("Недостаточно средств.");
        }
    }
    class BankAccount
    {
        private string owner;
        private double balance;
        public BankAccount(string Owner, double Balance)
        {
            owner = Owner;
            balance = Balance;
        }
        public void Deposit(double sum)
        {
            if (sum > 0)
            {
                balance += sum;
                Console.WriteLine($"{owner}, баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Ошибка. Сумма увеличения баланса не может быть меньше 0.");
                return;
            }
        }
        public void Withdraw(double sum)
        {
            if (sum > 0)
            {
                balance -= sum;
                Console.WriteLine($"{owner}, баланс: {balance}");
            }
            else
            {
                Console.WriteLine("Ошибка. Сумма уменьшения баланса не может быть меньше 0.");
                return;
            }
        }
        public string OWNER
        {
            set { owner = value; }
            get { return owner; }
        }
        public double BALANCE
        {
            set { balance = value; }
            get { return balance; }
        }
    }

}
