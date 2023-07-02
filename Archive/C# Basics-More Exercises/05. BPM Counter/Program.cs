using System;

namespace _05._BPM_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bpm = int.Parse(Console.ReadLine());
            int beats = int.Parse(Console.ReadLine());
            double bars = Math.Round((double)beats / 4,1);                     
            int mins = beats / bpm;
            int sec = (int)(((double)beats / bpm - mins) * 60);
            if (bars % 1 == 0)
            {
                Console.WriteLine($"{(int)bars} bars - {mins}m {sec}s");
            }
            else
            {
                Console.WriteLine($"{bars:f1} bars - {mins}m {sec}s");
            }

                    
                  
           
            //int bpm = int.Parse(Console.ReadLine());
            //int beats = int.Parse(Console.ReadLine());
            //
            //// Calculate sequence length
            //var sequenceLength = CalculateSequenceLength(bpm, beats);
            //
            //// Print the result with rounded bars if necessary
            //if (sequenceLength.Bars % 1 == 0)
            //{
            //    Console.WriteLine($"{(int)sequenceLength.Bars} bars - {sequenceLength.Minutes}m {sequenceLength.Seconds}s");
            //}
            //else
            //{
            //    Console.WriteLine($"{sequenceLength.Bars:f1} bars - {sequenceLength.Minutes}m {sequenceLength.Seconds}s");
            //}
        }
        //static (double Bars, int Minutes, int Seconds) CalculateSequenceLength(int bpm, int beats)
        //{
        //    double bars = Math.Round((double)beats / 4, 1);
        //    int minutes = beats / bpm;
        //    int seconds = (int)(((double)beats / bpm - minutes) * 60);
        //
        //    return (bars, minutes, seconds);
        //}
    }
}

