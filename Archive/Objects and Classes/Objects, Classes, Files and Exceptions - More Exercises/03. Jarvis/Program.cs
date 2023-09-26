using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace _03._Jarvis
{
    internal class Program
    {
        class Head
        {
            public int Energy { get; set; }
            public int IQ { get; set; }

            public string Material { get; set; }

            public Head(int energy,int iq,string material)
            {
                Energy = energy;
                IQ = iq;
                Material = material;
            }
        }
        class Torso
        {
            public int Energy { get; set; }
            public double Size { get; set; }
            public string Material { get; set;}
            public Torso(int energy,double size,string material)
            {
                Energy = energy;
                Size = size;
                Material = material;
            }
        }
        class Arm
        {
            public int Energy { get; set; }
            public int Distance { get; set; }
            public int Fingers { get; set; }

            public Arm(int energy,int distance,int fingers)
            {
                Energy = energy;
                Distance = distance;
                Fingers = fingers;
            }
        }
        class Leg
        {
            public int Energy { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }
            public Leg(int energy,int strength,int speed)
            {
                Energy = energy;
                Strength = strength;
                Speed = speed;
            }
        }
        static void Main(string[] args)
        {
            List<Head> head = new List<Head>();
            List<Torso> torso = new List<Torso>();
            List<Arm> arms = new List<Arm>();
            List<Leg> legs = new List<Leg>();
            long jarvinEng = long.Parse(Console.ReadLine());
            string components = Console.ReadLine();            
            while(components != "Assemble!")
            {
                string[] componentArg = components.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string part = componentArg[0];
                int energy = int.Parse(componentArg[1]);
                if (part == "Head")
                {
                    int iq = int.Parse(componentArg[2]);
                    string material = componentArg[3];
                    Head currHead = new Head(energy, iq, material);
                    head.Add(currHead);
                }
                else if (part == "Torso")
                {
                    int size = int.Parse(componentArg[2]);
                    string material = componentArg[3];
                    Torso currTorso = new Torso(energy, size, material);
                    torso.Add(currTorso);
                    
                }
                else if (part == "Arm")
                {
                    int distance = int.Parse(componentArg[2]);
                    int fingers = int.Parse(componentArg[3]);
                    Arm arm = new Arm(energy, distance, fingers);
                    arms.Add(arm);
                    
                }
                else if (part == "Leg")
                {
                    int strength = int.Parse(componentArg[2]);
                    int speed = int.Parse(componentArg[3]);
                    Leg leg = new Leg(energy, strength, speed);
                    legs.Add(leg);
                }              
                components = Console.ReadLine();
            }
            long totalEnergy = 0;
            
           if(arms.Count > 1 && legs.Count > 1 && torso.Count > 0 && head.Count > 0)
           {
                totalEnergy = arms.OrderBy(x => x.Energy).First().Energy +
                arms.OrderBy(x => x.Energy).Skip(1).Take(1).First().Energy +
                legs.OrderBy(x => x.Energy).First().Energy +
                legs.OrderBy(x => x.Energy).Skip(1).Take(1).First().Energy +
                head.OrderBy(x => x.Energy).First().Energy +
                torso.OrderBy(x => x.Energy).First().Energy;
                if(totalEnergy > jarvinEng)
                {
                    Console.WriteLine("We need more power!");
                }
                else
                {
                    Console.WriteLine("Jarvis:");
                    foreach(var headarg in head.OrderBy(h=>h.Energy).Take(1))
                    {
                        Console.WriteLine($"#Head:");
                        Console.WriteLine($"###Energy consumption: {headarg.Energy}");
                        Console.WriteLine($"###IQ: {headarg.IQ}");
                        Console.WriteLine($"###Skin material: {headarg.Material}");
                    }
                    foreach(var torsoarg in torso.OrderBy(t => t.Energy).Take(1))
                    {
                        Console.WriteLine("#Torso:");
                        Console.WriteLine($"###Energy consumption: {torsoarg.Energy}");
                        Console.WriteLine($"###Processor size: {torsoarg.Size:f1}");
                        Console.WriteLine($"###Corpus material: {torsoarg.Material}");
                    }
                    
                    foreach (var arm in arms.OrderBy(a => a.Energy).Take(2))
                    {
                        Console.WriteLine($"#Arm:");
                        Console.WriteLine($"###Energy consumption: {arm.Energy}");
                        Console.WriteLine($"###Reach: {arm.Distance}");
                        Console.WriteLine($"###Fingers: {arm.Fingers}");
                    }
                    foreach (var leg in legs.OrderBy(l => l.Energy).Take(2))
                    {
                        Console.WriteLine($"#Leg:");
                        Console.WriteLine($"###Energy consumption: {leg.Energy}");
                        Console.WriteLine($"###Strength: {leg.Strength}");
                        Console.WriteLine($"###Speed: {leg.Speed}");
                    }
                }
           }
           else
           {
               Console.WriteLine("We need more parts!");
           }
               
            
           
            
            
        }
    }
}
