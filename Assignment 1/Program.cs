using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Book Test = new Book("Book", "Horror", 5, 4.60);

			Test.CheckInfo();

			Console.ReadKey();
        }
    }
}
