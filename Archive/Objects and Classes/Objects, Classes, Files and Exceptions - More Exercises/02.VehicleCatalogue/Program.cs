using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using System.Text;
namespace _02._Vehicle_Catalogue
{
    internal class Program
    {
        class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
        }
        class Truck
        {            
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
        }
        static void Main(string[] args)
        {
            //i know i could use single class (Vehicle), but just for practise
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string command = Console.ReadLine();
            while(command != "End")
            {
                string[] commandArg = command.Split();
                string type = commandArg[0];
                string model = commandArg[1];
                string color = commandArg[2];
                double horsePower = double.Parse(commandArg[3]);
                if(type.ToLower() == "car")
                {
                    Car car = new Car() { Type = "Car",Model = model, Color = color, Horsepower = horsePower };
                    cars.Add(car);
                }
                else if(type.ToLower() == "truck")
                {
                    Truck truck = new Truck() { Type = "Truck", Model = model, Color = color, Horsepower = horsePower };
                    trucks.Add(truck);
                }
                command = Console.ReadLine();
            }
            string modelsForPrint = Console.ReadLine();
            while(modelsForPrint != "Close the Catalogue")
            {
                foreach(var car in cars)
                {
                    if(car.Model == modelsForPrint)
                    {
                        PrintCarInfo(car);
                    }
                }
                foreach (var truck in trucks)
                {
                    if (truck.Model == modelsForPrint)
                    {
                        PrintTruckInfo(truck);
                    }
                }
                modelsForPrint = Console.ReadLine();
            }
            if(cars.Count == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {(cars.Sum(c=>c.Horsepower)/cars.Count):f2}.");
            }
            if(trucks.Count == 0)
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {(trucks.Sum(c => c.Horsepower) / trucks.Count):f2}.");
            }
        }
        static void PrintCarInfo(Car car) 
        {
            Console.WriteLine($"Type: {car.Type}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Color: {car.Color}");
            Console.WriteLine($"Horsepower: {car.Horsepower}");
        }
        static void PrintTruckInfo(Truck truck)
        {
            Console.WriteLine($"Type: {truck.Type}");
            Console.WriteLine($"Model: {truck.Model}");
            Console.WriteLine($"Color: {truck.Color}");
            Console.WriteLine($"Horsepower: {truck.Horsepower}");
        }
    }
}
