using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusC_Unit4
{
    public class Product
    {
        //properties
        private int data = 0;
        public string Name { get; set; }
        public double Price { get; set; }
        public int CurrentQuantity { get; set; }

        public Product (string name, double price = 0, int quantity = 1)
        {
            Name = name;
            Price = price;
            CurrentQuantity = quantity;
        }

        public void AddInventory(int amount)
        {
            CurrentQuantity += amount;
        }

        public double PurchaseItem(int amount)
        {
            CurrentQuantity -= amount;
            data++;
            return amount * Price;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine($"Name: {Name}, Price:{Price}, Current Count {CurrentQuantity}");
        }


    }
}
