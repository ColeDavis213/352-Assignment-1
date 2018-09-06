using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1
{
    public abstract class Item
    {
		protected Item(string n, string t)
		{
			name = n;
			type = t;
		}
        
		public string GetItemName()
		{
			return name;
		}
		public void SetItemName(string n)
		{
			name = n;
		}
		protected string GetItemType()
		{
			return type;
		}

        abstract public void Sell();
        abstract public void Restock();
        abstract public void CheckInfo();

        public int quantity;
		public double price;
        private string name;
        private string type;
    }
}
