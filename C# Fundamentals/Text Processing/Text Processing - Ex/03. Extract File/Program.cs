using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string file = input[input.Length - 1];
            string[] fileInfo = file.Split(".");
            string fileName = fileInfo[0];
            string fileExtension = fileInfo[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
