using AppLog.Migrations;
using AppLog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AppLog
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DatabaseContext db = new DatabaseContext();
            db.Database.CreateIfNotExists();

            var initializeMigrations = new MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>();
            initializeMigrations.InitializeDatabase(db);


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
