using System;
using System.Linq;

namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long sum = 0;
                string[] numbers = (Console.ReadLine()).Split(" ").ToArray();
                if (long.Parse(numbers[0]) < 0 && long.Parse(numbers[1]) < 0)
                {

                    if (long.Parse(numbers[0]) > long.Parse(numbers[1]))
                    {
                        long number = long.Parse(numbers[0]) * (-1);
                        while (number > 0)
                        {
                            sum += number % 10;
                            number /= 10;
                        }
                    }
                    else
                    {
                        long number = long.Parse(numbers[1]) * (-1);
                        while (number > 0)
                        {
                            sum += number % 10;
                            number /= 10;
                        }
                    }
                }
                else
                {
                    if (long.Parse(numbers[0]) > long.Parse(numbers[1]))
                    {
                        long number = long.Parse(numbers[0]);
                        while (number > 0)
                        {
                            sum += number % 10;
                            number /= 10;
                        }
                    }
                    else
                    {
                        long number = long.Parse(numbers[1]);
                        while (number > 0)
                        {
                            sum += number % 10;
                            number /= 10;
                        }
                    }
                }
                    Console.WriteLine(sum);
                
            }
        }
    }
}
