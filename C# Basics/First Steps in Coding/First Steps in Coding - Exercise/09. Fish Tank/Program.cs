using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Size of the fish tank
            double aquariumLenght = double.Parse(Console.ReadLine());
            double aquariumWidht = double.Parse(Console.ReadLine());
            double aquariumHeight = double.Parse(Console.ReadLine());
            // Percent used for accesories
            double percent = double.Parse(Console.ReadLine())/100;
            // Finding the volume of the paralelepiped
            double volumeOfTheAquarium = aquariumLenght * aquariumWidht * aquariumHeight;
            // Finding the volume in litters
            double volumeInLitters = volumeOfTheAquarium * 0.001;
            // Finding the amount of water we need for fulling the aquarium
            double litters = volumeInLitters * (1 - percent);
            // Print the result from the console
            Console.WriteLine(litters);
            
        }
    }
}
