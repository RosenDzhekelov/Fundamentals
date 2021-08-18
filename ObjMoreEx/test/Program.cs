using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OldestFamMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            List<Car> cars = new List<Car>(n);
            for (int i = 0; i < n; i++)
            {
                //input AudiA4 23 0.3

                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] splitter = command.
                    Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = splitter[1];
                int distance = int.Parse(splitter[2]);
                Car car = new Car();
                bool canTravel = car.CanTravel(cars, model, distance);
                if (canTravel)
                {
                    foreach (var item in cars)
                    {
                        if (model == item.Model)
                        {
                            if (item.Fuel >= item.Consumption * distance)
                            {
                                int index = cars.FindIndex(x => x.Model == model);
                                cars[index].TravelDistance += distance;
                                cars[index].Fuel -= item.Consumption * distance;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Insufficient fuel for the drive");
                }
                        
                   
                



                command = Console.ReadLine();
            }


            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.TravelDistance}");
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }

        public double Fuel { get; set; }

        public double Consumption { get; set; }
        public int TravelDistance { get; set; }

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            Consumption = consumption;
        }
        public Car()
        {

        }

        public bool CanTravel(List<Car> cars, string model, int distance)
        {
            bool canTravel = false;
            foreach (var car in cars)
            {
                if (model == car.Model)
                {
                    if (car.Fuel >= car.Consumption * distance)
                    {
                        canTravel = true;
                        
                    }
                }
            }
            return canTravel;

        }
    }
}
