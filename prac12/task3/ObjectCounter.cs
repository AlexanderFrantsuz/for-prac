using System;
public class ObjectCounter
{
    private static int countObjects;
    public ObjectCounter()
    {
        countObjects++;
    }
    public static void PrintCountObjects()
    {
        Console.WriteLine($"Текущее количество объектов: {countObjects}");
    }
}