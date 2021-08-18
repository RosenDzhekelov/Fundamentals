using System;
using System.Collections.Generic;

namespace _07.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, DragonStats>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string color = input[0];
                string name = input[1];
                //damage = input[2];     health = input[3];         armor = input[4];
                //health 250, damage 45, and armor 10. 
                if (!dragons.ContainsKey(color))
                {
                    dragons.Add(color, new SortedDictionary<string, DragonStats>());
                }
                DragonStats dragonStats = new DragonStats();

                double damage = 45;
                double health = 250;
                double armor = 10;
                damage = IsNull(input[2], damage);
                health = IsNull(input[3], health);
                armor = IsNull(input[4], armor);
                dragonStats.Damage = damage;
                dragonStats.Armor = armor;
                dragonStats.Health = health;
                if (!dragons[color].ContainsKey(name))
                {
                    dragons[color].Add(name, dragonStats);
                }
                else
                {
                    dragons[color][name] = dragonStats;
                }
            }
            string type = string.Empty;
            double totalArmor = 0;
            double totalDamage = 0;
            double totalHealth = 0;
            double counter = 0;
            var averageStats = new Dictionary<string, DragonStats>();
            foreach (var dragon in dragons)
            {
                counter = 0;
                totalArmor = 0;
                totalHealth = 0;
                totalDamage = 0;
                if (!averageStats.ContainsKey(dragon.Key))
                {
                    averageStats.Add(dragon.Key, new DragonStats());

                    foreach (var item in dragon.Value)
                    {
                        totalArmor += item.Value.Armor;
                        totalHealth += item.Value.Health;
                        totalDamage += item.Value.Damage;
                        counter++;
                    }
                    DragonStats stats = new DragonStats();
                    stats.Armor = totalArmor / counter;
                    stats.Damage = totalDamage / counter;
                    stats.Health = totalHealth / counter;
                    averageStats[dragon.Key] = stats;

                }


            }
            //"{Type}::({damage}/{health}/{armor})"
            foreach (var item in averageStats)
            {
                Console.WriteLine($"{item.Key}::({item.Value.Damage:F2}/{item.Value.Health:F2}/{item.Value.Armor:F2})");
                foreach (var dragon in dragons)
                {
                    if (item.Key == dragon.Key)
                    {
                        foreach (var drag in dragon.Value)
                        {
                            //{Name} -> damage: {damage}, health: {health}, armor: {armor}"
                            Console.WriteLine($"-{drag.Key} -> damage: {drag.Value.Damage}, health: {drag.Value.Health}, armor: {drag.Value.Armor}");
                        }
                    }
                    
                }
            }

        }


        static double IsNull(string input, double value)
        {
            if (input != "null")
            {
                return double.Parse(input);
            }
            else return value;

        }
    }


    class DragonStats
    {
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }
    }
}
