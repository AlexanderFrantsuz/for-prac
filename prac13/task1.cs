using System;

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateTime Date { get; set; }
    public Employee(string name, string position, double salary, DateTime date)
    {
        Name = name;
        Position = position;
        Salary = salary;
        Date = date;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Имя сотрудника: {Name}.");
        Console.WriteLine($"Должность сотрудника: {Position}.");
        Console.WriteLine($"Зарплата сотрудника: {Salary}.");
        Console.WriteLine($"Дата приема сотрудника: {Date:dd:MM:yyyy}.");
    }
}
public class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, double salary, DateTime date, int teamSize) : base(name, "Менеджер", salary, date)
    {
        TeamSize = teamSize;
    }
    public void HoldMeeting()
    {
        Console.WriteLine($"{Name} проводит собрание.");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Размер команды: {TeamSize}.");
    }
}
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, double salary, DateTime date, string programmingLanguage) : base(name, "Программист", salary, date)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public void WriteCode()
    {
        Console.WriteLine($"{Name} пишет код.");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Язык программирования: {ProgrammingLanguage}.");
    }
}
public class Director : Employee
{
    public string Department { get; set; }
    public Director(string name, double salary, DateTime date, string department) : base(name, "Директор", salary, date)
    {
        Department = department;
    }
    public void ApproveBudget()
    {
        Console.WriteLine($"{Name} утвердил бюджет.");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Название отдела {Department}.");
    }
}