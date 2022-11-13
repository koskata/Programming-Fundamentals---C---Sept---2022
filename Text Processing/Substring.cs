using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Substring
{
    internal class Substring
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(keyWord);

            while (index != -1)
            {
                text = text.Remove(index, keyWord.Length);
                index = text.IndexOf(keyWord);
            }

            Console.WriteLine(text);
        }
    }
}