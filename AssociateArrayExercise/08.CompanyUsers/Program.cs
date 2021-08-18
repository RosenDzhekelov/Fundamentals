using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var companies = new SortedDictionary<string, List<string>>();
            while(input!="End")
            {
                List<string> inputArgs = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string name = inputArgs[0];
                string userId = inputArgs[1];

                if(!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string> { userId });
                }
                 else if(!companies[name].Contains(userId))
                {
                    companies[name].Add(userId);
                }



                input = Console.ReadLine();
            }
            foreach (var company in companies)
            {
                Console.WriteLine(company.Key);
               
                foreach (var user in company.Value)
                {
                    Console.WriteLine($"-- {user}");
                   
                }
            }
        }
    }
}
