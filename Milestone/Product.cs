using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    //product class to control aspects of product in the store
    public class Product
    {
        //Variables
        private String productname { get; set; }                
        private String productdescription { get; set; }
        private String type { get; set; }
        private double productprice { get; set; }
        protected int produtquantity { get; set; }

        //constuctor
        public Product(String productname, String productdescription, double productprice, int produtquantity)
        { 
            
            this.productname = productname;
            this.productdescription = productdescription;
            this.productprice = productprice;
            this.produtquantity = produtquantity;
        }
        //default constructor
        public Product()
        {

        }
        //Method to show product name
        public String showProdcutName()
        {
            return productname;
        }
        //Method to show product description
        public String GetProductDescription()
        {
            return productdescription;
        }
        //to get product price
        public double ShowProductPrice()
        {
            return productprice * produtquantity;
        }
        //to get product quantity
        public int ShowProductQuantity()
        {
            return produtquantity;
        }
        //to increment quantity when user selects the same product
        public void IncrementQty()
        {
            produtquantity++;
        }
    
    }
}
