using System;
using System.Xml.XPath;

namespace MyRoguelike
{

    class Program
    {

        private static void Main(string[] args)
        {
            Hero hero = new Hero(30, 70, "john");
                
                Console.WriteLine($"The hero has {hero.GetXp} xp, {hero.MaxHealth} health, and his name is {hero.GetName}");

                hero.XP(30);
                hero.TakeDamage(20);
                
                Console.WriteLine($"The hero has {hero.GetXp} xp, {hero.MaxHealth} health, and his name is {hero.GetName}");
                
        }
    }
}