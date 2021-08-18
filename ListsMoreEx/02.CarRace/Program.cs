using System;
using System.Collections.Generic;
using System.Linq;

namespace Car_Race
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();
			int midIndex = (list.Count / 2);
			double firstSpeed = 0;
			double secondSpeed = 0;

			for (int i = 0; i < midIndex; i++)
			{
				firstSpeed += list[i];
				secondSpeed += list[list.Count - 1 - i];
				if (list[i] == 0)
				{
					firstSpeed *= .8;
				}
				if (list[list.Count - 1 - i] == 0)
				{
					secondSpeed *= .8;
				}
			}
			if (firstSpeed <= secondSpeed)
			{
				Console.WriteLine($"The winner is left with total time: {firstSpeed}");
			}
			else
			{
				Console.WriteLine($"The winner is right with total time: {secondSpeed}");
			}

		}
	}
}