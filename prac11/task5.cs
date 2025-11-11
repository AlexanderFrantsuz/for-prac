using System;
namespace task5
{
    public class Product
    {
        private int price;
        private int discount;
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                    return;
                }
                price = value;
            }
        }
        public int Discount
        {
            get { return discount; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Скидка должна быть от 0 до 100!");
                    return;
                }
                discount = value;
            }
        }
        public string Name { get; set; } = "Без названия";
        public int FinalPrice => Price * (1 - Discount / 100);
        public Product(int price, int discount)
        {
            Price = price;
            Discount = discount;
        }
        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice} (скидка {Discount}%)");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product = new Product(800, 20);
            product.Name = "Ноутбук";
            product.Show();
            product.Price = -100;
        }
    }
}
