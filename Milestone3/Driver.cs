using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    internal class Driver
    {
		public static void Main(String[] args)
		{
			Inventory store = new Inventory();

			store.AddProduct(new Product("PS5", "Console", 500.00, 1));
			store.AddProduct(new Product("XBOX", "Console", 500.00, 1));
			store.AddProduct(new Product("PC", "Console", 1400.00, 1));
			store.AddProduct(new Product("Halo", "Game", 60.00, 1));
			store.AddProduct(new Product("God Of War", "Game", 60, 1));
			store.AddProduct(new Product("Apex Lengends", "Game", 60.00, 1));
			store.AddProduct(new Product("Controller", "Periphrials", 60.00, 1));
			store.AddProduct(new Product("Mouse", "Periphrials", 80.00, 1));
			store.AddProduct(new Product("Keyboard", "Periphrials", 120.00, 1));

			while (true)
			{
				bool selling = true;

				Console.ReadLine();
				Console.WriteLine("Would you like to buy a product or cancel a sale?");
				String userAction = Console.ReadLine();
				Console.WriteLine(userAction);
				if (userAction.ToLower().Equals("buy"))
				{
					Console.WriteLine("The store has " + " " + store.GetproductsAvaliable());
					Console.WriteLine("which Prodcut?");
					selling = true;
				}
				if (userAction.ToLower().Equals("cancel"))
				{
					Console.WriteLine(store.GetCart());
					Console.WriteLine("which Product?");
					selling = false;
				}
				if (userAction.ToLower().Equals("cart"))
				{
					Console.WriteLine(store.GetCart());
				}
				if (userAction.ToLower().Equals("empty"))
				{
					store.EmptyCart();
				}
				String productname = Console.ReadLine();
                //store.MoveProduct(productname, selling);
            }
		}
	}
}
