using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc.Routing;


namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="endpointRouteBuilder">Route builder</param>
        public void RegisterRoutes(IRouteBuilder routeBuilder)
        {
            //add route for the access token callback
            //add route for the access token callback
            routeBuilder.MapRoute("CustomersDistributionByCountry", "Plugins/Tutorial/CustomerDistByCountry/",
                new { controller = "TutorialCustomersByCountry", action = "GetCustomersCountByCountry" });
        }

        /// <summary>
        /// Gets a priority of route provider
        /// </summary>
        public int Priority => 0;
    }

}
