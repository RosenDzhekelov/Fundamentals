using System;

namespace _10.MultiplySumOfEvenBySumOfOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sumOfEven = 0;
            int sumOfOdd = 0;
            if (input < 0)
            {
                input *= (-1);
            }
            while (input > 0)
            {
                int digit = input % 10;

                if (digit % 2 == 0)
                {
                    sumOfEven += SumOfEven(digit);
                }
                else if (digit % 2 == 1)
                {
                    sumOfOdd += SumOfOdd(digit);
                }
                input /= 10;
            }
            Console.WriteLine(MultiplicationOfSums(sumOfEven, sumOfOdd));
        }


        static int SumOfEven(int digit)
        {
            int sum = 0;
            sum = digit;
            return sum;
        }
        static int SumOfOdd(int digit)
        {

            int sum = 0;
            sum += digit;
            return sum;

        }
        static int MultiplicationOfSums(int sumOfEven, int sumOfOdd)
        {
            int result = 0;
            result = sumOfEven * sumOfOdd;
            return result;
        }

    }
}
