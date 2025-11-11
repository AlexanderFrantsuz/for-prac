using System;
namespace task1
{
    internal class Program
    {
        class Car
        {
            private int speed;
            public int Speed
            {
                get { return speed; }
                set
                {
                    if (value < 0 || value > 300)
                    {
                        Console.WriteLine("Скорость не может превышать 300!");
                        return;
                    }
                    speed = value;
                }
            }
            public string Model { get; set; } = "Unknown";
            public Car(string model, int speed)
            {
                Model = model;
                Speed = speed;
            }
            public void Drive()
            {
                Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч");
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 150);
            car.Drive();
            car.Speed = 400;
            car.Drive();
            car.Speed = -50;
            car.Drive();
        }
    }
}
