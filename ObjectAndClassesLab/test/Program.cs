using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();
            Catalogue catalog = new Catalogue();
            
            

            while(input!="end")
            {
                string[] inputArgs = input
                     .Split("/", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                string brand = inputArgs[1];
                string model = inputArgs[2];
                
                if(inputArgs[0]=="Car")
                {
                    int horsePower = int.Parse(inputArgs[3]);
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    catalog.Cars.Add(car);
                }
                else if(inputArgs[0]=="Truck")
                {
                    int weight = int.Parse(inputArgs[3]);
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    catalog.Trucks.Add(truck);
                }





                input = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var item in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var item in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }


    public class Car
    {

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Truck
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }


    public class Catalogue
    {
        

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalogue()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

    }
}
