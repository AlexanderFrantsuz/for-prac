using System;
namespace task2
{
    interface Turn
    {
        void TurnOn();
        void TurnOff();
    }
    interface SetLevel
    {
        void Set(int level);
    }
    class Lamp : Turn, SetLevel
    {
        public int Level { get; set; }
        public void TurnOn()
        {
            Level = 100;
            Console.WriteLine($"Уровень лампы: {Level}.");
        }
        public void TurnOff()
        {
            Level = 0;
            Console.WriteLine($"Уровень лампы: {Level}.");
        }
        public void Set(int level)
        {
            if (level < 0 || level > 100)
            {
                Console.WriteLine("Ошибка: уровень должен быть в диапозоне 0-100.");
                return;
            }
            Level = level;
            Console.WriteLine($"Уровень лампы: {Level}.");
        }
    }
    class Fan : Turn
    {
        public void TurnOn()
        {
            Console.WriteLine("Вентилятор включился.");
        }
        public void TurnOff()
        {
            Console.WriteLine("Вентилятор выключился.");
        }
    }
    internal class task2
    {
        static void Main(string[] args)
        {
            Turn[] turns = { new Lamp(), new Fan() };
            foreach (var turn in turns)
            {
                turn.TurnOn();
                turn.TurnOff();
            }
            Lamp lamp = new Lamp();
            lamp.Set(30);
        }
    }
}
