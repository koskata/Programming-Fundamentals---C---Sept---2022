using System;

namespace _7._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sumOfProducts = 0;

            string command = Console.ReadLine();
            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }


                command = Console.ReadLine();
            }

            double totalSum = sum;
            string products = Console.ReadLine();
            while (products != "End")
            {

                if (products == "Nuts")
                {
                    
                    sum -= 2;
                    if (sum < 0)
                    {
                        
                        Console.WriteLine("Sorry, not enough money");
                        sum += 2;
                    }
                    else
                    {
                        sumOfProducts += 2;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                    
                }
                else if (products == "Water")
                {
                    
                    sum -= 0.7;
                    if (sum < 0)
                    {
                        
                        Console.WriteLine("Sorry, not enough money");
                        sum += 0.7;
                    }
                    else
                    {
                        sumOfProducts += 0.7;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                    
                }
                else if (products == "Crisps")
                {
                    
                    sum -= 1.5;
                    if (sum < 0)
                    {

                        Console.WriteLine("Sorry, not enough money");
                        sum += 1.5;
                    }
                    else
                    {
                        sumOfProducts += 1.5;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                    
                }
                else if (products == "Soda")
                {
                    
                    sum -= 0.8;
                    if (sum < 0)
                    {
                        
                        Console.WriteLine("Sorry, not enough money");
                        sum += 0.8;
                    }
                    else
                    {
                        sumOfProducts += 0.8;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                    
                }
                else if (products == "Coke")
                {
                    
                    sum -= 1;
                    if (sum < 0)
                    {
                        
                        Console.WriteLine("Sorry, not enough money");
                        sum += 1;
                    }
                    else
                    {
                        sumOfProducts += 1;
                        Console.WriteLine($"Purchased {products.ToLower()}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                products = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum - sumOfProducts:f2}");
        }
    }
}