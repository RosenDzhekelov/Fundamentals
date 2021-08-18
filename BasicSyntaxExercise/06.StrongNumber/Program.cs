using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double convert = 0;
            int sum = 0;
            while (true)
            {
                string money = Console.ReadLine();
                if (money == "Start")
                {
                    break;
                }
                if (double.Parse(money) == 0.1 || double.Parse(money) == 0.2 || double.Parse(money) == 0.5 || double.Parse(money) == 0.5 || double.Parse(money) == 1 || double.Parse(money) == 2)
                {
                    convert = double.Parse(money) * 100;
                    sum += (int)convert;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
            }
            while (true)
            {
               
                string command = Console.ReadLine();
                if (command == "End")
                {
                    
                        convert = (double)sum / 100;
                        Console.WriteLine($"Change: {convert:f2}");
                    
                    break;
                }
                else if (command == "Nuts")
                {
                    if (sum >= 200)
                    {
                        sum -= 200;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Water")
                {
                    if (sum >= 70)
                    {
                        sum -=70;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Crisps")
                {
                    if (sum >= 150)
                    {
                        sum -= 150;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Soda")
                {
                    if (sum >= 80)
                    {
                        sum -= 80;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command == "Coke")
                {
                    if (sum >= 100)
                    {
                        sum -= 100;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

            }
        }
    }
}
