﻿namespace PhotoContest.App
{
    #region

    using System.Web.Mvc;
    using System.Web.Routing;

    using PhotoContest.App.Areas.Admin;

    #endregion

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                "Default", 
                "{controller}/{action}/{id}", 
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "PhotoContest.App.Controllers" });
        }
    }
}