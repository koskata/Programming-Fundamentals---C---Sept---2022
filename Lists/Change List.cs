using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(' ');
                string cmdType = cmdArgs[0];

                if (cmdType == "Delete")
                {
                    int numberToDelete = int.Parse(cmdArgs[1]);

                    numbers.RemoveAll(x => x == numberToDelete);
                    
                }
                else if (cmdType == "Insert")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, numberToAdd);


                }
                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}