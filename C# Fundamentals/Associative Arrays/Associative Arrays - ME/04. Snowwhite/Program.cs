using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
namespace _04._Snowwhite
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Dictionary<(string,string), int> dwarfs = new Dictionary<(string,string), int>(); 
           
            string command = Console.ReadLine();
            while(command != "Once upon a time")
            {
                string[] dwarfArg = command.Split(" <:> ").ToArray();
                string dwarfName = dwarfArg[0];
                string dwarfColor = dwarfArg[1];
                int dwarfPhy = int.Parse(dwarfArg[2]);
                (string,string) dwarfsKey = (dwarfName,dwarfColor); 
                GetDwarfs(dwarfs,dwarfsKey,dwarfPhy);
                command = Console.ReadLine();
            }
            PrintResult(dwarfs);
        }
        static void GetDwarfs(Dictionary<(string, string), int> dwarfs, (string, string) dwarfsKey, int physic)
        {
            if(!dwarfs.ContainsKey(dwarfsKey) || dwarfs[dwarfsKey] < physic)
            {
                dwarfs[dwarfsKey] = physic;
            }
        }
        static void PrintResult(Dictionary<(string, string), int> dwarfs)
        {
            List<string> sortedDwarfs = dwarfs.OrderByDescending(d => d.Value)
                                          .ThenByDescending(d => dwarfs.Count(kv => kv.Key.Item2 == d.Key.Item2))
                                          .Select(d => $"({d.Key.Item2}) {d.Key.Item1} <-> {d.Value}")
                                          .ToList();
            foreach(var dwarf in sortedDwarfs)
            {
                Console.WriteLine($"{dwarf}");
            }
        }
        // static void PrintResult(Dictionary<string, Dictionary<string, int>> dwarfs)
        // {
        //     var orderedDwarfs = dwarfs
        //         .SelectMany(d => d.Value.Select(c => new { DwarfName = d.Key, HatColor = c.Key, Physics = c.Value }))
        //         .OrderByDescending(d => d.Physics)
        //         .ThenByDescending(d => dwarfs.Count(e => e.Value.ContainsKey(d.HatColor)))
        //         .ToList();
        //
        //     foreach (var dwarf in orderedDwarfs)
        //     {
        //         Console.WriteLine($"({dwarf.HatColor}) {dwarf.DwarfName} <-> {dwarf.Physics}");
        //     }
        // }
        //

    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//
//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<(string, string), int> dwarfs = new Dictionary<(string, string), int>();
//
//        while (true)
//        {
//            string inputStr = Console.ReadLine().Trim();
//            if (inputStr == "Once upon a time")
//            {
//                break;
//            }
//            string[] inputParts = inputStr.Split(" <:> ");
//            string dwarfName = inputParts[0];
//            string dwarfColor = inputParts[1];
//            int dwarfPhysics = int.Parse(inputParts[2]);
//
//            (string, string) dwarfKey = (dwarfName, dwarfColor);
//            if (!dwarfs.ContainsKey(dwarfKey) || dwarfs[dwarfKey] < dwarfPhysics)
//            {
//                dwarfs[dwarfKey] = dwarfPhysics;
//            }
//        }
//
//        List<string> sortedDwarfs = dwarfs.OrderByDescending(d => d.Value)
//                                          .ThenByDescending(d => dwarfs.Count(kv => kv.Key.Item2 == d.Key.Item2))
//                                          .Select(d => $"({d.Key.Item2}) {d.Key.Item1} <-> {d.Value}")
//                                          .ToList();
//
//        foreach (string dwarf in sortedDwarfs)
//        {
//            Console.WriteLine(dwarf);
//        }
//    }
//}
