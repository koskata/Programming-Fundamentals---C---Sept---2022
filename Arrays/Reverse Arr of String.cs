using System;
using System.Linq;

namespace _4._Reverse_Array_Of_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();


            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}