using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace _7._Vehicle_Catalog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split('/');

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];

                if (type == "Truck")
                {
                    double kilo = double.Parse(cmdArgs[3]);

                    
                    Truck truck = new Truck(brand, model, kilo);
                    catalog.Trucks.Add(truck);
                }
                else if (type == "Car")
                {
                    double horsePower = double.Parse(cmdArgs[3]);

                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }


            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            
            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }
            
            foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }

        }

        public class Truck
        {
            public Truck(string brand, string model, double weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public double Weight { get; set; }
        }

        public class Car
        {
            public Car(string brand, string model, double horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }

            public string Model { get; set; }

            public double HorsePower { get; set; }
        }

        public class Catalog
        {
            public Catalog()
            {
                Trucks = new List<Truck>();
                Cars = new List<Car>();
            }

            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
        }
    }
}