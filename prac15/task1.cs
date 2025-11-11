using System;
namespace task1
{
    interface RobotWorker
    {
        void Work();
    }
    interface RobotCharge
    {
        void Charge();
    }
    class Robot : RobotWorker, RobotCharge
    {
        public string Name { get; set; }
        public int Energy { get; set; }
        public Robot(string name, int energy)
        {
            Name = name;
            if (energy < 0 || energy > 100)
            {
                Console.WriteLine("Энергия должна быть в диапозоне 0-100.");
                return;
            }
            Energy = energy;
        }
        public void Work()
        {
            if (Energy - 20 >= 0)
            {
                Energy -= 20;
                Console.WriteLine($"Имя робота: {Name}, текущий уровень энергии: {Energy}.");
            }
            else Console.WriteLine("Ошибка: Энергия не может опуститься ниже 0.");
        }
        public void Charge()
        {
            if (Energy + 50 <= 100)
            {
                Energy += 50;
                Console.WriteLine($"Имя робота: {Name}, текущий уровень энергии: {Energy}.");
            }
            else Console.WriteLine("Ошибка: энергия не может подняться выше 100.");
        }
    }
    internal class task1
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Alex", 88);
            robot.Work();
            robot.Work();
            robot.Charge();
            robot.Work();
        }
    }
}
