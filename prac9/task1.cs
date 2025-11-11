using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("", 0);
            Console.Write("Введите имя: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str)) person.Name = str;
            else
            {
                Console.WriteLine("Ошибка, строка пустая или содержит только пробелы");
                return;
            }
            Console.Write("Введите возраст: ");
            if (int.TryParse(Console.ReadLine(), out int userAge) && userAge >= 0 && userAge <= 120) person.Age = userAge;
            else
            {
                Console.WriteLine("Возраст должен быть от 0 до 120.");
                return;
            }
            person.SayHello();
        }
    }
    class Person
    {
        private string name;
        private int age;
        public Person(string personName, int personAge)
        {
            name = personName;
            age = personAge;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public void SayHello()
        {
            Console.WriteLine($"Привет, я {name}, мне {age} лет!");
        }
    }
}