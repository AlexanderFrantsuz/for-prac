using System;
public static class Settings
{
    private static readonly string _path;
    static Settings()
    {
        _path = "C://path";
    }
    public static void ShowInfo()
    {
        Console.WriteLine($"Путь к файлу конфигурации: {_path}");
    }
}