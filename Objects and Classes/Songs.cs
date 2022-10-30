using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace _3._Songs
{
    internal class Songs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Songs> songs = new List<Songs>(); 

            for (int i = 0; i < n; i++)
            {

                string[] cmdArgs = Console.ReadLine().Split('_');
                string type = cmdArgs[0];
                string name = cmdArgs[1];
                string time = cmdArgs[2];

                Songs song = new Songs(type, name, time);

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }


        }

        

        public class Songs
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }

            public Songs(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }


        }
    }
}