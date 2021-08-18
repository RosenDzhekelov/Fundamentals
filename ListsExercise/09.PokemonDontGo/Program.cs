using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            int sum = 0;
            while (distanceToPokemon.Count>0)
            {
                int index = int.Parse(Console.ReadLine());
                int valueHolder = 0;
                
                if(index<0)
                {
                    index = 0;
                     valueHolder = distanceToPokemon[index];
                    distanceToPokemon.RemoveAt(index);
                    sum += valueHolder;
                    distanceToPokemon.Insert(index, distanceToPokemon[distanceToPokemon.Count - 1]);
                    distanceToPokemon = DistanceDistribution(distanceToPokemon, index, valueHolder);
                }
               else  if(index>=distanceToPokemon.Count)
                {
                    index = distanceToPokemon.Count - 1;
                    valueHolder = distanceToPokemon[index];
                    distanceToPokemon.RemoveAt(index);
                    sum += valueHolder;
                    distanceToPokemon.Insert(index, distanceToPokemon[0]);
                    distanceToPokemon = DistanceDistribution(distanceToPokemon, index, valueHolder);
                }
                else
                {
                    valueHolder = distanceToPokemon[index];
                    distanceToPokemon.RemoveAt(index);
                    sum += valueHolder;
                    distanceToPokemon = DistanceDistribution(distanceToPokemon, index, valueHolder);
                }

                


            }
            Console.WriteLine(sum);
        }

        static List<int> DistanceDistribution(List<int> distanceToPokemon , int index , int valueHolder)
        {

            for (int i = 0; i < distanceToPokemon.Count; i++)
            {
                if (distanceToPokemon[i] <= valueHolder)
                {
                    distanceToPokemon[i] += valueHolder;
                }
                else
                {
                    distanceToPokemon[i] -= valueHolder;
                }
            }
            return distanceToPokemon;
        }
    }
}
