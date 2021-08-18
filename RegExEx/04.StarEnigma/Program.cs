using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string starPattern = @"[starSTAR]";
            int symbolsCount = 0;

            string planetPattern = @"@(?<planet>[A-Za-z]+)";
            string populationPattern = @":(?<population>\d+)";
            string attackPattern = @"!(?<attack>[AD])!";
            string soldierPattern = @"->(?<soldier>\d+)";

            Dictionary<string, List<string>> planets = new Dictionary<string, List<string>>();
            planets.Add("Attacked planets", new List<string>());
            planets.Add("Destroyed planets", new List<string>());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, starPattern))
                {
                    var symbols = Regex.Matches(input, starPattern);
                    symbolsCount = symbols.Count;
                }
                StringBuilder sb = new StringBuilder();
                foreach (var item in input)
                {
                    sb.Append((char)(item - symbolsCount));
                }
                string decrypted = sb.ToString();
                bool isMatch = Regex.IsMatch(decrypted, planetPattern) && Regex.IsMatch(decrypted, populationPattern)
                    && Regex.IsMatch(decrypted, attackPattern) && Regex.IsMatch(decrypted, soldierPattern);
                bool isOrdered = decrypted.IndexOf('@') < decrypted.IndexOf(':')
                    && decrypted.IndexOf(':') < decrypted.IndexOf('!')
                    && decrypted.IndexOf('!') < decrypted.IndexOf('-');

                if (isMatch && isOrdered)
                {
                    var type = Regex.Match(decrypted, attackPattern);
                    string attackType = type.Groups["attack"].Value;
                    if (attackType == "A")
                    {
                        attackType = "Attacked planets";
                    }
                    else if (attackType == "D")
                    {
                        attackType = "Destroyed planets";
                    }
                    var name = Regex.Match(decrypted, planetPattern);
                    string planetName = name.Groups["planet"].Value;
                    planets[attackType].Add(planetName);

                }
                else
                {
                    continue;
                }
            }
            foreach (var planet in planets)
            {
                Console.WriteLine($"{planet.Key}: {planet.Value.Count}");
                if (planet.Value.Count > 0)
                {
                    foreach (var name in planet.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"-> {name}");
                    }
                }
            }

        }
    }
}
