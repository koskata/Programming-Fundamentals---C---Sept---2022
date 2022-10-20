using System;
using System.Linq;
using System.Collections.Generic;

namespace _5._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> bombPower = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombPower[0])
                {
                    
                    for (int j = 1; j <= bombPower[1]; j++)
                    {
                        if (i - j < 0)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i - j] = 0;
                        }
                        
                    }

                    for (int k = 1; k <= bombPower[1]; k++)
                    {
                        if (i + k > numbers.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            numbers[i + k] = 0;
                        }
                        
                    }

                    numbers[i] = 0;
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}