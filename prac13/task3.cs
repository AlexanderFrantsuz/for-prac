using System;
public class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsPublic { get; set; }
    public LibraryItem(string title, string author, int year, bool isPublic)
    {
        Title = title;
        Author = author;
        Year = year;
        IsPublic = isPublic;
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}.");
        Console.WriteLine($"Автор: {Author}.");
        Console.WriteLine($"Год издания: {Year}.");
        Console.WriteLine($"Статус доступности: {IsPublic}.");
    }
}
public class Book : LibraryItem
{
    public int PagesNum { get; set; }
    public string ISBN { get; set; }
    public Book(string title, string author, int year, bool isPublic, int pagesNum, string isbn) : base(title, author, year, isPublic)
    {
        PagesNum = pagesNum;
        ISBN = isbn;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество страниц: {PagesNum}.");
        Console.WriteLine($"ISBN : {ISBN}.");
    }
}
public class Audiobook : LibraryItem
{
    public int AudioDuration { get; set; }
    public string Speaker { get; set; }
    public Audiobook(string title, string author, int year, bool isPublic, int audioDuration, string speaker) : base(title, author, year, isPublic)
    {
        AudioDuration = audioDuration;
        Speaker = speaker;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Длительность: {AudioDuration}.");
        Console.WriteLine($"Диктор: {Speaker}.");
    }
}
public class Magazine : LibraryItem
{
    public int ReleaseNum { get; set; }
    public int Periodicity { get; set; }
    public Magazine(string title, string author, int year, bool isPublic, int releaseNum, int periodicity) : base(title, author, year, isPublic)
    {
        ReleaseNum = releaseNum;
        Periodicity = periodicity;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Номер выпуска: {ReleaseNum}.");
        Console.WriteLine($"Периодичность (кол-во раз в год): {Periodicity}.");
    }
}
public class DVD : LibraryItem
{
    public int Duration { get; set; }
    public int Rating { get; set; }
    public DVD(string title, string author, int year, bool isPublic, int duration, int rating) : base(title, author, year, isPublic)
    {
        Duration = duration;
        Rating = rating;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Продолжительность (в секундах): {Duration}.");
        Console.WriteLine($"Рейтинг: {Rating}.");
    }
}
