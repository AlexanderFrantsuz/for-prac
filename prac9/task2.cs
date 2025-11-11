
using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("", 0);
            Console.Write("Введите бренд: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str)) phone.brand = str;
            else
            {
                Console.WriteLine("Ошибка. Строка пуста или состоит только из пробелов");
                return;
            }
            Console.Write("Введите уровень заряда: ");
            if (int.TryParse(Console.ReadLine(), out int userBetterLevel) && userBetterLevel >= 0 && userBetterLevel <= 100) phone.betterLevel = userBetterLevel;
            else
            {
                Console.WriteLine("Заряд должен быть от 0 до 100.");
                return;
            }
            phone.UsePhone();
        }
    }
    class Phone
    {
        private string Brand;
        private int BetterLevel;
        public Phone(string NameBrand, int NameBetterLevel)
        {
            Brand = NameBrand;
            BetterLevel = NameBetterLevel;
        }
        public void UsePhone()
        {
            if (BetterLevel - 10 < 0) Console.WriteLine("Заряд не может опуститься меньше 0");
            else BetterLevel -= 10;
            Console.WriteLine($"Телефон {Brand}, заряд {BetterLevel}");
        }
        public string brand
        {
            set { Brand = value; }
            get { return Brand; }
        }
        public int betterLevel
        {
            set { BetterLevel = value; }
            get { return BetterLevel; }
        }
    }
}
