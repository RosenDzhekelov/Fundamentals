using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>(n);
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(weight, type);
                Car car = new Car(model, engine, cargo);
                cars.Add(car);

            }

            string checker = Console.ReadLine();

            if (checker == "fragile")
            {
                foreach (var car in cars.Where(x=> x.CargoProps.Type=="fragile" && x.CargoProps.Weight<1000))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(checker=="flamable")
            {
                foreach (var car in cars.Where(x=> x.CargoProps.Type=="flamable" && x.EngineProps.Power>250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    public class Car
    {
        public string Model { get; set; }

        public Engine EngineProps { get; set; }

        public Cargo CargoProps { get; set; }


        public Car(string model, Engine engine , Cargo cargo)
        {

            Model = model;
            EngineProps = engine;
            CargoProps = cargo;
        }
    }
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int speed, int power)
        {
            Speed = speed;
            Power = power;
        }
    }
    public class Cargo
    {
        public int Weight { get; set; }


        public string Type { get; set; }

        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
    }
}
