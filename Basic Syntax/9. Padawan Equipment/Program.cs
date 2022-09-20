using System;

namespace _9._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double priceForSaber = double.Parse(Console.ReadLine());
            double priceForRobe = double.Parse(Console.ReadLine());
            double priceForBelt = double.Parse(Console.ReadLine());

            double freeBelts = 0;

            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    freeBelts++;
                }
            }
            double totalMoney = (priceForSaber * (Math.Ceiling(students * 1.1))) + (priceForRobe * students) + (priceForBelt * (students - freeBelts));

            if (budget >= totalMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalMoney - budget:f2}lv more.");
            }
        }
    }
}