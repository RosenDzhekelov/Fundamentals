using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d{2})(/|.|-)([A-Z][a-z]{2})\2(\d{4})\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var validDates = regex.Matches(input);
            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }
        }
    }
}
