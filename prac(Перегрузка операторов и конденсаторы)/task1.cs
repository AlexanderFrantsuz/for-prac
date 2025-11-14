using System;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public static Point operator +(Point p1, Point p2)
    {
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new Point(p1.X - p2.X, p1.Y - p2.Y);
    }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
public class Program
{
    public static void Main()
    {
        Point a = new Point(1, 3);
        Point b = new Point(2, 4);

        Point c = a + b;
        Point d = a - b;

        Console.WriteLine(c); 
        Console.WriteLine(d); 
    }
}