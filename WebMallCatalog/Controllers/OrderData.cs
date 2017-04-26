using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebMallCatalog.Controllers
{
    /// <summary>
    /// Order相关的数据操作Comtroller
    /// 适用于功能模块中包含较多的视图和DataAction
    /// </summary>
    public class OrderData : Controller
    {
        public string GetOrderJsonStrData()
        {
            return "";
        }
        public JsonResult GetOrderJsonData()
        {
            return null;
        }

    }
}
