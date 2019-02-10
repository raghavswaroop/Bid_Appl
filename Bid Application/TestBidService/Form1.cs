using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BidServiceLib.Class;
using System.IO;

namespace TestBidService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ServiceReference2.BidServiceClient s2 = new ServiceReference2.BidServiceClient();

            var ps = s2.getProducts();
          //  List<Product> plist =  ps.Products;
            try
            {

                //foreach (Product p in plist)
                //{

                //  // Image retImage = byteArrayToImage(p.ProductImage);

                    
                //}
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
          
            

           


  
        }
    }
}
