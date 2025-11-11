using System;
public class Course
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public Course(string title, string author, string description, double price)
    {
        Title = title;
        Author = author;
        Description = description;
        Price = price;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}.");
        Console.WriteLine($"Автор: {Author}.");
        Console.WriteLine($"Описание: {Description}.");
        Console.WriteLine($"Цена: {Price}.");
    }
}
public class VideoCourse : Course
{
    public int VideoCount { get; set; }
    public int Duration { get; set; }
    public VideoCourse(string title, string author, string description, double price, int videoCount, int duration) : base(title, author, description, price)
    {
        VideoCount = videoCount;
        Duration = duration;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество видео: {VideoCount}.");
        Console.WriteLine($"Общая длительность: {Duration}.");
    }
}
public class TextCourse : Course
{
    public int ChapterCount { get; set; }
    public int TextSize { get; set; }
    public TextCourse(string title, string author, string description, double price, int chapterCount, int textSize) : base(title, author, description, price)
    {
        ChapterCount = chapterCount;
        TextSize = textSize;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество глав: {ChapterCount}.");
        Console.WriteLine($"Общий обхем текста: {TextSize}.");
    }
}
public class InteractiveCourse : Course
{
    public int ExerciseCount { get; set; }
    public bool HaveExamination { get; set; }
    public InteractiveCourse(string title, string author, string description, double price, int exerciseCount, bool haveExamination) : base(title, author, description, price)
    {
        ExerciseCount = exerciseCount;
        HaveExamination = haveExamination;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество упражнений: {ExerciseCount}.");
        Console.WriteLine($"Наличие системы проверки: {HaveExamination}.");
    }
}
