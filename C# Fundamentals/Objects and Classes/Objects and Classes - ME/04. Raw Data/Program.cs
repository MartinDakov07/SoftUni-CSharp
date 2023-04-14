using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Car newCar = new Car(Console.ReadLine().Split());
                cars.Add(newCar);
            }
            string command = Console.ReadLine();
            if(command == "fragile")
            {
                Car[] selectedCars = cars.FindAll(x => x.Cargo.CargoWeight < 1000).ToArray();
                Console.WriteLine(String.Join(Environment.NewLine, selectedCars.Select(x => x.Model)));
            }
            else if(command == "flamable")
            {
                Car[] selectedCars = cars.FindAll(x => x.Engine.EnginePower > 250).ToArray();
                Console.WriteLine(String.Join(Environment.NewLine, selectedCars.Select(x => x.Model)));
            }
        }
        public class Car         
        { 
            public string Model { get; set; }
            
            public Engine Engine { get; set; }
            public Cargo Cargo { get; set; }
            public Car(string[] carData)
            {
                Model = carData[0];
                Engine = new Engine(int.Parse(carData[1]),int.Parse(carData[2]));
                Cargo = new Cargo(int.Parse(carData[3]), carData[4]);
            }
        }
        public class Engine
        {
            public Engine(int engineSpeed, int enginePower)
            {
                EngineSpeed = engineSpeed;
                EnginePower = enginePower;
            }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
            
        }
        public class Cargo
        {
            public Cargo(int cargoWeight, string cargoType)
            {
                CargoWeight = cargoWeight;
                CargoType = cargoType;
            }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }
        }

    }
}
