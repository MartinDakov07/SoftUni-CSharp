using System;
using System.Collections.Generic;
using System.Linq;
namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        string[] data = Console.ReadLine().Split();
            //        List<Vehicle> vehicles = new List<Vehicle>();
            //
            //        int cars = 0;
            //        int trucks = 0;
            //        
            //        while (data[0] != "End")
            //        {
            //            
            //            Vehicle vehicle = new Vehicle(data[0], data[1], data[2], int.Parse(data[3]));
            //            if (data[0] == "car")
            //            {
            //                vehicle.Type = "Cars";
            //                vehicles.Add(vehicle);
            //                cars++;
            //            }
            //            else if(data[0] == "truck")
            //            {
            //                vehicle.Type = "Truck";
            //                vehicles.Add(vehicle);
            //                trucks++;
            //            }
            //
            //            data = Console.ReadLine().Split();
            //        }
            //        
            //        foreach (var ct in vehicles)
            //        {
            //            foreach (Cars car in cars.Where(c => c.Model == ct))
            //            {
            //                Console.WriteLine($"Type: Car");
            //                Console.WriteLine($"Model: {car.Model}");
            //                Console.WriteLine($"Color: {car.Color}");
            //                Console.WriteLine($"Horsepower: {car.HorsePower}");
            //            }
            //            foreach (Trucks truck in trucks.Where(t => t.Model == ct))
            //            {
            //                Console.WriteLine($"Type: Truck");
            //                Console.WriteLine($"Model: {truck.Model}");
            //                Console.WriteLine($"Color: {truck.Color}");
            //                Console.WriteLine($"Horsepower: {truck.HorsePower}");
            //            }
            //        }
            //        double averageCarPower = carPower / carsCount;
            //        double averageTruckPower = truckPower / trucksCount;
            //        Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");
            //        Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");
            //        
            //    }
            //}
            //static void GetInfo(List<Vehicle> vehicles)
            //{
            //    string infoAbout = Console.ReadLine();
            //
            //    while (infoAbout != "Close the Catalogue")
            //    {
            //        int indexOfVehicle = 0;
            //
            //        for (int i = 0; i < vehicles.Count; i++)
            //        {
            //            if (vehicles[i].Model == infoAbout)
            //                indexOfVehicle = i;
            //            Console.WriteLine($"Type: {vehicles[indexOfVehicle].Type}");
            //            Console.WriteLine($"Model: {vehicles[indexOfVehicle].Model}");
            //            Console.WriteLine($"Color: {vehicles[indexOfVehicle].Color}");
            //            Console.WriteLine($"Horsepower: {vehicles[indexOfVehicle].HorsePower}");
            //            break;
            //        }                      
            //        infoAbout = Console.ReadLine();
            //    }
            //}
            //static void GetAndPrintHorsePower(List<Vehicle> vehicles, int cars, int trucks)
            //{
            //    double averageCarsHp = 0;
            //    double averageTrucksHp = 0;
            //
            //    for (int i = 0; i < vehicles.Count; i++)
            //    {
            //        if (vehicles[i].Type == "Car")
            //            averageCarsHp += ((double)vehicles[i].HorsePower) / cars;
            //
            //        else
            //            averageTrucksHp += ((double)vehicles[i].HorsePower) / trucks;
            //    }
            //
            //    if (cars == 0)
            //        averageCarsHp = 0.00; //otherwise will be NaN 
            //    if (trucks == 0)
            //        averageTrucksHp = 0.00; //otherwise will be NaN 
            //
            //    Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");
            //    Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:f2}.");
            //}
            //
            //
            //
            //
            //
            //public class Vehicle
            //{
            //    public Vehicle(string type, string model, string color, int horsePower)
            //    {
            //        this.Type = type;
            //        this.Model = model;
            //        this.Color = color;
            //        this.HorsePower = horsePower;
            //    }
            //    public string Type { get; set; }
            //    public string Model { get; set; }
            //    public string Color { get; set; }
            //    public double HorsePower { get; set; }
            //}
            string[] data = Console.ReadLine().Split(); //type + model + color + horsepower 

            List<Vehicle> vehicles = new List<Vehicle>();

            int cars = 0;
            int trucks = 0;

            while (data[0] != "End")
            {
                Vehicle vehicle = new Vehicle(data[0], data[1], data[2], int.Parse(data[3]));

                switch (data[0])
                {
                    case "car":
                        vehicle.Type = "Car"; //in output it's "Car" 
                        vehicles.Add(vehicle);
                        cars++;
                        break;

                    case "truck":
                        vehicle.Type = "Truck"; //in output it's "Truck" 
                        vehicles.Add(vehicle);
                        trucks++;
                        break;

                }

                data = Console.ReadLine().Split();
            }

            GetInfo(vehicles);
            GetAndPrintHorsePower(vehicles, cars, trucks);
        }

        static void GetInfo(List<Vehicle> vehicles)
        {
            string infoAbout = Console.ReadLine();

            while (infoAbout != "Close the Catalogue")
            {
                int indexOfVehicle = 0;

                for (int i = 0; i < vehicles.Count; i++)
                    if (vehicles[i].Model == infoAbout)
                        indexOfVehicle = i;

                PrintVehicleInfo(vehicles, indexOfVehicle);

                infoAbout = Console.ReadLine();
            }
        }

        static void PrintVehicleInfo(List<Vehicle> vehicles, int index)
        {
            Console.WriteLine($"Type: {vehicles[index].Type}");
            Console.WriteLine($"Model: {vehicles[index].Model}");
            Console.WriteLine($"Color: {vehicles[index].Color}");
            Console.WriteLine($"Horsepower: {vehicles[index].Horsepower}");
        }

        static void GetAndPrintHorsePower(List<Vehicle> vehicles, int cars, int trucks)
        {
            double averageCarsHp = 0;
            double averageTrucksHp = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Type == "Car")
                    averageCarsHp += ((double)vehicles[i].Horsepower) / cars;

                else
                    averageTrucksHp += ((double)vehicles[i].Horsepower) / trucks;
            }

            if (cars == 0)
                averageCarsHp = 0.00; //otherwise will be NaN 
            if (trucks == 0)
                averageTrucksHp = 0.00; //otherwise will be NaN 

            Console.WriteLine($"Cars have average horsepower of: {averageCarsHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHp:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }   }

