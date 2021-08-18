using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while(input!="end")
            {
                string[] command = input.Split(" ").ToArray();
                if(command[0]=="Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if(wagons[i]+passengers<=capacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",wagons));
        }
    }
}
