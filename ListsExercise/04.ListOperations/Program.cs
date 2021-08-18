using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while(input!="End")
            {
                string[] commands = input.Split().ToArray();
                if(commands[0]=="Add")
                {
                    numbers.Add(int.Parse(commands[1]));
                }
                else if(commands[0]=="Insert")
                {
                    int index = int.Parse(commands[2]);
                    if (index >= numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int num = int.Parse(commands[1]);
                        numbers.Insert(index, num);
                    }
                }
                else if(commands[0]=="Remove")
                {
                    int index = int.Parse(commands[1]);
                    if (index >= numbers.Count || index<0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if(commands[0]=="Shift")
                {
                    string direction = commands[1];
                    int count = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (direction == "right")
                    {
                        
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0,numbers[numbers.Count-1]);
                            numbers.RemoveAt(numbers.Count-1);
                        }
                        
                    }
                }



                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
     


          
        
    }
}
