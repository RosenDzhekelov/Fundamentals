using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
             .Split(" ",StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse).ToList();
            bool isChanged = false;
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                if(command[0]=="Contains")
                {
                    if(numbers.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }   
                }
                else if(command[0]=="PrintEven")
                {
                    foreach(int number in numbers)
                    {
                        if(number%2==0)
                        {
                            Console.Write(number+" ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 1)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if(command[0]=="Filter")
                {
                    if (command[1] == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(command[2]))));
                    }
                    else if(command[1]=="<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(command[2]))));
                    }
                    else if(command[1]==">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(command[2]))));
                    }
                    else if(command[1]=="<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(command[2]))));
                    }
                      
                }
                
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "RemoveAt")
                {
                    numbers.RemoveAt(int.Parse(command[1]));
                    isChanged = true;
                }
                else if (command[0] == "Insert")
                {
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                    isChanged = true;
                }



                input = Console.ReadLine();
            }
            if(isChanged)
            {
                Console.WriteLine(string.Join(" ",numbers));
            }
        }
    }
}
