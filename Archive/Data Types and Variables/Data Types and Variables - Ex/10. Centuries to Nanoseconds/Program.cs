using System;
using System.Linq;
using System.Numerics;

namespace _10._Centuries_to_Nanoseconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            long days = (long)(years * 365.2422);
            BigInteger hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger millieseconds = seconds * 1000;
            BigInteger microseconds = millieseconds * 1000;
            BigInteger nanosecond = microseconds * 1000;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {millieseconds} milliseconds = {microseconds} microseconds = {nanosecond} nanoseconds");
        }
    }
}
