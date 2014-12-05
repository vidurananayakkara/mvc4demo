using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment.Demo3.VS2013
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Create", id = UrlParameter.Optional }
            );
        }
    }
}