using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApplication3.Startup))]
namespace WebApplication3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Anyconnectionorhubwireupandconfigurationshouldgohere
            app.MapSignalR();
            #region WebApi
            var httpConfig = new HttpConfiguration();
            httpConfig.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            //强制设定目前的WebApi返回格式为json
            httpConfig.Formatters.Remove(httpConfig.Formatters.XmlFormatter);
            //加载WebApi中间件
            app.UseWebApi(httpConfig);
            #endregion
        }
    }

    public class Startup2
    {
        public void Configuration(IAppBuilder app)
        {
            //Anyconnectionorhubwireupandconfigurationshouldgohere
            #region WebApi
            var httpConfig = new HttpConfiguration();
            httpConfig.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "api/{controller}/{action}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );
            //强制设定目前的WebApi返回格式为json
            httpConfig.Formatters.Remove(httpConfig.Formatters.XmlFormatter);
            //加载WebApi中间件
            app.UseWebApi(httpConfig);
            #endregion
        }
    }
}