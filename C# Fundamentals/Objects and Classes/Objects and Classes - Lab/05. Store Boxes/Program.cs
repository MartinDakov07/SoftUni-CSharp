﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string items = Console.ReadLine();
            while (items != "end")
            {
                string[] itemArg = items.Split(" ");
                string serialNum = itemArg[0];
                string itemName = itemArg[1];
                int quantity = int.Parse(itemArg[2]);
                decimal itemPrice = decimal.Parse(itemArg[3]);
                Item item = new Item(itemName,itemPrice);
                Box box = new Box(serialNum, item, quantity);
                boxes.Add(box);
                items = Console.ReadLine();
            }
            foreach(var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
        }
    }
    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set;}
        public decimal PricePerBox
        {
            get
            {
                return Quantity * Item.Price;
            }
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
}
