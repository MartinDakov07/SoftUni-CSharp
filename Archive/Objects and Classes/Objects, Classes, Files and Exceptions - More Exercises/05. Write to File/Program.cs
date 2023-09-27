using System;
using System.Linq;
using System.IO;
using System.Numerics;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _05._Write_to_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllText(@"C:\Users\User\OneDrive\Documents\sample_text.txt");
            var chars = lines.Where(c => ".,?!:".IndexOf(c) == -1).ToArray();
            File.WriteAllText(@"C:\Users\User\OneDrive\Documents\output.txt", string.Join("", chars));
            //you should paste the content of the file in judge not the solution
        }
    }
}
