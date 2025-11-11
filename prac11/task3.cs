using System;
namespace task3
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Название не может быть пустым!");
                    return;
                }
                title = value;
            }
        }
        public int Pages { get; set; } = 1;
        public bool IsLong => Pages > 300 ? true : false;
        public Book(string title)
        {
            Title = title;
        }
        public void Info()
        {
            Console.WriteLine($"Книга: {title}, страниц: {Pages}, длинная: {IsLong}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Война и мир");
            book.Pages = 1200;
            book.Info();
            book.Title = "";
            Book book2 = new Book("Краткая история");
            book2.Info();
        }
    }
}
