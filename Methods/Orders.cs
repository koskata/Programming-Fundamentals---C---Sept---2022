using System;
using System.Linq;

namespace _5._Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            GetMoney(product, quantity);

        }

        static void GetMoney(string productParameter, int quantityParameter)
        {

            double sum = 0;

            if (productParameter == "coffee")
            {
                Console.WriteLine($"{sum = 1.50 * quantityParameter:f2}");
            }
            else if (productParameter == "water")
            {
                Console.WriteLine($"{sum = 1.00 * quantityParameter:f2}");
            }
            else if (productParameter == "coke")
            {
                Console.WriteLine($"{sum = 1.40 * quantityParameter:f2}");
            }
            else if (productParameter == "snacks")
            {
                Console.WriteLine($"{sum = 2.00 * quantityParameter:f2}"); 
            }

        }
    }
}