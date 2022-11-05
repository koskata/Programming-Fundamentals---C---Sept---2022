using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Orders
{
    internal class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> products = new Dictionary<string, List<decimal>>();

            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] cmdArgs = input.Split(' ');

                string product = cmdArgs[0];
                decimal price = decimal.Parse(cmdArgs[1]); 
                decimal quantity = decimal.Parse(cmdArgs[2]);

                //decimal sum = price * quantity;

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<decimal>() { price, quantity });
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }

                //products[product] = sum;


            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}