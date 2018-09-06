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
			Book Book1 = new Book("Welcome to Nightvale", "Mystery", 50, 20);
			Book Book2 = new Book("Breakfast of Champions", "Satire", 40, 10);

			Movie Movie1 = new Movie("Avenger: Infinity War", "Action", 300, 30, "PG-13");
			Movie Movie2 = new Movie("Alien", "Horror", 200, 10, "R");

			Video_Game Video_Game1 = new Video_Game("Super Mario Odyssey", "Adventure", 100, 60, "E", "Nintendo Switch");
			Video_Game Video_Game2 = new Video_Game("Portal", "Puzzle", 30, 20, "T", "PC");
			

			List<Item> allItems = new List<Item>{ Book1, Book2, Movie1, Movie2, Video_Game1, Video_Game2 };

			int userCommand = 0;
			int index = 0;
			int itemType = -1;
			string invName, itemName, userName, userGenre, userRating, userConsole;
			int userQuantity;
			double userPrice;

			while (userCommand != 5)
			{
				Console.WriteLine("What would you like to do?\n");

				Console.WriteLine("1. Add an Item to the database\n" +
								  "2. Restock an item\n" +
								  "3. Sell an item\n" +
								  "4. Check Item Info\n" +
								  "5. Quit\n");

				userCommand = Convert.ToInt32(Console.ReadLine());

				if (userCommand == 1)
				{
					Console.WriteLine("\nWhat type of item would you like to add?\n" +
									  "1. Book\n" +
									  "2. Movie\n" +
									  "3. Video Game");

					itemType = Convert.ToInt32(Console.ReadLine());

					if (itemType == 1)
					{
						Console.WriteLine("\nEnter the book's inventory name: ");
						invName = Console.ReadLine();
						Console.WriteLine("\nEnter the book's name: ");
						userName = Console.ReadLine();
						Console.WriteLine("\nEnter the book's genre: ");
						userGenre = Console.ReadLine();
						Console.WriteLine("\nEnter the book's quantity: ");
						userQuantity = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("\nEnter the book's price: ");
						userPrice = Convert.ToDouble(Console.ReadLine());

						allItems.Add(new Book(userName, userGenre, userQuantity, userPrice));
					}
					if (itemType == 2)
					{
						Console.WriteLine("Enter the movie's inventory name: ");
						invName = Console.ReadLine();
						Console.WriteLine("Enter the movie's name: ");
						userName = Console.ReadLine();
						Console.WriteLine("Enter the movie's genre: ");
						userGenre = Console.ReadLine();
						Console.WriteLine("Enter the movie's quantity: ");
						userQuantity = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter the movie's price: ");
						userPrice = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Enter the movie's rating: ");
						userRating = Console.ReadLine();

						allItems.Add(new Movie(userName, userGenre, userQuantity, userPrice, userRating));
					}
					if (itemType == 3)
					{
						Console.WriteLine("Enter the game's inventory name: ");
						invName = Console.ReadLine();
						Console.WriteLine("Enter the game's name: ");
						userName = Console.ReadLine();
						Console.WriteLine("Enter the game's genre: ");
						userGenre = Console.ReadLine();
						Console.WriteLine("Enter the game's quantity: ");
						userQuantity = Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter the game's price: ");
						userPrice = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Enter the game's rating: ");
						userRating = Console.ReadLine();
						Console.WriteLine("Enter the game's console: ");
						userConsole = Console.ReadLine();

						allItems.Add(new Video_Game(userName, userGenre, userQuantity, userPrice, userRating, userConsole));
					}
				}
				if (userCommand == 2)
				{
					Console.WriteLine("\nEnter an item name to restock:");
					itemName = Console.ReadLine();

					index = allItems.FindIndex(x => x.GetItemName() == itemName);

					if (index > 0)
					{
						allItems[index].Restock();
					}
					else
					{
						Console.WriteLine("\nItem does not exist!\n");
					}
				}
				if (userCommand == 3)
				{
					Console.WriteLine("\nEnter an item name to sell:");
					itemName = Console.ReadLine();

					index = allItems.FindIndex(x => x.GetItemName() == itemName);

					if (index > 0)
					{
						allItems[index].Sell();
					}
					else
					{
						Console.WriteLine("\nItem does not exist!\n");
					}
				}
				if (userCommand == 4)
				{
					Console.WriteLine("\nEnter an item name to check:");
					itemName = Console.ReadLine();

					index = allItems.FindIndex(x => x.GetItemName() == itemName);

					if (index > 0)
					{
						allItems[index].CheckInfo();
					}
					else
					{
						Console.WriteLine("\nItem does not exist!\n");
					}
				}
				if (userCommand == 5)
				{
				}
				



			}
			
		
        }
    }
}
