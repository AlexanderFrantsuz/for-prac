using System;
public static class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }
    public static double Subtract(double a, double b)
    {
        return a - b;
    }
    public static double Multiply(double a, double b)
    {
        return a * b;
    }
    public static double Divis(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: на 0 делить нельзя!");
            return 0;
        }
        return a / b;
    }
}
