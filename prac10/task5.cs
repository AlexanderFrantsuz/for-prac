using System;
namespace task5
{
    internal class Program
    {
        class Animal
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public Animal(string name)
            {
                this.name = name;
            }
            public void Speak(ref bool flag)
            {
                if (!flag) return;
                Console.WriteLine($"{name} издает звук.");
            }
        }
        class Cat : Animal
        {
            private int lives;
            public Cat(string name, int lives, ref bool flag) : base(name)
            {
                if (lives < 1 || lives > 9)
                {
                    Console.WriteLine("Жизней не может быть больше 9 и меньше 1");
                    flag = false;
                }
                this.lives = lives;
            }
            public Cat(string name, ref bool flag) : this(name, 9, ref flag) { }
            public void Meow(ref bool flag)
            {
                if (lives - 1 < 1)
                {
                    Console.WriteLine("Жизней не может быть меньше 1");
                    return;
                }
                lives--;
                Console.WriteLine($"{Name} мяукнул, осталось жизней: {lives}");
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            Cat cat1 = new Cat("Вася", 5, ref flag);
            Cat cat2 = new Cat("Гоша", ref flag);
            if (flag)
            {
                cat1.Speak(ref flag);
                cat1.Meow(ref flag);
                cat2.Speak(ref flag);
                cat2.Meow(ref flag);
            }
        }
    }
}
