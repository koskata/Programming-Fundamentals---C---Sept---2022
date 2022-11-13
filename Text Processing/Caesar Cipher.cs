using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _4._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var sb = new StringBuilder();

            foreach (char ch in text)
            {
                int nums = (int)ch;
                nums += 3;
                char ch2 = (char)nums;

                sb.Append(ch2);
            }

            Console.WriteLine(sb);

            //for (int i = 0; i < text.Length; i++)
            //{
            //    char ch = text[i];

            //    ch = int.Parse(text[i]);
            //}
        }
    }
}