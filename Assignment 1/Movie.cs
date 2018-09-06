using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Movie : Item
	{
		public Movie(string n, string g, int q, double p, string r) : base(n, "Movie")
		{
			genre = g;
			quantity = q;
			price = p;
			rating = r;
		}

		override public void Sell()
		{
			Console.WriteLine("\nHow many would you like to buy? ");

			int amount = Convert.ToInt32(Console.ReadLine());

			if (quantity - amount >= 0)
			{
				quantity -= amount;

				Console.WriteLine("\nStock changed to: {0}!\n", quantity);
			}
			else if (quantity == 0)
			{
				Console.WriteLine("\nOut of stock!\n");
			}
			else
			{
				Console.WriteLine("\nNot enough in stock!\n");
			}
		}

		override public void Restock()
		{
			Console.WriteLine("How many would you like to restock? ");

			int amount = Convert.ToInt32(Console.ReadLine());

			quantity += amount;

			Console.WriteLine("\nStock changed to: {0}!\n", quantity);
		}

		override public void CheckInfo()
		{
			Console.WriteLine("\nType: {0}", GetItemType());
			Console.WriteLine("Name: {0}", GetItemName());
			Console.WriteLine("Genre: {0}", genre);
			Console.WriteLine("Rating: {0}", rating);
			Console.WriteLine("Price: ${0}", price);
			Console.WriteLine("Quantity: {0}\n", quantity);
		}

		private string genre;
		private string rating;
	}
}

