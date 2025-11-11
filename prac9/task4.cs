using System;
namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(0);
            Console.Write("Введите радиус: ");
            if (!double.TryParse(Console.ReadLine(), out double num) || num <= 0)
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
                return;
            }
            circle.RADIUS = num;
            circle.GetArea();
        }
    }
    class Circle
    {
        private double radius;
        private double S;
        public Circle(double Radius)
        {
            radius = Radius;
        }
        public void GetArea()
        {
            S = radius * radius * Math.PI;
            Console.WriteLine($"Площадь круга: {S}");
        }
        public double RADIUS
        {
            set { radius = value; }
            get { return radius; }
        }
    }
}
