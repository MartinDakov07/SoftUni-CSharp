using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> carsMileage = new Dictionary<string, int>();
            Dictionary<string, int> carsFuel = new Dictionary<string, int>();
            int numOfCars = int.Parse(Console.ReadLine());
            for(int i = 0; i < numOfCars; i++)
            {
                string[] car = Console.ReadLine().Split("|");
                string carName = car[0];
                int carMileage = int.Parse(car[1]);
                int carFuel = int.Parse(car[2]);  
                carsMileage[carName] = carMileage;
                carsFuel[carName] = carFuel;
            }
            string command = Console.ReadLine();
            while(command!= "Stop")
            {
                string[] commandArg = command.Split(" : ");
                string commandType = commandArg[0];
                string car = commandArg[1];
                if (commandType == "Drive")
                {
                    int distance = int.Parse(commandArg[2]);
                    int fuel = int.Parse(commandArg[3]);
                    if (carsFuel[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carsMileage[car] += distance;
                        carsFuel[car] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (carsMileage[car] >= 100000)
                    {
                        carsMileage.Remove(car);
                        carsFuel.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (commandType == "Refuel")
                {
                    int fuel = int.Parse(commandArg[2]);
                    if (carsFuel[car] + fuel > 75)
                    {
                        fuel = 75 - carsFuel[car];
                        carsFuel[car] += fuel;
                    }
                    else
                    {
                        carsFuel[car] += fuel;
                    }

                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if(commandType == "Revert")
                {
                    int kilometers = int.Parse(commandArg[2]);
                    carsMileage[car] -= kilometers;
                    if(carsMileage[car] >= 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carsMileage[car] = 10000;
                    }
                    
                }
                command = Console.ReadLine();
            }
            foreach (var(car,mileage) in carsMileage)
            {
                int fuel = carsFuel[car];
                Console.WriteLine($"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
