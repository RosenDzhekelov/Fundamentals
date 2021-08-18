using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Snowhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dwarves = new Dictionary<string, Dictionary<string, int>>();
            while(input!="Once upon a time")
            {
                string[] splitter = input
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);

                string name = splitter[0];
                string color = splitter[1];
                int physics = int.Parse(splitter[2]);
                if(!dwarves.ContainsKey(color))
                {
                    dwarves.Add(color, new Dictionary<string, int>());
                    dwarves[color].Add(name, physics);   
                }
                else
                {
                    if (!dwarves[color].ContainsKey(name))
                    {
                        dwarves[color].Add(name, physics);
                    }
                    else if (dwarves[color][name] < physics)
                    {
                        dwarves[color][name] = physics;
                    }
                }


                input = Console.ReadLine();
            }

            Dictionary<string, int> dwData = new Dictionary<string, int>();
            foreach (var dwarf in dwarves.OrderByDescending(d => d.Value.Count))
            {
                foreach (var data in dwarf.Value)
                {
                    dwData.Add($"({dwarf.Key}) {data.Key} <-> ", data.Value);
                }
            }
            foreach (var dwarf in dwData.OrderByDescending(d => d.Value))
            {
                Console.WriteLine($"{dwarf.Key}{dwarf.Value}");
            }
        }
    }
}
