using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();
            string input = Console.ReadLine();
            while(input!="buy")
            {
                List<string> list = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                string key = list[0];
                double price = double.Parse(list[1]);
                int quantity = int.Parse(list[2]);
            
                if(products.ContainsKey(key))
                {
                    products[key].RemoveAt(0);
                    products[key].Add(quantity);
                    products[key].Insert(0, price);
                }
                else
                {
                    products.Add(key, new List<double> {price , quantity});
                }



                input = Console.ReadLine();
            }
            double sum = 0;
            foreach (var product in products)
            {
                sum = 0;
                for (int i = 1; i < product.Value.Count; i++)
                {
                    sum += product.Value[i];
                }
                Console.WriteLine($"{product.Key} -> {sum*product.Value[0]:F2}");
            }
        }
    }
}
