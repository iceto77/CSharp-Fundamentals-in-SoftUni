using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity, double price)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            Price = price;
        }


        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }

        public void PrintBox()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine($"-- {Item.Name} – ${Item.Price:f2}: {ItemQuantity}");
            Console.WriteLine($"-- ${Price:f2}");
        }
    }
}
