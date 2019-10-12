using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using ChickenShop;
using ChickenShop.Models;

namespace ChickenShop
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // Initialize the book database.
            Database.SetInitializer(new BookDatabaseInitializer());
        }
    }
}