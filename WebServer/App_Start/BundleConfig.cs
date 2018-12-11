using System.Web;
using System.Web.Optimization;

namespace WebServer
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Resurce/frameManager/css").Include(
                        "~/Resurce/frameManager/bootstrap/css/bootstrap.css"));

            bundles.Add(new StyleBundle("~/Resurce/userManager/css").Include(
                      "~/Resurce/userManager/css/base.css",
                      "~/Resurce/userManager/css/home.css"));

            bundles.Add(new ScriptBundle("~/Resurce/frameManager/js").Include(
                       "~/Resurce/userManager/js/jquery-1.10.2.js",
                       "~/Resurce/frameManager/bootstrap/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Resurce/userManager/js").Include(
                      "~/Resurce/userManager/js/home.js"));
        }
    }
}
