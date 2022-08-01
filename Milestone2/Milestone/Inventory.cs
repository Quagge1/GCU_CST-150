using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    internal class Inventory
    {
        //vabriables
        private List<Product> productsAvaliable { get; set; }
        private List<Product> shoppingCart { get; set; }

        private List<Product> prodcutSold { get; set; }
        private List<Product> productCancled { get; set; }

        //Constructor for class
        
        public Inventory()
        {
            this.prodcutSold = new List<Product>();
            this.productCancled = new List<Product>();
            this.productsAvaliable = new List<Product>();
            this.shoppingCart = new List<Product>();
        }
        //method to add products to Inventory
        public void AddProduct(Product product)
        {        
            productsAvaliable.Add(product);
            
        }

        //method to cancel a sale
        public void CancelSale(Product product)
        {
            List<Product> temp = new List<Product>(shoppingCart);
            foreach (Product p in temp)
            {
                if (p == product)
                {
                    productCancled.Add(p);
                    shoppingCart.Remove(p);
                    productsAvaliable.Add(p);
                    
                }

            }
        }
        //method to make a sale
        public void ProductSold(Product product)
        {
            shoppingCart.Add(product);
            //List<Product> temp = new List<Product>(productsAvaliable);
            //foreach (Product p in temp)
            //{
            //    if (p == product)
            //    {
            //        shoppingCart.Add(p);
            //        prodcutSold.Add(p);
            //        productsAvaliable.Remove(p);
            //    }
            //}
        }
        //method to empty cart
        public void EmptyCart()
        {
            List<Product> temp = new List<Product>(shoppingCart);
            foreach (Product p in temp)
            {
                CancelSale(p);
            }
        }
        //method to that calls product sold or cancel
        public void MoveProduct(Product product, bool purchaseProduct)
        {      
            List<Product> listToSearch;
            listToSearch = purchaseProduct ? productsAvaliable : shoppingCart;

            foreach (Product p in listToSearch)
            {
                if (p.Equals(product))
                {
                    if (purchaseProduct)
                    {
                        ProductSold(p);
                        Console.WriteLine("Sold product " +  p.showProdcutName());   
                        break;
                    }
                    else
                    {
                        CancelSale(p);
                        Console.WriteLine("Cancled Sale " +  p.showProdcutName());   
                        break;

                    }
                }
            }
        }
        public List<Product> GetproductsAvaliable()
        {
            return productsAvaliable;
        }

        public List<Product> GetCart()
        {
            return shoppingCart;
        }
    }
}


