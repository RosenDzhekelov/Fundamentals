using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegExEx
{
    class Program
    {

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<furniture>[A-Z]+||[A-Z][a-z]+)<<(?<price>\d+(\.*\d+))!(?<quantity>\d+)\b";
            Regex regex = new Regex(pattern);
            decimal totalSum = 0;
            List<string> purchases = new List<string>();
            while (input != "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    Match results = regex.Match(input);
                    purchases.Add(results.Groups["furniture"].Value);
                    decimal price = decimal.Parse(results.Groups["price"].Value) * decimal.Parse(results.Groups["quantity"].Value);
                    totalSum += price;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            foreach (var purchase in purchases)
            {
                Console.WriteLine(purchase);
            }
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
