using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
namespace _01._Sort_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split().OrderBy(t=>t).ToList();          
            Console.WriteLine(string.Join(", ",times));
        }
    }
}
