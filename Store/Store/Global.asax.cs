using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Store
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        
        protected void Session_Start(Object sender, EventArgs e)
        {
            
            //tomar idioma del navegador para usar archivos de recursos adecuados.
            Thread.CurrentThread.CurrentCulture = new CultureInfo(HttpContext.Current.Request.UserLanguages[0]);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(HttpContext.Current.Request.UserLanguages[0]);
        }
    }
}
