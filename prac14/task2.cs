using System;
namespace task2
{
    class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено.");
        }
    }
    class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email отправлен!");
        }
    }
    class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }
    internal class task2
    {
        static void Main(string[] args)
        {
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();
        }
    }
}
