using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsMoreEx
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string message = "";

            List<char> input = Console.ReadLine().ToList();
            int sum = 0;
            int number = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                number = numbers[i];
                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }
                if (sum >= input.Count)
                {
                    int counter = 0;
                    for (int index = 0; index <= sum; index++)
                    {
                       
                        if (index == input.Count)
                        {
                            index = 0;
                        }
                        if (counter == sum)
                        {
                            message += input[index].ToString();
                            input.RemoveAt(index);
                            break;
                        }
                        counter++;
                    }
                }
                else
                {
                    for (int j = 0; j < input.Count; j++)
                    {
                        if(j==sum)
                        {
                            message+=input[j].ToString();
                                input.RemoveAt(j);
                        }
                    }
                }
                sum = 0;
            }
            Console.WriteLine(message);
        }
    }
}
