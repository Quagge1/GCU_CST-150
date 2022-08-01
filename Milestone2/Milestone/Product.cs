using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone
{
    internal class Product
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

        public String showProdcutName()
        {
            return productname;
        }

    
    }
}
