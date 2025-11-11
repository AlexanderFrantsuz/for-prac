using System;
public class Animal
{
    public string Species { get; set; }
    public int Age { get; set; }
    public string Habitat { get; set; }
    public string Diet { get; set; }
    public Animal(string species, int age, string habitat, string diet)
    {
        Species = species;
        Age = age;
        Habitat = habitat;
        Diet = diet;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Вид: {Species}.");
        Console.WriteLine($"Возраст: {Age}.");
        Console.WriteLine($"Среда обитания: {Habitat}.");
        Console.WriteLine($"Рацион: {Diet}.");
    }
}
public class Mammal : Animal
{
    public string FurType { get; set; }
    public int PregnancyDuration { get; set; }
    public Mammal(string species, int age, string habitat, string diet, string furType, int pregnancyDuration) : base(species, age, habitat, diet)
    {
        FurType = furType;
        PregnancyDuration = pregnancyDuration;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип меха: {FurType}.");
        Console.WriteLine($"Длительность беременности: {PregnancyDuration}.");
    }
}
public class Bird : Animal
{
    public int Wingspan { get; set; }
    public string NestingType { get; set; }
    public Bird(string species, int age, string habitat, string diet, int wingspan, string nestingType) : base(species, age, habitat, diet)
    {
        Wingspan = wingspan;
        NestingType = nestingType;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Размах крыльев: {Wingspan}.");
        Console.WriteLine($"Тип гнездования: {NestingType}.");
    }
}
public class Reptile : Animal
{
    public string SkinType { get; set; }
    public int AmbientTemperature { get; set; }
    public Reptile(string species, int age, string habitat, string diet, string skinType, int ambientTemperature) : base(species, age, habitat, diet)
    {
        SkinType = skinType;
        AmbientTemperature = ambientTemperature;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип кожи: {SkinType}.");
        Console.WriteLine($"Температура среды: {AmbientTemperature}.");
    }
}
public class Fish : Animal
{
    public string ScalesType { get; set; }
    public int HabitatDepth { get; set; }
    public Fish(string species, int age, string habitat, string diet, string scalesType, int habitetDepth) : base(species, age, habitat, diet)
    {
        ScalesType = scalesType;
        HabitatDepth = habitetDepth;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Тип чешуи: {ScalesType}.");
        Console.WriteLine($"Глубина обитания: {HabitatDepth}.");
    }
}