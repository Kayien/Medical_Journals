using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HSMedicalJournalsDB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "UserLogin",
                url: "{controller}/{action}",
                defaults: new { controller = "User", action = "Login"}
            );

            routes.MapRoute(
                name: "Journals",
                url: "{controller}/{action}",
                defaults: new { controller = "Journal", action = "GetById", username = UrlParameter.Optional }
            );
        }
    }
}
