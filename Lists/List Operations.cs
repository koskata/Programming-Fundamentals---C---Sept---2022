using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(' ');
                string cmdType = cmdArgs[0];

                if (cmdType == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (cmdType == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index >= 0 && index < numbers.Count)
                    {
                        numbers.Insert(index, number);
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    
                }
                else if (cmdType == "Remove")
                {
                    
                    int indexToRemove = int.Parse(cmdArgs[1]);
                    if (indexToRemove < 0 || indexToRemove >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                        numbers.RemoveAt(indexToRemove);
                }

                else if (cmdType == "Shift")
                {

                    string cmdTypeB = cmdArgs[1];
                    if (cmdTypeB == "left")
                    {

                        int index = int.Parse(cmdArgs[2]);

                            for (int i = 0; i < index; i++)
                            {
                                int firstNum = numbers[0];
                                numbers.Remove(numbers[0]);
                                numbers.Add(firstNum);
                            }
                        
                    }
                    else if (cmdTypeB == "right")
                    {

                        int index = int.Parse(cmdArgs[2]);

                            for (int i = 0; i < index; i++)
                            {
                                int lastNum = numbers[numbers.Count - 1];
                                numbers.Remove(numbers[numbers.Count - 1]);
                                numbers.Insert(0, lastNum);
                            }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

    }
}