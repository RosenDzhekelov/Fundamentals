using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.DrumSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> qualityOfDrums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> initialQuality = new List<int>(qualityOfDrums.Count);
            for (int i = 0; i < qualityOfDrums.Count; i++)
            {
                initialQuality.Add(qualityOfDrums[i]);
            }
            string command = Console.ReadLine();
            double priceOfDrum = 0;
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < qualityOfDrums.Count; i++)
                {
                    if (hitPower >= qualityOfDrums[i])
                    {
                        qualityOfDrums[i] -= hitPower;
                        priceOfDrum = initialQuality[i] * 3;
                        if (priceOfDrum <= savings)
                        {
                            savings -= priceOfDrum;
                            qualityOfDrums[i] = initialQuality[i];
                        }
                        else
                        {
                            qualityOfDrums.RemoveAt(i);
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                    else
                    {
                        qualityOfDrums[i] -= hitPower;
                    }
                   
                   
                }



                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",qualityOfDrums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");


        }
    }
}
