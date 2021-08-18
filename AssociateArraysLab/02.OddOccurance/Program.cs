using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.OddOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            List<string> text = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var newText = new Dictionary<string, int>();
            foreach (var item in text)
            {
                if(newText.ContainsKey(item))
                {
                    newText[item]++;
                }
                else
                {
                    newText.Add(item, 1);
                }
            }

            foreach (var item in newText)
            {
                if(item.Value%2!=0)
                {
                    Console.Write(item.Key+" ");
                }
            }

            
        }
    }
}
