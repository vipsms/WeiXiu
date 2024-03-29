﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             "Default",
             "",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                           name: "Apply",
                           url: "Apply/{action}/{id}",
                           defaults: new { controller = "Apply", action = "Index", id = UrlParameter.Optional }
                       );
            routes.MapRoute(
                             name: "Company",
                             url: "Company/{action}/{id}",
                             defaults: new { controller = "Company", action = "Index", id = UrlParameter.Optional }
                         );
            routes.MapRoute(
                          "Account",
                          "{id}",
                          new { controller = "Account", action = "Index", id = UrlParameter.Optional }
                      );
            routes.MapRoute(
                name: "Default3",
                url: "{id}/{controller}/{action}",
                defaults: new { controller = "Passport", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
