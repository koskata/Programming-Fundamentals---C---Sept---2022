using System;

namespace _1._Day_Of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            int days = int.Parse(Console.ReadLine());

            if (days >= 1 && days <= 7)
            {
                Console.WriteLine(daysOfWeek[days - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}