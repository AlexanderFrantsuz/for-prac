using System;
namespace task3
{
    internal class Program
    {
        class Device
        {
            private string brand;

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public Device(string brand)
            {
                this.brand = brand;
            }
            public void PowerOn()
            {
                Console.WriteLine($"{brand} включен.");
            }
        }
        class Laptop : Device
        {
            private int ram;
            private int battery;

            public Laptop(string brand, int ram, int battery, ref bool flag) : base(brand)
            {
                if (ram < 1 || ram > 64 || battery < 0 || battery > 100)
                {
                    Console.WriteLine("Ошибка. ОЗУ должно быть от 1 до 64, а заряд должен быть в диапозоне (0-100)");
                    flag = false;
                    return;
                }
                this.ram = ram;
                this.battery = battery;
            }

            public void Work()
            {
                Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {ram}, батарея: {battery}%");
            }
        }
        static void Main(string[] args)
        {
            bool flag = true;
            Laptop laptop = new Laptop("Dell", 16, 55, ref flag);
            if (flag)
            {
                laptop.PowerOn();
                laptop.Work();
            }
        }
    }
}
