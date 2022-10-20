using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxValueOfWagon = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(' ');

                string commandType = cmdArgs[0];
                

                if (cmdArgs.Length == 2)
                {
                    int number = int.Parse(cmdArgs[1]);
                    listOfWagons.Add(number);
                }

                else if (cmdArgs.Length == 1)
                {
                    int number = int.Parse(cmdArgs[0]);
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + number <= maxValueOfWagon)
                        {
                            listOfWagons[i] += number;
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}