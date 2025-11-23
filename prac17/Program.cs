using System;

//Задание 1
public struct Color
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}

//Задание 2
public class Order
{
    public int Id { get; set; }
    public decimal Total { get; set; }
}

//Задание 3
[Flags]
public enum FileAccess
{
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4
}

public struct File
{
    public FileAccess Permissions { get; set; }

    public bool CanRead() => (Permissions & FileAccess.Read) != 0;
    public bool CanWrite() => (Permissions & FileAccess.Write) != 0;
}

//Задание 4
public struct Weather
{
    public string City { get; set; }
    public double? Temperature { get; set; }

    public override string ToString()
    {
        return Temperature.HasValue
            ? $"{City}: {Temperature}°C"
            : $"{City}: Нет данных";
    }
}

//Задание 5
public enum EmploymentStatus
{
    Active,
    OnLeave,
    Terminated
}

public class Employee
{
    public string Name { get; set; }
    public DateTime? HireDate { get; set; }
    public EmploymentStatus Status { get; set; }

    public int GetYearsWorked()
    {
        if (!HireDate.HasValue) return -1;

        var hire = HireDate.Value.Date;
        var today = DateTime.Today;

        int years = today.Year - hire.Year;
        if (today.Month < hire.Month || (today.Month == hire.Month && today.Day < hire.Day))
            years--;

        return years;
    }

    public override string ToString()
    {
        string hireStr = HireDate?.ToShortDateString() ?? "не указан";
        return $"{Name}, статус: {Status}, стаж: {hireStr}";
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Задание 1");
        var c1 = new Color(255, 128, 0);
        var c2 = c1;
        c2.R = 100;
        Console.WriteLine($"c1 = {c1}"); 
        Console.WriteLine($"c2 = {c2}"); 

        Console.WriteLine("\nЗадание 2");
        var order1 = new Order { Id = 1001, Total = 1500.50m };
        var order2 = order1;
        order2.Total = 2000.00m;
        Console.WriteLine($"order1.Total = {order1.Total}"); 
        Console.WriteLine($"order2.Total = {order2.Total}"); 

        Console.WriteLine("\nЗадание 3");
        var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
        Console.WriteLine($"CanRead: {f.CanRead()}");  
        Console.WriteLine($"CanWrite: {f.CanWrite()}"); 
        Console.WriteLine("\nЗадание 4");
        var w1 = new Weather { City = "Москва", Temperature = 22.5 };
        var w2 = new Weather { City = "Сочи", Temperature = null };
        Console.WriteLine(w1); 
        Console.WriteLine(w2); 
        Console.WriteLine($"w2.Temperature ?? -999 = {w2.Temperature ?? -999}"); 
        Console.WriteLine("Задание 5");
        var emp = new Employee
        {
            Name = "Петр",
            HireDate = new DateTime(2020, 3, 15),
            Status = EmploymentStatus.Active
        };
        Console.WriteLine($"Стаж: {emp.GetYearsWorked()} лет"); 
        emp.HireDate = null;
        Console.WriteLine($"Стаж при null: {emp.GetYearsWorked()}"); 
        Console.WriteLine(emp); 
    }
}