using System;
namespace task1
{
    internal class Program
    {
        class Book
        {
            private string title;
            private int pages;

            public Book(string title, int pages)
            {
                this.title = title;
                this.pages = pages;
            }

            public Book(string title) : this(title, 100) { }
            public Book() : this("Без названия", 1) { }
            public void Read()
            {
                if (pages >= 1 && pages <= 5000)
                {
                    Console.WriteLine($"Читаю книгу {title}, страниц {pages}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Страниц должно быть от 1 до 5000.");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            Book newBook = new Book("Война и мир", 1200);
            newBook.Read();
            Book newBook2 = new Book("1984");
            newBook2.Read();
            Book newBook3 = new Book();
            newBook3.Read();
        }
    }
}
