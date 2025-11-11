using System;
public class BankAccount
{
    public int AccountNum { get; set; }
    public double Balance { get; set; }
    public string Owner { get; set; }
    public BankAccount(int accountNum, double balance, string owner)
    {
        AccountNum = accountNum;
        Balance = balance;
        Owner = owner;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Номер счёта: {AccountNum}.");
        Console.WriteLine($"Баланс: {Balance}.");
        Console.WriteLine($"Владелец: {Owner}.");
    }

}
public class CheckingAccount : BankAccount
{
    public double OverDraftLimit { get; set; }
    public CheckingAccount(int accountNum, double balance, string owner, double overDraftLimit) : base(accountNum, balance, owner)
    {
        OverDraftLimit = overDraftLimit;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Лимит овердрафта: {OverDraftLimit}.");
    }
}
public class SavingsAccount : BankAccount
{
    public double PercentRate { get; set; }
    public SavingsAccount(int accountNum, double balance, string owner, double percentRate) : base(accountNum, balance, owner)
    {
        PercentRate = percentRate;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Процентная ставка: {PercentRate}.");
    }
}
public class CreditAccount : BankAccount
{
    public double CreditLimit { get; set; }
    public string RepaymentDate { get; set; }
    public CreditAccount(int accountNum, double balance, string owner, double creditLimit, string repaymentDate) : base(accountNum, balance, owner)
    {
        CreditLimit = creditLimit;
        RepaymentDate = repaymentDate;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Кредитный лимит: {CreditLimit}.");
        Console.WriteLine($"Срок погашения: {RepaymentDate}.");
    }
}
