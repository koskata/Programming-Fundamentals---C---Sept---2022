using System;
using System.Linq;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(MiddleChar(text));
        }

        static string MiddleChar(string textP)
        {
            int length = textP.Length;
            string currLetter = "";

            

            if (length % 2 == 1)
            {
                currLetter = textP[textP.Length / 2].ToString();
            }
            else
            {
                currLetter = textP[textP.Length / 2 - 1].ToString() + textP[textP.Length / 2].ToString();
            }
            

            return currLetter;
        }
    }
}