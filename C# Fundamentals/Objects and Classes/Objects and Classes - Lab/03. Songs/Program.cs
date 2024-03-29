﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();
            for (int i = 0; i < numOfSongs; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Songs song = new Songs();
                song.TypeList = type;
                song.Name = name;
                song.Time = time; 

               songs.Add(song);
            }
            string typeList = Console.ReadLine();
            if(typeList == "all")
            {
                foreach(Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else 
            {
                foreach(Songs song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            
        }
    }
    public class Songs
    {

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
}
