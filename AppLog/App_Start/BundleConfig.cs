using System.Web;
using System.Web.Optimization;

namespace AppLog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Assets/Scripts/js").Include(
                "~/Assets/Vendor/jquery/jquery/dist/jquery.js",
                "~/Assets/Vendor/bootstrap/bootstrap/dist/js/bootstrap.js",
                "~/Assets/Scripts/scripts.js"
            ));

            bundles.Add(new StyleBundle("~/Assets/Styles/css").Include(
                "~/Assets/Vendor/bootstrap/dist/css/bootstrap.css",
                "~/Assets/Vendor/font-awesome/dist/font-awesome.css",
                "~/Assets/Styles/styles.css"
            ));            
        }
    }
}
