using System;
namespace task5
{
    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
    internal class task5
    {
        static void Main(string[] args)
        {
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team) p.Attack();
        }
    }
}
