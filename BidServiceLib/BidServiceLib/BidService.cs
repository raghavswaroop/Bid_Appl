using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BidServiceLib.Class;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Reflection;
using System.Web;
using System.Data.Entity;


namespace BidServiceLib
{
    public class BidService : IBidService
    {

        // Add Exception
        // Add logging


        public void DoWork()
        {
        }


        public Image imageToByteArray(string imgPath)
        {
            try
            {

                string path = @"C:\Users\raghav\Documents\visual studio 2010\Projects\BidServiceLib\BidServiceLib\Images\W2.jpg";
                Image newImage = Image.FromFile(path);
                MemoryStream ms = new MemoryStream();
                newImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return newImage;
                
                
            }
            catch (Exception Ex)
            {
                System.Console.WriteLine(Ex.Message);
                return null;
            }
        }





       






        public IList<Product> getProducts()
        {
            
            ProductResult ps = new ProductResult();
            List<Product> pList = new List<Product>();

            IList<Product> pd =  new List<Product>(); 
           // string temp = System.Web.Hosting.HostingEnvironment.ApplicationVirtualPath;

            //string filePath = Path.Combine(HttpRuntime.AppDomainAppPath,);
            //Server.MapPath(".");
           // Image testImage = Image.FromFile(filePath);

           // var path = System.Web.HttpContext.Current.Server.MapPath(temp);
            //temp + "/" + "Images/181142-002-10-g.jpg");
         
            //Image myimage  =
          
            //string resFolder = System.IO.Path.Combine(System.Web.Forms.Application.StartupPath, "Resources");

            XmlTextReader reader = new XmlTextReader(new StringReader(BidServiceLib.Properties.Resources.ProductData));
          
            XmlDocument doc = new XmlDocument();
           
            doc.Load(new StringReader(BidServiceLib.Properties.Resources.ProductData));

            Image pdataval = BidServiceLib.Properties.Resources.F4;
             Product product = null;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                  // TODO Intialization of product is incorrect 
                product = new Product();
                string redirect = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath;
                string redirectest = VirtualPathUtility.GetDirectory(HttpContext.Current.Request.Path);
                if(node != null)
                foreach (XmlNode nodeval in node)
                //{
                    //string filePath = ;
                   // Image testImage = 
                    switch (nodeval.Name) // Hard code values have to removed
                    {
                        case "ProductID": product.ProductID = Convert.ToInt16(nodeval.InnerText);  // Null check when convert to int 
                            break;
                        case "ProductName": product.ProductName = nodeval.InnerText;
                            break;
                        case "ProductDescription": product.ProductDescription = nodeval.InnerText;
                            break;
                        case "ProductBidValue": product.ProductBidValue = Convert.ToInt16(nodeval.InnerText);
                            break;
                        case "ProductImage": product.ProductImage = imageToByteArray(Path.Combine(HttpRuntime.AppDomainAppPath, nodeval.InnerText));
                            break;
                    }
                }
                pList.Add(product);

            return pList;
            }
            //ps.Products = pList;
          
            //return pList;
      //  return pd;

        



       



    }
}
