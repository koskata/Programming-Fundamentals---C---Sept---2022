using System;
using System.Linq;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            SignOfInteger(input);
        }

        static void SignOfInteger(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive. ");
            }
            else if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative. ");
            }
            else if (input == 0)
            {
                Console.WriteLine($"The number {input} is zero. ");
            }
        }
    }
}