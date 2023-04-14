using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for(int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split(' ');
                string model = car[0];
                double fuelAmount = double.Parse(car[1]);
                double fuelConsumption = double.Parse(car[2]);
                Car newCar = new Car(model, fuelAmount, fuelConsumption);
                cars.Add(newCar);
            }
            string command = Console.ReadLine();
            while(command != "End")
            {
                
                string[] commandArg = command.Split(' ');
                if(commandArg[0] == "Drive")
                {
                    string model = commandArg[1];
                    int amountOfKm = int.Parse(commandArg[2]);
                    int index = cars.FindIndex(x => x.Model == model);
                    cars[index].Drive(amountOfKm);
                }
                command = Console.ReadLine();
            }
            foreach(var car in cars)
            {
                car.PrintCarStatus();
            }
        }
    }
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumption = fuelConsumption;
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public int TraveledDistance { get; set; }
        public void Drive(int amountOfDistance)
        {
            double fuelNeeded = amountOfDistance * FuelConsumption;
            if(fuelNeeded > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= fuelNeeded;
                TraveledDistance += amountOfDistance;
            }
        }
        public void PrintCarStatus()
        {
            Console.WriteLine($"{Model} {FuelAmount:f2} {TraveledDistance}");
        }
    }
}
