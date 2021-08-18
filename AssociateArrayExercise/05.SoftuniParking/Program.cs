using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                List<string> parkingUser = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = parkingUser[0];
                string name = parkingUser[1];
               
                if(command=="register")
                {
                    string licensePlate = parkingUser[2];
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.Write($"ERROR: already registered with plate number ");
                        foreach (var user in users.Where(user => user.Key == name))
                        {
                            Console.Write(user.Value);
                        }
                        Console.WriteLine();

                    }
                            
                }
                else if(command=="unregister")
                {
                    if(!users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        users.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }


            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
