using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                TopNumber(i);
            }
        }

        static void TopNumber(int i)
        {
            int number = i;
            int sumOfDigit = 0;
            bool isOddDigit = false;
            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigit += digit;
                if (digit % 2 == 1)
                {
                    isOddDigit = true;
                }
                number /= 10;
            }
            if (sumOfDigit % 8 == 0 && isOddDigit == true)
            {
                Console.WriteLine(i);
            }
        }
    }
}
