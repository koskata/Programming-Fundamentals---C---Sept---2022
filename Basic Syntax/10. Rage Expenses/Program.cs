using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceForHeadset = double.Parse(Console.ReadLine());
            double priceForMouse = double.Parse(Console.ReadLine());
            double priceForKeyboard = double.Parse(Console.ReadLine());
            double priceForDisplay = double.Parse(Console.ReadLine());

            int trashedHead = 0;
            int trashedMouse = 0;
            int trashedKey = 0;
            int trashedDis = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashedHead++;
                }
                if (i % 3 == 0)
                {
                    trashedMouse++;
                }
                if (i % 6 == 0)
                {
                    trashedKey++;
                }
                if (i % 12 == 0)
                {
                    trashedDis++;
                }
            }
            double totalSum = (trashedHead * priceForHeadset) + (trashedMouse * priceForMouse) + (trashedKey * priceForKeyboard) + (trashedDis * priceForDisplay);

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}