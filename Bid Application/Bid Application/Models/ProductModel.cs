using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Bid_Application.Models
{
    public class ProductModel
    {
        private int productname;

        private int productID;


        private String productDescription;


        private int productBidValue;



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




        public int ProductName
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