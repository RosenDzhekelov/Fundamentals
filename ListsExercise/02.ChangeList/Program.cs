using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] commands = input.Split().ToArray();
                
                if (commands[0] == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == element)
                        {
                            numbers.Remove(element);
                            i--;
                        }
                    }
                   
                }
                if(commands[0]=="Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]);
                    numbers.Insert(position, element);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));

        }
    }
}
