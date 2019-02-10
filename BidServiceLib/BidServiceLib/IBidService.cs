using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BidServiceLib.Class;
using System.Drawing;

namespace BidServiceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBidService" in both code and config file together.
    [ServiceContract]
    public interface IBidService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        IList<Product> getProducts();

   
    }
}
