using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                Random random = new Random();
                int rnd = random.Next(0, text.Length);

                string currWord = text[i];
                string nextWord = text[rnd];

                text[i] = nextWord;
                text[rnd] = currWord;

            }

            Console.WriteLine(string.Join(Environment.NewLine, text));


        }
    }
}