using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse).ToList();
            int[] numAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int specialNumber = numAndPower[0];
            int power = numAndPower[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {

                    for (int j = 0; j < power; j++)
                    {
                        if (i + 1 < numbers.Count)
                        {
                            numbers.RemoveAt(i + 1);
                        }
                    }
                    for (int index = 0; index < power; index++)
                    {
                        if (i - 1 - index >= 0)
                        {
                            numbers.RemoveAt(i - 1 - index);
                        }
                    }
                    numbers.Remove(specialNumber);
                    i--;
                }

            }
       
           
            Console.WriteLine(numbers.Sum());
        }
    }
}