using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sides = new Dictionary<string, List<string>>();

            while (input != "Lumpawaroo")
            {
                string splitter = "";
                for (int i = 0; i < input.Length-1; i++)
                {
                    if(input[i]=='-'||input[i]=='>' || input[i]=='|')
                    {
                        splitter += input[i];
                        if(splitter=="->" || splitter=="|")
                        {
                            break;
                        }
                    }
                }
                
                if (splitter == "->")
                {
                    string[] inputArgs = input.
                    Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string name = inputArgs[0];
                    string key = inputArgs[1];
                    bool isPresent = IsPresent(sides,name);
                    bool isRemoved = false;
                   
                    if(isPresent)
                    {
                        foreach (var side in sides)
                        {
                            foreach (var i in side.Value)
                            {
                                if(i==name)
                                {
                                    isRemoved = true;
                                    side.Value.Remove(i);
                                    break;
                                }
                            }
                            if(isRemoved)
                            {
                                break;
                            }
                        }
                    }
                    if (!sides.ContainsKey(key))
                    {
                        sides.Add(key, new List<string> { name });
                    }
                    else
                    {
                        sides[key].Add(name);
                    }
                    Console.WriteLine($"{name} joins the {key} side!");

                }
                else if (splitter == "|")
                {
                    string[] inputArgs = input.
                   Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string name = inputArgs[1];
                    string key = inputArgs[0];
                    bool isPresent = IsPresent(sides,name);
                    if (!sides.ContainsKey(key))
                    {
                        if(!isPresent)
                        {
                            sides.Add(key, new List<string> { name });
                        }
                    }
                    else
                    {
                        if(!isPresent)
                        {
                            sides[key].Add(name);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var side in sides.Where(x => x.Value.Count > 0).OrderByDescending(x=> x.Value.Count).ThenBy(x=> x.Key))
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var item in side.Value.OrderBy(x=> x))
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }



        static bool IsPresent(Dictionary<string, List<string>> sides,string name)
        {
            bool isPresent = false;
            foreach (var side in sides)
            {
                foreach (var i in side.Value)
                {
                    if (i == name)
                    {
                        isPresent = true;
                        return isPresent;
                    }
                }
            }
            return isPresent;
        }
    }
}
