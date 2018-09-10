using System.Web.Http;

namespace WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
                name: "CalculatorApi",
                routeTemplate: "api/calculate",
                defaults: new { controller = "Calculator" }
            );
        }
    }
}
