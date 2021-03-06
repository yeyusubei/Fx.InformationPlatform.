﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Fx.InformationPlatform.Site.Framework;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;

namespace Fx.InformationPlatform.Site
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        //public static Container Container { get; private set; }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new Fx.InformationPlatform.Site.Framework.ElmahHandledErrorLoggerFilter());
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Brower", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "Buy", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Buy", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
               "Transfer", // Route name
               "{controller}/{action}/{id}", // URL with parameters
               new { controller = "Transfer", action = "Index", id = UrlParameter.Optional } // Parameter defaults
           );



        }

        protected void Application_Start()
        {
            System.Web.Mvc.ViewEngines.Engines.Clear();
            System.Web.Mvc.ViewEngines.Engines.Add(new CsharpRazorViewEngiee());

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            if (!Fx.InformationPlatform.Site.T4Helper.IsDebug)
            {
                //new FxTask.QuartzLoadProvider().Load();
            }
        }
    }
}