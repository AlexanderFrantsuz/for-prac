
using System;

namespace Practice12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObjectCounter object1 = new ObjectCounter();
            ObjectCounter.PrintCountObjects();
            ObjectCounter object2 = new ObjectCounter();
            ObjectCounter.PrintCountObjects();
            Console.ReadLine();
        }
    }
}
