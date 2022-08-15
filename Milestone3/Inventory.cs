using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    internal class Inventory
    {
        private Product[] prodcutSold = new Product[10];
        private Product[] productCancled = new Product[10];
        private Product[] productsAvaliable = new Product[10];
        private Product[] shoppingCart = new Product[10];


        public Inventory()
        {
           
        }
        //method to add products to Inventory
        public void AddProduct(Product product)
        {
            for (int i = 0; i < productsAvaliable.Length; i++)
            {
                if (productsAvaliable[i] == null)
                {
                    productsAvaliable[i] = product;
                    break;
                }

            }
        }

        //method to cancel a sale
        public void CancelSale(Product product)
        {
            Product[] temp = new Product[shoppingCart.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == product)
                {
                    AddProduct(product);
                    productCancled[i] = product;
                    shoppingCart[i] = null;
                }

            }
        }
        //method to make a sale
        public void ProductSold(Product product)
        {
            //shoppingCart.Add(product);
            Product[] temp = new Product[productsAvaliable.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == product)
                {
                    shoppingCart[i] = product;
                    prodcutSold[i] = product;
                    productsAvaliable[i] = null;

                }
            }
        }
        //method to empty cart
        public void EmptyCart()
        {
            Product[] temp = new Product[shoppingCart.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                shoppingCart[i] = null;
            }
        }
        //method to that calls product sold or cancel
        public void MoveProduct(Product product, bool purchaseProduct)
        {
            Product[] listToSearch = new Product[10];
            listToSearch = purchaseProduct ? productsAvaliable : shoppingCart;

            foreach (Product p in listToSearch)
            {
                if (p.Equals(product))
                {
                    if (purchaseProduct)
                    {
                        ProductSold(p);
                        Console.WriteLine("Sold product " + p.showProdcutName());
                        break;
                    }
                    else
                    {
                        CancelSale(p);
                        Console.WriteLine("Cancled Sale " + p.showProdcutName());
                        break;

                    }
                }
            }
        }
        public Product[] GetproductsAvaliable()
        {
            //string[] productNames = new string[productsAvaliable.Length];
            //foreach (Product p in productsAvaliable)
            //{
            //    productNames[0] = p.showProdcutName();

            //}
            return productsAvaliable;
        }

        public Product[] GetCart()
        {
            return shoppingCart;
        }
    }
}
