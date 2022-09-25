using System;

namespace _2_
{
    internal class Elevator
    {
        static void Main(string[] args)
        {
            short people = short.Parse(Console.ReadLine());
            short capacity = short.Parse(Console.ReadLine());

            short cources = (short)(Math.Ceiling((double)people / capacity));

            Console.WriteLine(cources);
        }
    }
}