using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1:
            Queue<string> customerQueue = new Queue<string>();
            string[] customers = { "Анна", "Пётр", "Ольга", "Иван", "Мария" };

            foreach (string customer in customers)
            {
                customerQueue.Enqueue(customer);
            }

            Console.Write("Очередь: ");
            Console.WriteLine(string.Join(", ", customerQueue));

            while (customerQueue.Count > 0)
            {
                string currentCustomer = customerQueue.Dequeue();
                Console.WriteLine($"Обслуживаем: {currentCustomer}");
            }
            Console.WriteLine("Очередь пуста");
            Console.WriteLine();

            // Задание 2: 
            Stack<string> actions = new Stack<string>();
            Console.WriteLine("Введите строки (пустая строка для завершения):");

            string input;
            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    actions.Push(input);
                }
            } while (!string.IsNullOrEmpty(input));

            Console.WriteLine("\nВывод (как отмена):");
            while (actions.Count > 0)
            {
                Console.WriteLine(actions.Pop());
            }
            Console.WriteLine();

            // Задание 3: 
            HashSet<string> uniqueNames = new HashSet<string>();
            Console.WriteLine("Введите имена (пустая строка для завершения):");

            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    uniqueNames.Add(input);
                }
            } while (!string.IsNullOrEmpty(input));

            Console.Write("Уникальные: ");
            Console.WriteLine(string.Join(", ", uniqueNames.OrderBy(name => name)));
            Console.WriteLine();

            // Задание 4:
            LinkedList<string> browserHistory = new LinkedList<string>();
            LinkedListNode<string> currentNode = null;

            Console.WriteLine("Введите команды (пустая строка для завершения):");
            Console.WriteLine("Формат: [страница] или 'back'");

            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;

                if (input.ToLower() == "back")
                {
                    if (currentNode != null && currentNode.Previous != null)
                    {
                        currentNode = currentNode.Previous;
                        Console.WriteLine($"Текущая страница: {currentNode.Value}");
                    }
                    else
                    {
                        Console.WriteLine("Нет предыдущей страницы.");
                    }
                }
                else
                {
                    browserHistory.AddLast(input);
                    currentNode = browserHistory.Last;
                    Console.WriteLine($"Текущая страница: {currentNode.Value}");
                }
            } while (!string.IsNullOrEmpty(input));
            Console.WriteLine();

            // Задание 5:
            Dictionary<string, bool> cacheDict = new Dictionary<string, bool>();
            Queue<string> cacheOrder = new Queue<string>();
            const int CACHE_SIZE = 3;

            Console.WriteLine("Введите команды (пустая строка для завершения):");
            Console.WriteLine("Формат: '+ [страница]'");

            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;

                if (input.StartsWith("+ "))
                {
                    string page = input.Substring(2).Trim();

                    if (cacheDict.ContainsKey(page))
                    {
                        Console.WriteLine($"Страница '{page}' уже в кэше.");
                    }
                    else
                    {
                        if (cacheDict.Count >= CACHE_SIZE)
                        {
                            string oldestPage = cacheOrder.Dequeue();
                            cacheDict.Remove(oldestPage);
                            Console.WriteLine($"- удаляется {oldestPage}");
                        }

                        cacheDict[page] = true;
                        cacheOrder.Enqueue(page);
                    }

                    Console.Write("Текущий кэш: ");
                    Console.WriteLine(string.Join(", ", cacheOrder));
                }
            } while (!string.IsNullOrEmpty(input));

            Console.ReadLine(); 
        }
    }
}