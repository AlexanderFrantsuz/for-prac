namespace OOP
{
    internal class Program
    {
        class Person
        {
            public int Id { get; set; }
            private string name = "";
            private int age;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set
                {
                    if (value > 0 && value < 121) age = value;
                }
            }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void SayHello()
            {
                Console.WriteLine($"Привет, я {name}, мне {age} лет!");
            }
        }
        class Phone
        {
            public int Id { get; set; }
            private string brand = "";
            private int batteryLevel;
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }
            public int BatteryLevel
            {
                get { return batteryLevel; }
                set
                {
                    if (value < 0 || value > 100)
                    {
                        Console.WriteLine("Заряд должен быть от 0 до 100!");
                        return;
                    }
                    else batteryLevel = value;
                }
            }
            public Phone(string brand, int battery)
            {
                Brand = brand;
                batteryLevel = battery;
            }
            public void UsePhone()
            {
                batteryLevel -= 10;
                Console.WriteLine($"Телефон {brand}, заряд: {batteryLevel}%");
            }
        }
        class BankAccount
        {
            public int Id { get; set; }
            private string owner = "";
            private int balance;
            public string Owner
            {
                get { return owner; }
                set { owner = value; }
            }
            public int Balance
            {
                get { return balance; }
                set { if (value > 0) balance = value; }
            }
            public BankAccount(string name, int startBalance)

            {
                Owner = name;
                Balance = startBalance;
            }
            public void deposit(int amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"{owner}, баланс: {balance}.");
                }
            }
            public void Withdraw(int amount)
            {
                if (balance < amount) Console.WriteLine("Недостаточно средств!");
                else if (amount > 0)
                {
                    balance -= amount;
                    Console.WriteLine($"{owner}, баланс: {balance}.");
                }
            }
        }
        class Circle
        {
            public int Id { get; set; }
            private double radius;
            public double Radius
            {
                get { return radius; }
                set { if (value > 0) radius = value; }
            }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public void GetArea()
            {
                double res = Math.PI * radius * radius;
                Console.WriteLine($"Площадь круга: {res}");
            }
        }
        class Pet
        {
            public int Id { get; set; }
            private string name = "";
            private int energy;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Energy
            {
                get { return energy; }
                set { if (value > 0 && value < 101) energy = value; }
            }
            public Pet(string name, int energy)
            {
                Name = name;
                Energy = energy;
            }
            public void Play()
            {
                energy -= 20;
                if (energy < 0) energy = 0;
                Console.WriteLine($"{name} играет, энергия: {energy}");
            }
            public void Rest()
            {
                energy += 30;
                if (energy > 100) energy = 100;
                Console.WriteLine($"{name} отдыхает, энергия: {energy}");
            }
        }
        static void Main(string[] args)
        {
            Person a = new Person("Bob", 18);
            a.SayHello();
            Console.WriteLine();

            Phone iphone = new Phone("iphone", -10);
            iphone.UsePhone();
            iphone.UsePhone();
            Console.WriteLine();

            BankAccount Bob = new BankAccount("Bob", 1500);
            Bob.deposit(500);
            Bob.Withdraw(400);
            Bob.Withdraw(10000);
            Console.WriteLine();

            Circle circle = new Circle(5);
            circle.GetArea();
            Console.WriteLine();

            Pet meow = new Pet("meow", 60);
            meow.Play();
            meow.Rest();
            meow.Energy = 10;
            meow.Play();
            Console.ReadLine();
        }
    }
}