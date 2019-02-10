using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BidServiceLib.Class
{
   public class Product
    {
       private String productname;

        private int productID;


        private String productDescription;


        private int productBidValue;

        private Image productImage;

        public Image ProductImage
        {
            get { return productImage; }
            set { productImage = value; }
        }


        public int ProductBidValue
        {
            get { return productBidValue; }
            set { productBidValue = value; }
        }




        public String ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }




        public String ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

        

        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

    }
    
}
