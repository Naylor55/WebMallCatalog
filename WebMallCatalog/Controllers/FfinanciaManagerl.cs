using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMallCatalog.Controllers
{
    public class FfinanciaManagerlController : Controller
    {
        // GET: Order
        public ActionResult Budget()
        {
            return View();
        }
        public ActionResult OrderStatement()
        {
            return View();
        }
        public ActionResult BackPayment()
        {
            return View();
        }
    }
}