using System;
using System.Linq;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstCollection = Console.ReadLine().Split(" ");
            string[] secondCollection = Console.ReadLine().Split(" ");

            for (int k = 0; k < secondCollection.Length; k++)
            {
                for (int i = 0; i < firstCollection.Length; i++)
                {
                    if (firstCollection[i] == secondCollection[k] &&
                        firstCollection[i] != null && secondCollection[k] != null)
                    {
                        Console.Write(firstCollection[i] + " ");
                        firstCollection[i] = null;
                        secondCollection[k] = null;
                    }
                }
            }
        }
    }
}