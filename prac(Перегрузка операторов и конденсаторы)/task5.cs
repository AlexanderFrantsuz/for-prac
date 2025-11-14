using System;

public class Time
{
    public int Hours { get; private set; }
    public int Minutes { get; private set; }
    public int Seconds { get; private set; }

    public Time(int h, int m, int s)
    {
        Hours = h;
        Minutes = m;
        Seconds = s;
        Normalize();
    }

    private void Normalize()
    {
        int total = Hours * 3600 + Minutes * 60 + Seconds;
        total = ((total % 86400) + 86400) % 86400; 

        Hours = total / 3600;
        Minutes = (total % 3600) / 60;
        Seconds = total % 60;
    }

    public static bool operator >(Time a, Time b)
    {
        int secA = a.Hours * 3600 + a.Minutes * 60 + a.Seconds;
        int secB = b.Hours * 3600 + b.Minutes * 60 + b.Seconds;
        return secA > secB;
    }

    public static bool operator <(Time a, Time b) => b > a;

    public int this[int index]
    {
        get => index switch
        {
            0 => Hours,
            1 => Minutes,
            2 => Seconds,
            _ => throw new IndexOutOfRangeException("Индекс: 0,1,2")
        };
        set
        {
            switch (index)
            {
                case 0: Hours = value; break;
                case 1: Minutes = value; break;
                case 2: Seconds = value; break;
                default: throw new IndexOutOfRangeException("Индекс: 0,1,2");
            }
            Normalize();
        }
    }

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
}

public class Program
{
    public static void Main()
    {
        Time t1 = new Time(12, 30, 45);
        Time t2 = new Time(10, 20, 30);

        Console.WriteLine(t1);     
        Console.WriteLine(t1 > t2); 
        Console.WriteLine(t1[0]);  
    }
}