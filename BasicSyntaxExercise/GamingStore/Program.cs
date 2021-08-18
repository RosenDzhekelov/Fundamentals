using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double totalSpent = 0;
            double gamePrice = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if(balance==0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                if(command=="Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
                    break;
                }
                if(command== "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (balance >= gamePrice)
                    {
                        totalSpent += gamePrice;
                        balance -= gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                }

            }
        }
    }
}
