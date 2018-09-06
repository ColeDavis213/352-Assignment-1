/* Author: Cole Davis
 * Date: 9/6/18
 * File: Item.cs
 * Description: The abstract parent class that sets up the methods and attributes to be used by all child concrete classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    public abstract class Item
    {
		/*
        * Description:
        *      This is a parameterized constructor that initializes the name and type of any item object.
        *
        * Inputs:
        *      string n, string t
		*		The variables that will have the name and type set to.
        *
        * Return:
        *      N/A
        */
		protected Item(string n, string t)
		{
			name = n;
			type = t;
		}
		/*
        * Description:
        *      This is a simple get function that retreives the name of an item object.
        * Inputs:
        *      N/A
        *
        * Return:
        *      string name
		*		The name of the object.
        */
		public string GetItemName()
		{
			return name;
		}
		/*
        * Description:
        *      This is a set function to set the name of any object.
        *
        * Inputs:
        *      string n
		*		The name of the object.
        *
        * Return:
        *      N/A
        */
		protected void SetItemName(string n)
		{
			name = n;
		}
		/*
        * Description:
        *      This is another simple get function that retreives the items type
        *
        * Inputs:
        *      N/A
        *
        * Return:
        *      type t
		*		The item's type.
        */
		protected string GetItemType()
		{
			return type;
		}
		/*
        * Description:
        *      This is an abstract sell function that can be used for any child classes
        * Inputs:
        *      int amount
		*		The amount to be taken from the item's quanitity
        *
        * Return:
        *      N/A
        */
		abstract public void Sell(int amount);
		/*
        * Description:
        *      This is an abstract restocking function that can be used for any child class
        *
        * Inputs:
        *      string amount
		*		How many to restock from the items quantity
        *
        * Return:
        *      N/A
        */
		abstract public void Restock(int amount);
		/*
        * Description:
        *      This is an abstract printing function that can be used for any child class
        *
        * Inputs:
        *      N/A
        *
        * Return:
        *      N/A
        */
		abstract public void CheckInfo();

        public int quantity;
		public double price;
        private string name;
        private string type;
    }
}
