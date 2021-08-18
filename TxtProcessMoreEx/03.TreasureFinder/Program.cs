using System;
using System.Linq;
using System.Text;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
           
            string input = Console.ReadLine();
            while(input!="find")
            {
                StringBuilder newInput = new StringBuilder();
                StringBuilder treasure = new StringBuilder();
                StringBuilder coordinates = new StringBuilder();
                bool isTreasureFound = false;
                bool isCoordinatesFound = false;
                int index = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (index == key.Length)
                    {
                        index = 0;
                    }
                        char character = (char)(input[i] - key[index]);
                    index++;
                    newInput.Append(character);
                    
                }
                for (int i = 0; i < newInput.Length; i++)
                {
                    if(newInput[i]=='&')
                    {
                        int j = i + 1;
                        while(newInput[j]!='&')
                        {
                            treasure.Append(newInput[j]);
                            j++;
                        }
                        i = j;
                        isTreasureFound = true;
                    }
                    else if(newInput[i]=='<')
                    {
                        int j = i + 1;
                        while (newInput[j] != '>')
                        {
                            coordinates.Append(newInput[j]);
                            j++;
                        }
                        i = j;
                        isCoordinatesFound = true;
                    }
                    if(isCoordinatesFound&&isTreasureFound)
                    {
                        Console.WriteLine($"Found {treasure} at {coordinates}");
                        break;
                    }
                }

                input = Console.ReadLine();
            }

        }
    }
}
