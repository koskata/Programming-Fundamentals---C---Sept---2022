using System;
using System.Linq;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int counter = VowelsCounter(word);
            Console.WriteLine(counter);
        }

        static int VowelsCounter(string wordP)
        {

            wordP = wordP.ToLower();

            int counter = 0;

            foreach (char letter in wordP)
            {
                if (letter == 'a' || letter == 'o' || letter == 'y' || letter == 'e' || letter == 'u' || letter == 'i')
                {
                    counter++;
                }


            }

            return counter;
        }
    }
}