using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Unitils;
using WebServer.ViewModels.System;

namespace WebServer.Controllers
{
    public class BaseServerController : Controller
    {
        public UserLoginViewMode user { get; set; }
        /// <summary>
        /// 执行控制器中的方法之前先执行该方法。
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            bool isSucess = false;
            if (Request.Cookies["sessionId"] != null)
            {
                string sessionId = Request.Cookies["sessionId"].Value;
              
                    
            }
            if (!isSucess)
            {
                filterContext.Result = new RedirectResult("~/Error.html");
            }
        }
    }
}