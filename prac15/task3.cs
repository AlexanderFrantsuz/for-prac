using System;
namespace task3
{
    interface Price
    {
        void GetPrice(double price);
    }
    interface Guarantee
    {
        void GuaranteePeriod(int period);
    }
    class Phone : Price, Guarantee
    {
        public double PhonePrice { get; set; }
        public int Period { get; set; }
        public void GetPrice(double price)
        {
            PhonePrice = price;
        }
        public void GuaranteePeriod(int period)
        {
            Period = period;
        }
    }
    class Laptop : Price
    {
        public double LaptopPrice { get; set; }
        public void GetPrice(double price)
        {
            LaptopPrice = price;
        }
    }
    internal class task3
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            phone.GetPrice(47999);
            phone.GuaranteePeriod(180);
            Laptop laptop = new Laptop();
            laptop.GetPrice(53999);
            Console.WriteLine($"Общая стоимость: {phone.PhonePrice + laptop.LaptopPrice}.");
            Console.WriteLine($"Гарантия: {phone.Period}.");
        }
    }
}
