using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {


            var legendaries = new Dictionary<string, int>();
            var junk = new SortedDictionary<string, int>();
            bool isFarmed = false;
            legendaries.Add("fragments", 0);
            legendaries.Add("shards", 0);
            legendaries.Add("motes", 0);


            while (true)
            {
                List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                int count = input.Count;
                for (int i = 0; i < count / 2; i++)
                {
                    int value = int.Parse(input[0]);
                    string key = input[1].ToLower();
                    input.RemoveAt(0);
                    input.RemoveAt(0);
                    if (key == "fragments" || key == "shards" || key == "motes")
                    {
                        legendaries[key] += value;
                        if (legendaries[key] >= 250)
                        {
                            if (key == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                                legendaries[key] -= 250;

                            }
                            else if (key == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                legendaries[key] -= 250;
                            }
                            else if (key == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                legendaries[key] -= 250;
                            }
                            isFarmed = true;
                            break;
                        }
                    }
                    else
                    {
                        if (junk.ContainsKey(key))
                        {
                            junk[key] += value;
                        }
                        else
                        {
                            junk.Add(key, value);
                        }
                    }

                }

                if (isFarmed)
                {
                    break;
                }

            }

            foreach (var item in legendaries.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
