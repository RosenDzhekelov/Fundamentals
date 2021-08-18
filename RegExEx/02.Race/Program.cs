using System;
using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string capitalPattern = @"[A-Z]";
            string lowerPattern = @"[a-z]+";
            string digitPattern = @"[0-9]";
            List<string> participants = Console.ReadLine()
                .Split(", ").ToList();
            string input = Console.ReadLine();
            Dictionary<string, int> racers = new Dictionary<string, int>();
            while (input != "end of race")
            {
                string name = string.Empty;
                Match firstLetter = Regex.Match(input, capitalPattern);
                MatchCollection letters = Regex.Matches(input, lowerPattern);
                 name = firstLetter.Value;
                foreach (Match letter in letters)
                {
                    name += letter.Value;
                }
                if (!participants.Contains(name))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    MatchCollection digits = Regex.Matches(input, digitPattern);
                    int distance = 0;
                    foreach (Match digit in digits)
                    {
                        distance += int.Parse(digit.Value.ToString());
                    }
                    if (!racers.ContainsKey(name))
                    {
                        racers.Add(name, distance);
                    }
                    else
                    {
                        racers[name] += distance;
                    }
                }

                input = Console.ReadLine();
            }
            int i = 1;
            foreach (var racer in racers.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{Placement(i)} place: {racer.Key}");
                if (i == 3)
                {
                    break;
                }
                i++;
               
            }
            
        }

        static string Placement(int i)
        {
            string result = string.Empty;
            if (i == 1)
            {
                result = "1st";
            }
            else if (i == 2)
            {
                result = "2nd";
            }
            else
            {
                result = "3rd";
            }
            return result;
        }
    }
}
