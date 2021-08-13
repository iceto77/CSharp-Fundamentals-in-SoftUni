using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(int hitPoints, int manaPoints)
        {
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public int HitPoints { get; set; }
        public int ManaPoints { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            string input = string.Empty;
            for (int i = 0; i < numberOfHeroes; i++)
            {
                input = Console.ReadLine();
                string[] newHero = input.Split().ToArray();
                heroes.Add(newHero[0], new Hero(int.Parse(newHero[1]), int.Parse(newHero[2])));                
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split(" - ").ToArray();
                switch (command[0])
                {
                    case "CastSpell":
                        string spellName = command[3];
                        int requiredMP = int.Parse(command[2]);
                        if (heroes[command[1]].ManaPoints >= requiredMP)
                        {
                            heroes[command[1]].ManaPoints -= requiredMP;
                            Console.WriteLine($"{command[1]} has successfully cast {spellName} and now has {heroes[command[1]].ManaPoints} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{command[1]} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        string attacker = command[3];
                        int damage = int.Parse(command[2]);
                        if (heroes[command[1]].HitPoints > damage)
                        {
                            heroes[command[1]].HitPoints -= damage;
                            Console.WriteLine($"{command[1]} was hit for {damage} HP by {attacker} and now has {heroes[command[1]].HitPoints} HP left!");
                        }
                        else
                        {
                            heroes.Remove(command[1]);
                            Console.WriteLine($"{command[1]} has been killed by {attacker}!");
                        }
                        break;
                    case "Recharge":
                        int rechargeMP = int.Parse(command[2]);
                        if (heroes[command[1]].ManaPoints + rechargeMP > 200)
                        {
                            rechargeMP = 200 - heroes[command[1]].ManaPoints;
                        }
                        heroes[command[1]].ManaPoints += rechargeMP;
                        Console.WriteLine($"{command[1]} recharged for {rechargeMP} MP!");
                        break;
                    case "Heal":
                        int rechargeHP = int.Parse(command[2]);
                        if (heroes[command[1]].HitPoints + rechargeHP > 100)
                        {
                            rechargeHP = 100 - heroes[command[1]].HitPoints;
                        }
                        heroes[command[1]].HitPoints += rechargeHP;
                        Console.WriteLine($"{command[1]} healed for {rechargeHP} HP!");
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in heroes.OrderByDescending(x => x.Value.HitPoints).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"  HP: {item.Value.HitPoints}");
                Console.WriteLine($"  MP: {item.Value.ManaPoints}");
            }
        }
    }
}
