using NSwag.AspNet.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfhostApi
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            appBuilder.UseSwaggerUi3(typeof(Startup).Assembly, setting =>
            {
                setting.GeneratorSettings.DefaultUrlTemplate = "api/{controller}/{action}/{id?}";
                setting.PostProcess = document =>
                {
                    document.Info.Title = "WebApi Sample";
                };
            });

            appBuilder.UseWebApi(config);
            config.MapHttpAttributeRoutes();
            config.EnsureInitialized();

            config.Routes.MapHttpRoute(
               name: "NotDefaultApi",
               routeTemplate: "api/{controller}/sss/{id}",
               defaults: new { id = RouteParameter.Optional }
           );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );




        }
    }
}
