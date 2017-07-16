using System.Web.Routing;
using auction;

[assembly: WebActivator.PreApplicationStartMethod(typeof(AppStart_RestRouteRegistration), "Start")]
namespace auction
{
    public static class AppStart_RestRouteRegistration
    {
        public static void Start() {
            RouteTable.Routes.Add(new RestRoute("Products"));
        }
    }
}