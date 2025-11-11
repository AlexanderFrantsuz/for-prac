using System;
namespace task4
{
    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }
    class Triangle : Shape
    {
        public override string Draw()
        {
            return "Рисую треугольник";
        }
    }
    internal class task4
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());
        }
    }
}
