using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog catalog = new Catalog();
            while(input != "end")
            {
                string[] vehicleInfo = input.Split("/");
                string vehicleType = vehicleInfo[0];
                string vehicleBrand = vehicleInfo[1];
                string vehicleModel = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);
                if(vehicleType == "Car")
                {
                    Cars car = new Cars(vehicleBrand,vehicleModel, value);
                   catalog.Cars.Add(car);
                }
                else if(vehicleType == "Truck")
                {
                    Trucks truck = new Trucks(vehicleBrand,vehicleModel, value);
                    catalog.Trucks.Add(truck);
                }
                input = Console.ReadLine();
            }
            if(catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            
            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
            {
                
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");

            }
            if(catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }            
            foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Cars
    {
        public Cars(string brand, string model,int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Trucks
    {
        public Trucks(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Cars>();
            Trucks = new List<Trucks>();
        }

       public List<Cars> Cars { get; set; }
       public List<Trucks> Trucks { get; set; }
    }
}
