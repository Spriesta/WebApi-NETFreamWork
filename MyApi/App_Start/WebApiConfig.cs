using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MyApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "UpdateApi",
                routeTemplate: "{controller}/{action}/{id}/{name}/{age}/{from}/{gender}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
        }
    }
}
