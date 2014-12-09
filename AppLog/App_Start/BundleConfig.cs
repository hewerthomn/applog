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
                "~/Assets/Packages/jquery/jquery/dist/jquery.js",
                "~/Assets/Packages/bootstrap/bootstrap/dist/js/bootstrap.js",
                "~/Assets/Scripts/scripts.js"
            ));

            bundles.Add(new StyleBundle("~/Assets/Styles/css").Include(
                "~/Assets/Packages/bootstrap/dist/css/bootstrap.css",
                "~/Assets/Packages/font-awesome/dist/font-awesome.css",
                "~/Assets/Styles/styles.css"
            ));            
        }
    }
}
