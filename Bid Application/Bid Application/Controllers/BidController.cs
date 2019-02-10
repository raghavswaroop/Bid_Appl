using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bid_Application.Controllers
{
    public class BidController : Controller
    {
        //
        // GET: /Bid/

        public ActionResult BidView()
        {
            return View();
            
            
        }

        public ActionResult ProductView()
        {
            return View();
        }
    }
}
