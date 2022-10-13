using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int smaller = Math.Min(firstList.Count, secondList.Count);
            if (smaller == firstList.Count)
            {
                for (int i = 0; i < smaller; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }

                int bigger = Math.Max(firstList.Count, secondList.Count);

                for (int i = smaller; i < bigger; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            else if(smaller == secondList.Count)
            {
                for (int i = 0; i < smaller; i++)
                {
                    result.Add(firstList[i]);
                    result.Add(secondList[i]);
                }

                int bigger = Math.Max(firstList.Count, secondList.Count);

                for (int i = smaller; i < bigger; i++)
                {
                    result.Add(firstList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}