using System;
using System.Collections.Generic;

public class Score
{
    private Dictionary<string, int> _data = new Dictionary<string, int>();

    public int this[string subject]
    {
        get => _data.TryGetValue(subject, out int v) ? v : 0;
        set => _data[subject] = value;
    }

    public override string ToString()
    {
        var parts = new List<string>();
        foreach (var kvp in _data)
            parts.Add($"{kvp.Key}: {kvp.Value}");
        return string.Join(", ", parts);
    }
}

public class Program
{
    public static void Main()
    {
        Score s = new Score();
        s["Математика"] = 5;
        s["Физика"] = 4;

        Console.WriteLine(s); 
    }
}