using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMallCatalog.Controllers
{
    public class CartController : Controller
    {

        /// <summary>
        /// Cart功能模块相关的视图
        /// </summary>
        /// <returns></returns>
        #region  VIEW
        public ActionResult Cart()
        {
            return View();
        }
        #endregion


        /// <summary>
        /// Cart功能模块相关的数据操作Contraller
        /// </summary>
        /// <returns></returns>
        #region  DataAction
        public String GetStringCart()
        {
            return "";
        }
        #endregion



    }
}