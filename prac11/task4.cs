using System;
namespace task4
{
    public class Player
    {
        private int level;
        private int health;
        public int Level
        {
            get { return level; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("Уровень должен быть от 1 до 100!");
                    return;
                }
                level = value;
            }
        }
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Уровень здоровья должен быть от 0 до 100!");
                    return;
                }
                health = value;
            }
        }
        public string Name { get; private set; }
        public bool IsAlive => Health > 0 ? true : false;
        public Player(string name, int level, int health)
        {
            Name = name;
            Level = level;
            Health = health;
        }
        public void TakeDamage(int damage)
        {
            if (Health - damage < 0)
            {
                Console.WriteLine("Уровень здоровья не может опуститься ниже 0!");
                return;
            }
            Health -= damage;
            Console.WriteLine($"Игрок: {Name}, уровень: {Level}, здоровье: {Health}, жив: {IsAlive}");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player = new Player("Alex", 5, 100);
            player.TakeDamage(30);
            player.TakeDamage(30);
            player.TakeDamage(40);
            player.Level = 0;
        }
    }
}
