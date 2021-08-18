using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @" ([a-zA-Z0-9]+|[a-zA-Z0-9]+[-._][a-zA-Z0-9])+@([a-z]+|[a-z]+[-][a-z])+[.]([a-z]+[.][a-z]+|[a-z]+)";
            string input = Console.ReadLine();
            var emails = Regex.Matches(input, pattern);
            foreach (var email in emails)
            {
                Console.WriteLine(email.ToString());
            }
        }
    }
}
