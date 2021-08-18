using System;

namespace _05.Order
{
    class Program
    {
        static void Main(string[] args)
        {
            //    coffee – 1.50
            //water – 1.00
            //coke – 1.40
            // snacks – 2.00
            string order = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalPrice(order, quantity);
        }

        static void TotalPrice(string order , int quantity)
        {
            decimal totPrice = 0;
            if(order=="coffee")
            {
                totPrice = (decimal)1.5 * quantity;
                Console.WriteLine($"{totPrice:F2}");
            }
            else if (order == "water")
            {
                totPrice = (decimal)1 * quantity;
                Console.WriteLine($"{totPrice:F2}");
            }
            else if (order == "coke")
            {
                totPrice = (decimal)1.4 * quantity;
                Console.WriteLine($"{totPrice:F2}");
            }
            else if (order == "snacks")
            {
                totPrice = (decimal)2 * quantity;
                Console.WriteLine($"{totPrice:F2}");
            }
        }
    }
}
