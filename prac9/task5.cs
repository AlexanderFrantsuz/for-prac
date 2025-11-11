
using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("", 0);
            Console.Write("Введите имя питомца: ");
            string str = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Ошибка. Строка пуста либо содержит только пробелы.");
                return;
            }
            pet.NAME = str;
            Console.Write("Введите количество энергии питомца (целое число от 0 до 100): ");
            if (!int.TryParse(Console.ReadLine(), out int num) || num < 0 || num > 100)
            {
                Console.WriteLine("Количество энергии должно быть в диапозоне (0-100)");
                return;
            }
            pet.ENERGY = num;
            pet.Play();
            pet.Rest();
        }
    }
    class Pet
    {
        private string name;
        private int energy;
        public Pet(string Name, int Energy)
        {
            name = Name;
            energy = Energy;
        }
        public void Play()
        {
            if (energy - 20 >= 0)
            {
                energy -= 20;
                Console.WriteLine($"{name} играет, энергия: {energy}");
            }
            else
            {
                Console.WriteLine("Энергия питомца не может опуститься ниже 0.");
                return;
            }
        }
        public void Rest()
        {
            if (energy + 30 <= 100)
            {
                energy += 30;
                Console.WriteLine($"{name} отдыхает, энергия: {energy}");
            }
            else
            {
                Console.WriteLine("Энергия питомца не может быть больше 100.");
                return;
            }
        }
        public string NAME
        {
            set { name = value; }
            get { return name; }
        }
        public int ENERGY
        {
            set { energy = value; }
            get { return energy; }
        }
    }
}
