using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandNumber = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>(commandNumber);
            for (int i = 0; i < commandNumber; i++)
            {
                string guests = Console.ReadLine();
                string[] input = guests.Split().ToArray();
                string names = input[0];
                if (input[2] == "going!")
                {
                    if (guestList.Contains(names))
                    {
                        Console.WriteLine($"{names} is already in the list!");
                    }
                    else if (!guestList.Contains(names))
                    {
                        guestList.Add(names);
                    }
                }
                else if (guestList.Contains(names))
                {
                    guestList.Remove(names);
                    continue;
                }
                else
                {
                    Console.WriteLine($"{names} is not in the list!");
                }
            }



            Console.WriteLine(String.Join("\n", guestList));

        }
    }
}
