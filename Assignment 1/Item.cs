using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public abstract class Item
    {
        public Item(string n, string t)
        {
            type = t;
            name = n;
        }
        
        abstract public void Sell(string item, int amount);
        abstract public void Restock(string item, int amount);
        abstract public void CheckInfo(string item);

        public int quantity;
        private string name;
        private string type;
    }
}
