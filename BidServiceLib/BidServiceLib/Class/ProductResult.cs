﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace BidServiceLib.Class
{
    [DataContract]
    public class ProductResult
    {
        [DataMember]
        public List<Product> Products { get; set; }
    }
}
