using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registered = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());


            
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(' ');

                string command = cmdArgs[0];
                string name = cmdArgs[1];
                

                if (command == "register")
                {
                    string licensePlate = cmdArgs[2];
                    if (!registered.ContainsKey(name))
                    {
                        registered[name] = licensePlate;
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }

                }

                else if (command == "unregister")
                {
                    if (registered.ContainsKey(name))
                    {
                        registered.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
                

            }

            foreach (var kvp in registered)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}