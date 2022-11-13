using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _5._Digits__Letters_and_Others
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var nums = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (char.IsDigit(ch))
                {
                    nums.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch.ToString());
                }
                else
                {
                    other.Append(ch);
                }
            }

            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}