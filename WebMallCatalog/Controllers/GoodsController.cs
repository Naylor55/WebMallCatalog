using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMallCatalog.Controllers
{
    public class GoodsController : Controller
    {
        // GET: Order
        public ActionResult GoodsList()
        {
            return View();
        }
        public ActionResult GoodsDetail()
        {
            return View();
        }
        public ActionResult VipCounter()
        {
            return View();
        }
    }
}