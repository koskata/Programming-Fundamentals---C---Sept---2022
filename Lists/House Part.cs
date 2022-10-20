using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split(' ');

                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    if (list.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                    else
                    {
                        list.Add(name);
                    }
                }

                else if (cmdArgs.Length == 4)
                {
                    if (!list.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        list.Remove(name);
                    }
                }


            }

            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}