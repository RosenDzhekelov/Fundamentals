using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var rescources = new Dictionary<string, int>();
            int counter = 1;
            string key = "";
            int value = 0;
            while(input!="stop")
            {
                if(counter%2==1)
                {
                        key = input;  
                }
                else if(counter%2==0)
                {
                    value = int.Parse(input);
                    if (!rescources.ContainsKey(key))
                    {
                        rescources.Add(key, value);
                    }
                    else
                    {
                        rescources[key] += value;
                    }
                }
                counter++;
                input = Console.ReadLine();
            }

            foreach (var item in rescources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
