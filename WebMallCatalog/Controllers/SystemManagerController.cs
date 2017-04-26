using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMallCatalog.Controllers
{
    public class SystemManagerController : Controller
    {
        // GET: Order
        public ActionResult BaseInfo()
        {
            return View();
        }
        public ActionResult StockManager()
        {
            return View();
        }
        public ActionResult DeptManager()
        {
            return View();
        }
        public ActionResult SendMSG()
        {
            return View();
        }
    }
}