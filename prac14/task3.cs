using System;

namespace task3
{
    class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }
    internal class task3
    {
        static void Main(string[] args)
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat();
        }
    }
}
