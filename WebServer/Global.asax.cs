using System.Web.Http;
using System.Web.Routing;


using System.Web.Mvc;
using System.Web.Optimization;

namespace WebServer
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //日志
            System.IO.FileInfo fileinfo = new System.IO.FileInfo(Server.MapPath("~/App_Data/log4net.Config"));
            log4net.Config.XmlConfigurator.Configure(fileinfo);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
