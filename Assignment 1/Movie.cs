/* Author: Cole Davis
 * Date: 9/6/18
 * File: Book.cs
 * Description: A child class of the Item abstract class that defines its functions for a movie item.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Movie : Item
	{
		/*
        * Description:
        *      This is a parameterized constructor that initializes the name, type, genre, quantity, 
		*      price, and rating of a movie object.
        *
        * Inputs:
        *      string n, string g, int q, double p, string r
		*		The name, genre, quantity, price, and rating of a movie.
        *
        * Return:
        *      N/A
        */
		public Movie(string n, string g, int q, double p, string r) : base(n, "Movie")
		{
			genre = g;
			quantity = q;
			price = p;
			rating = r;
		}
		/*
        * Description:
        *      This is an overridden sell function that decreases the quantity of a movie item by the specified amount	
		*      if the quantity is not less than or equal to 0;
        *
        * Inputs:
        *      int amount
		*		The amount to sell.
        *
        * Return:
        *      N/A
        */
		override public void Sell(int amount)
		{
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
		/*
        * Description:
        *      This is an overridden restock function that increases the quantity of a movie item by the specified amount	
        *
        * Inputs:
        *      int amount
		*		The amount to sell.
        *
        * Return:
        *      N/A
        */
		override public void Restock(int amount)
		{
			if (amount > 0)
				quantity += amount;
			else
				Console.WriteLine("\nAmount needs to be larger than 0!");

			Console.WriteLine("\nStock changed to: {0}!\n", quantity);
		}
		/*
        * Description:
        *      This is an overridden printing function that prints out all the info to a movie item.
        *
        * Inputs:
        *		N/A
        *
        * Return:
        *      N/A
        */
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

