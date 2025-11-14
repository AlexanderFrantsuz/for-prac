using System;

public class Money
{
    public int Rubles { get; private set; }
    public int Kopecks { get; private set; }

    public Money(int rubles, int kopecks)
    {
        Rubles = rubles + kopecks / 100;
        Kopecks = kopecks % 100;
        if (Kopecks < 0)
        {
            Rubles--;
            Kopecks += 100;
        }
    }

    public static Money operator +(Money a, Money b) =>
        new Money(a.Rubles + b.Rubles, a.Kopecks + b.Kopecks);

    public static bool operator ==(Money a, Money b) =>
        a is not null && b is not null && a.Rubles == b.Rubles && a.Kopecks == b.Kopecks;

    public static bool operator !=(Money a, Money b) => !(a == b);

    public override bool Equals(object obj) => obj is Money m && this == m;
    public override int GetHashCode() => HashCode.Combine(Rubles, Kopecks);
    public override string ToString() => $"{Rubles} руб. {Kopecks} коп.";
}

public class Program
{
    public static void Main()
    {
        Money m1 = new Money(10, 75);
        Money m2 = new Money(5, 75);
        Money sum = m1 + m2;

        Console.WriteLine(sum);               
        Console.WriteLine(sum == new Money(16, 50)); 
    }
}