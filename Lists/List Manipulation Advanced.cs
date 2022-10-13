using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            bool anyChanges = false;

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputA = input.Split();
                string command = inputA[0];

                if (command == "Add")
                {
                    anyChanges = true;
                    int number = int.Parse(inputA[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    anyChanges = true;
                    int removeNum = int.Parse(inputA[1]);
                    numbers.Remove(removeNum);
                }
                else if (command == "RemoveAt")
                {
                    anyChanges = true;
                    int removeIndex = int.Parse(inputA[1]);
                    numbers.RemoveAt(removeIndex);
                }
                else if(command == "Insert")
                {
                    anyChanges = true;
                    int number = int.Parse(inputA[1]);
                    int index = int.Parse(inputA[2]);
                    numbers.Insert(index, number);
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(inputA[1]);
                    numbers.Contains(number);
                    if (!numbers.Contains(number))
                    {
                        Console.WriteLine("No such number");
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                    }
                }

                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                }

                else if (command == "PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 1)));
                }

                else if (command == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }

                else if (command == "Filter")
                {
                    string sign = inputA[1];
                    int number = int.Parse(inputA[2]);

                    if (sign == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                    }
                    else if (sign == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                    }
                    else if (sign == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                    }
                    else if (sign == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                    }
                }



                input = Console.ReadLine();
            }


            if (anyChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            
        }
    }
}