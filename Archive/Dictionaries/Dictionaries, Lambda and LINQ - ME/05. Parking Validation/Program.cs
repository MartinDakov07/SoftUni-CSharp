using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.IO;

namespace _05._Parking_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> licenses = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] licensePlate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = licensePlate[0];
                string name = licensePlate[1];
                bool isValid = true;
                if(type == "register")
                {
                    RegisterUser(isValid, name, licenses, licensePlate);
                }
                else if(type == "unregister")
                {
                    UnregisterUser(name, licenses);
                }
            }
            PrintRegisteredUsers(licenses);
        }
        static void RegisterUser(bool isValid,string name, Dictionary<string, string> licenses,string[] licensePlate)
        {
            string licenseNumber = licensePlate[2];
            if (licenseNumber.Length != 8)
            {
                isValid = false;                
                return;
            }
            string middlePart = licenseNumber.Substring(2, 4);
            try
            {
                int middleDigit = int.Parse(middlePart);
            }
            catch
            {
                isValid = false;
            }
            string firstPart = licenseNumber.Substring(0, 2);
            string lastPart = licenseNumber.Substring(6, 2);
            string validEnds = new string(firstPart + lastPart);
            for (int j = 0; j < validEnds.Length; j++)
            {
                if (!char.IsUpper(validEnds[j]))
                {
                    isValid = false;
                    break;
                }
            }
            if (licenses.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                
            }
            else if (!isValid)
            {
                Console.WriteLine($"ERROR: invalid license plate {licenseNumber}");
            }
            else if (licenses.ContainsValue(licenseNumber))
            {
                Console.WriteLine($"ERROR: license plate {licenseNumber} is busy");                
            }
            else 
            {
                licenses.Add(name, licenseNumber);
                Console.WriteLine($"{name} registered {licenseNumber} successfully");                
            }            
        }
        static void UnregisterUser(string name,Dictionary<string,string> licenses)
        {
            if (!licenses.ContainsKey(name))
            {
                Console.WriteLine($"ERROR: user {name} not found");
            }
            else
            {
                Console.WriteLine($"user {name} unregistered successfully");
                licenses.Remove(name);
            }
        }
        static void PrintRegisteredUsers(Dictionary<string,string> licenses)
        {
            foreach(var license in licenses)
            {
                Console.WriteLine($"{license.Key} => {license.Value}");
            }
        }
    }
}
