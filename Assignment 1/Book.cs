using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Book : Item
	{ 
        public Book(string n, string g, int q, double p) : base(n, "Book")
		{
			g = genre;
			q = quantity;
			p = price;
        }

        override public void Sell(string item, int amount)
        {
			Console.WriteLine("How many would you like to buy? ");
			
			amount = Convert.ToInt32(Console.ReadLine());

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
			Console.WriteLine("How many would you like to restock? ");

			amount = Convert.ToInt32(Console.ReadLine());

			quantity += amount;
        }

        override public void CheckInfo(string item)
        {
			Console.WriteLine("Type: {0}\n", GetItemType());
			Console.WriteLine("Name: {0}\n", GetItemName());
			Console.WriteLine("Genre: {0}\n", genre);
			Console.WriteLine("Price: {0}\n", price);
			Console.WriteLine("Quantity: {0}\n", quantity);
        }

		private string genre;
    }
}
