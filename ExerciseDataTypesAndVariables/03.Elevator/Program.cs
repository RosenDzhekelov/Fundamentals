using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCap = int.Parse(Console.ReadLine());
            int counter = 0;
            if(peopleCount%elevatorCap==0)
            {
                counter = peopleCount / elevatorCap;
                Console.WriteLine(counter);
            }
            else
            {
                counter = (peopleCount / elevatorCap) + 1;
                Console.WriteLine(counter);
            }
        }
    }
}
