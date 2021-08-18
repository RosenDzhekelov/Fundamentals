using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][3][5][9](\s|-)[2]\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var validNumbers = regex.Matches(phones);
            List<string> result = new List<string>();
            foreach (Match item in validNumbers)
            {
                result.Add(item.Value);
            }
            Console.WriteLine(String.Join(", ",result));
        }
    }
}
