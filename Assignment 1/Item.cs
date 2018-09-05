using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    public abstract class Item
    {
        protected Item()
        {
			type = "Defaut";
			name = "Default";
			quantity = 0;
        }

		protected Item(string n, string t)
		{
			n = name;
			t = type;
		}
        
		protected string GetItemName()
		{
			return name;
		}
		protected string GetItemType()
		{
			return type;
		}

        abstract public void Sell(string item, int amount);
        abstract public void Restock(string item, int amount);
        abstract public void CheckInfo(string item);

        public int quantity;
		public double price;
        private string name;
        private string type;
    }
}
