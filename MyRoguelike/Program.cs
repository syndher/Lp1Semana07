using System;
using System.Xml.XPath;

namespace MyRoguelike
{

    class Program
    {

        private static void Main(string[] args)
        {
            Hero hero = new Hero(30, 70, "john");
                
                Console.WriteLine($"The hero has {hero.Level} xp, {hero.MaxHealth} health, and his name is {hero.GetName}");

                hero.XP(1000);
                hero.TakeDamage(10);
                
                Console.WriteLine($"The hero has {hero.Level} xp, {hero.MaxHealth} health, and his name is {hero.GetName}");
                
        }
    }
}