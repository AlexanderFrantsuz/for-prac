using System;
namespace ConsoleApp7
{
    internal class task4
    {
        interface Attacker
        {
            void Attack();
        }
        interface Healer
        {
            void Heal();
        }
        class Warrior : Attacker
        {
            public void Attack()
            {
                Console.WriteLine("Воин атакует!");
            }
        }
        class Mage : Attacker, Healer
        {
            public void Attack()
            {
                Console.WriteLine("Маг атакует!");
            }
            public void Heal()
            {
                Console.WriteLine("Маг лечит!");
            }
        }
        static void Main(string[] args)
        {
            Attacker[] attackers = { new Warrior(), new Mage() };
            foreach (var unite in attackers)
                unite.Attack();
            Mage mage = new Mage();
            mage.Heal();
        }
    }
}