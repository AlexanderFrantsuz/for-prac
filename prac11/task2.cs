using System;
namespace task2
{
    public class Phone
    {
        private int battery;
        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Заряд не может превышать 100!");
                    return;
                }
                battery = value;
            }
        }
        public string Brand { get; private set; }
        public Phone(string brand, int batteryLevel)
        {
            Brand = brand;
            BatteryLevel = batteryLevel;
        }
        public void Use()
        {
            if (battery - 10 < 0)
            {
                Console.WriteLine("Заряд не может опуститься меньше 0!");
                return;
            }
            battery -= 10;
            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Phone phone = new Phone("Samsung", 80);
            phone.Use();
            phone.Use();
            phone.Use();
            Phone phoneError = new Phone("Samsung", 150);
        }
    }
}