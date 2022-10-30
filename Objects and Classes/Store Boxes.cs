using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Xml.Linq;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Box> list = new List<Box>();


            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(' ');

                int serialNum = int.Parse(cmdArgs[0]);
                string name = cmdArgs[1];
                int quantity = int.Parse(cmdArgs[2]);
                decimal price = decimal.Parse(cmdArgs[3]);

                Item item = new Item(name, price);

                Box box = new Box(serialNum, item, quantity);

                list.Add(box);
            }


            foreach (var box in list.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }

        public class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }

            public decimal Price { get; set; }
        }

        public class Box
        {
            public Box(int serialNumber, Item item, int itemQuantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
            }

            public int SerialNumber { get; set; }

            public Item Item { get; set; }

            public int ItemQuantity { get; set; }

            public decimal PriceForBox 
            {
                get
                {
                    return ItemQuantity * Item.Price;
                }
                 
            }
        }
    }
}