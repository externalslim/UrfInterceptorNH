using MSM.Helper.Mapping;
using System.Web.Http;

namespace MSM.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            /*Remove XML Formatter for JSON response*/
            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            // Web API routes
            config.MapHttpAttributeRoutes();

            //AutoMapper Initialize
            DtoMapping.Map();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
