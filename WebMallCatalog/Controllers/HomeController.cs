using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMallCatalog.Models.EFModel;

namespace WebMallCatalog.Controllers
{
    public class HomeController : Controller
    {
        WebShopEntities db = new WebShopEntities();

        // GET: Home
        public ActionResult Index()
        {
            //--viewbag
            var datauser = (from item in db.Users select item).FirstOrDefault();
            ViewBag.datauser = datauser.u_Name;

            //--viewdata
            Dictionary<string, string> stackholder = new Dictionary<string, string>();
            stackholder.Add("Client", "Mr.  Client");
            stackholder.Add("Manager", "Mr. Joy");
            stackholder.Add("Team Leader", "Mr.Toy");
            stackholder.Add("Sr. developer", "Mr.dojoy");
            stackholder.Add("developer", "Mr. nodoy");
            ViewData["stackholder"] = stackholder;

            //--model
            var data = from item in db.Goods select item;
            var model = data;
            return View(model);
        }
        public ActionResult GoodsType()
        {
            return View();
        }
        public ActionResult BranchSite()
        {
            return View();
        }

        public ActionResult GetViewData()
        {
            return View();
        }

        public string SendViewData(int Id, string Name)
        {
            return "后台已经获取到了前台传递过来的数据，编号：" + Id + "-------名称：" + Name;
        }

        [HttpPost]
        public JsonResult SendForJQAjaxRequest()
        {
            JsonResult json = new JsonResult();
            if (Request.Form.Count > 0)
            {
                int id = Convert.ToInt32(Request.Form["Id"]);
                string name = Request.Form["Name"];
                json.Data = new { result = "后台已经接受到了前台的JQAjax请求。Id=" + id + "-----name=" + name };
            }
            return json;
        }

    }
}