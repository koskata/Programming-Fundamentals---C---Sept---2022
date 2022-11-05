using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!chars.ContainsKey(ch))
                    {
                        chars[ch] = 0;
                    }

                    chars[ch]++;
                }

            }


            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}