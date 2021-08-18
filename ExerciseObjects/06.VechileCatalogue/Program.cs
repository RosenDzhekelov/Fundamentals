using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VechileCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            List<Catalogue> catalogues = new List<Catalogue>();

            double totalHPCars = 0;
            double totalHPTrucks = 0;
            int carCount = 0;
            int truckCount = 0;
            while (firstInput != "End")
            {
                string[] splitted = firstInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string type = splitted[0].First().ToString().ToUpper() + String.Join("", splitted[0].Skip(1));
                string model = splitted[1];
                string color = splitted[2];
                int hPower = int.Parse(splitted[3]);
                Catalogue catalogue = new Catalogue(type, model, color, hPower);
                catalogues.Add(catalogue);
                if (type == "Car")
                {
                    totalHPCars += hPower;
                    carCount++;

                }
                else if (type == "Truck")
                {
                    totalHPTrucks += hPower;
                    truckCount++;
                }


                firstInput = Console.ReadLine();

            }

            string secondInput = Console.ReadLine();

            while (secondInput != "Close the Catalogue")
            {
                foreach (Catalogue catalogue in catalogues)
                {
                    if (secondInput == catalogue.Model)
                    {
                        Console.WriteLine($"Type: {catalogue.Type}");
                        Console.WriteLine($"Model: {catalogue.Model}");
                        Console.WriteLine($"Color: {catalogue.Color}");
                        Console.WriteLine($"Horsepower: {catalogue.HPower}");
                    }
                }

                secondInput = Console.ReadLine();
            }
            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {totalHPCars / carCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {totalHPCars:F2}.");
            }
            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {totalHPTrucks / truckCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {totalHPTrucks:F2}.");
            }


        }
    }




    public class Catalogue
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HPower { get; set; }

        public Catalogue(string type, string model, string color, int hPower)
        {
            Type = type;
            Model = model;
            Color = color;
            HPower = hPower;
        }
    }


}