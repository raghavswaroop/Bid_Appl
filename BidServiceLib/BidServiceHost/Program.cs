using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.IO;
using System.Web;


namespace BidServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //testFunc();
            
            using (ServiceHost host = new ServiceHost(typeof(BidServiceLib.BidService)))
            {
                try
                {
                    host.Open();
                    Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                    Console.ReadLine();
                }
                catch (Exception Ex)
                {

                }
            }
        }


        public static void testFunc()
        {
           // string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //BidServiceLib.BidService 
            //imageToByteArray();
        }
    }
}
