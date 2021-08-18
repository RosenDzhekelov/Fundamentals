using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[a-zA-Z!-):-@[-`{-~]";
            string positiveDamage = @"(?<positive>[\d.\d]+)|(?<negative>-[\d.\d]+)";
            string multiplyDamage = @"[*]";
            string divideDamage = @"[/]";
            List<string> input = Console.ReadLine().Split(new char[] { ' ', ',' }).ToList();
            int health = 0;
            double damage = 0;
            List<Demon> demonsStats = new List<Demon>();
            foreach (var demon in input)
            {
                Demon dem = new Demon();
                health = 0;
                damage = 0;
                dem.Name = demon;
                if (Regex.IsMatch(demon, healthPattern))
                {
                    var healthMatches = Regex.Matches(demon,healthPattern);
                   
                    foreach (Match item in healthMatches)
                    {
                        health += char.Parse(item.ToString());
                    }
                    dem.Health = health;
                    var damageMatches = Regex.Matches(demon, positiveDamage);

                    foreach (Match item in damageMatches)
                    {
                        string negative = item.Groups["negative"].Value.ToString();
                        if (negative != string.Empty)
                        {
                            damage -= double.Parse(item.Groups["negative"].Value.ToString().Remove(0,1));
                        }
                        string positive = item.Groups["positive"].Value.ToString();
                        if (positive != string.Empty)
                        {
                            damage += double.Parse(item.Groups["positive"].Value.ToString());
                        }
                    }
                    var multiplications = Regex.Matches(demon, multiplyDamage);
                    for (int i = 0; i < multiplications.Count; i++)
                    {
                        damage *= 2;
                    }
                    var division = Regex.Matches(demon, divideDamage);
                    for (int i = 0; i < division.Count; i++)
                    {
                        damage /= 2;
                    }
                    dem.Damage = damage;
                    demonsStats.Add(dem);
                }
            }

            foreach (var demon in demonsStats.OrderBy(x=> x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
