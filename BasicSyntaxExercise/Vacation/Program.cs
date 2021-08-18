using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double price = 0;
            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45 * peopleCount;

                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80 * peopleCount;
                }
                else
                {
                    price = 10.46 * peopleCount;
                }
                if (peopleCount >= 30)
                {
                    price -= price * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90 * peopleCount;
                    if (peopleCount >= 100)
                    {
                        price -= 10 * 10.90;
                    }

                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.6 * peopleCount;
                    if (peopleCount >= 100)
                    {
                        price -= 10 * 15.6;
                    }
                }
                else
                {
                    price = 16 * peopleCount;
                    if (peopleCount >= 100)
                    {
                        price -= 10 * 16;
                    }
                }
                
            }
            else
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15 * peopleCount;

                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20 * peopleCount;
                }
                else
                {
                    price = 22.50 * peopleCount;
                }
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
