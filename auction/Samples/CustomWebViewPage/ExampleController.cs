using System.Web.Mvc;

namespace auction.Controllers {
    public class ExampleController : Controller {
        public ActionResult LayoutSample() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult LayoutSampleMissingFooter() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }
    }
}