using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spiceTotal = 0;
            int daysCounter = 0;
            while(startingYield>=100)
            {
                spiceTotal += startingYield;
                if (spiceTotal >= 26)
                {
                    spiceTotal -= 26;
                }
                else
                {
                    spiceTotal = 0;
                }
                startingYield -= 10;
                daysCounter++;
            }
            if (spiceTotal >= 26)
            {
                spiceTotal -= 26;
            }
            else
            {
                spiceTotal = 0;
            }


            Console.WriteLine($"{daysCounter}");
            Console.WriteLine(spiceTotal);
        }
    }
}
