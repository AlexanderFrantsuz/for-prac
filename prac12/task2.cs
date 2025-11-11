using System;
public static class ProgramConfig
{
    private const double _programVersion = 1.2;
    private const string _developerName = "Alex";
    public static void ShowInfo()
    {
        Console.WriteLine($"Разработчик: {_developerName}");
        Console.WriteLine($"Версия программы: {_programVersion}");
    }
}
