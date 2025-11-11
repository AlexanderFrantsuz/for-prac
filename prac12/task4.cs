using System;
public class Book
{
    private readonly string _isbn;
    public string Title { get; set; }
    public string Author { get; set; }
    public Book(string ISBN, string title, string author)
    {
        _isbn = ISBN;
        Title = title;
        Author = author;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"ISBN книги: {_isbn}");
        Console.WriteLine($"Название книги: {Title}");
        Console.WriteLine($"Автор книги: {Author}");
    }
}