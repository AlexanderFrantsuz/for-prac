using System;
namespace task2
{
    internal class Program
    {
        class Employee
        {
            private string name;
            private double salary;

            public Employee(string name, double salary)
            {
                this.name = name;
                this.salary = salary;
            }

            public Employee(string name) : this(name, 50000) { }
            public void Work()
            {
                if (salary >= 0 && salary <= 1000000)
                {
                    Console.WriteLine($"{name} работает, зарплата: {salary}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Зарплата не может быть отрицательной");
                    return;
                }
            }
        }
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee("Маша", 80000);
            newEmployee.Work();
            Employee newEmployee2 = new Employee("Паша");
            newEmployee2.Work();
        }
    }
}
