using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebServer.Controllers.SystemManager
{
    public class SystemManagerController : Controller
    {
        // GET: SystemManager
        public ActionResult Index()
        {
            return View();
        }
    }
}