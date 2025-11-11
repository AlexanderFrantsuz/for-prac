using System;
namespace task4
{
    internal class Program
    {
        class Point
        {
            private double x;
            private double y;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public Point(double value) : this(value, value) { }
            public Point() : this(0, 0) { }
            public void Show()
            {
                Console.WriteLine($"Точка: ({x}, {y}).");
            }
        }
        static void Main(string[] args)
        {
            Point point1 = new Point(3.5, 7.2);
            point1.Show();
            Point point2 = new Point(5);
            point2.Show();
            Point point3 = new Point();
            point3.Show();
        }
    }
}
