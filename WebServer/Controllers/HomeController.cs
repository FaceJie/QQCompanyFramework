using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Unitils;

namespace WebServer.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                Session["aaa"].ToString();
                Unitils.LogManager.SaveMessage("123456", "xj", "zabdiajksdn", "无异常", 1);
            }
            catch (Exception ex)
            {
                Unitils.LogManager.SaveMessage("123456", "xj", "zabdiajksdn", ex.ToString(), 1);
            }
            return View();
        }
    }
}