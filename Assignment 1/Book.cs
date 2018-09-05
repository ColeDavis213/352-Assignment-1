using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Book : Item
	{ 
        public Book(string n, string g, int q) : base(n, "Book")
		{
			g = genre;
			q = quantity;
        }

        override public void Sell(string item, int amount)
        {
			if (quantity - amount >= 0)
			{
				quantity -= amount;
			}
			else if (quantity == 0)
			{
				Console.WriteLine ("Out of stock!\n");
			}
			else
			{
				Console.WriteLine("Not enough in stock!\n");
			}
			
        }

        override public void Restock(string item, int amount)
        {
			quantity += amount;
        }

        override public void CheckInfo(string item)
        {
			Console.WriteLine("Name: {0}", GetItemName());
        }

		private string genre;
    }
}
