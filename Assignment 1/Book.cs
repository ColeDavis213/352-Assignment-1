/* Author: Cole Davis
 * Date: 9/6/18
 * File: Book.cs
 * Description: A child class of the Item abstract class that defines its functions for a book item.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
	public class Book : Item
	{
		/*
        * Description:
        *      This is a parameterized constructor that initializes the name, type, genre, quantity, and price of a book object.
        *
        * Inputs:
        *      string n, string g, int q, double p
		*		The name, genre, quantity, and price of a book.
        *
        * Return:
        *      N/A
        */
		public Book(string n, string g, int q, double p) : base(n, "Book")
		{
			genre = g;
			quantity = q;
			price = p;
        }
		/*
        * Description:
        *      This is an overridden sell function that decreases the quantity of a book item by the specified amount	
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
				Console.WriteLine ("\nOut of stock!\n");
			}
			else
			{
				Console.WriteLine("\nNot enough in stock!\n");
			}
		}
		/*
        * Description:
        *      This is an overridden restock function that increases the quantity of a book item by the specified amount	
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
        *      This is an overridden printing function that prints out all the info to a book item.
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
			Console.WriteLine("Price: ${0}", price);
			Console.WriteLine("Quantity: {0}\n", quantity);
        }

		private string genre;
    }
}
