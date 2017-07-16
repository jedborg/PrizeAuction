using System.Web.Mvc;
using auction.Areas.CustomActionResult.Models;
using auction.Areas.CustomActionResult.Utility;

namespace auction.Areas.CustomActionResult.Controllers
{
    public class CustomActionResultController : Controller
    {
        public ActionResult Index()
        {
            var model = new Person
            {
                FirstName = "Brad",
                LastName = "Wilson",
                Blog = "http://bradwilson.typepad.com"
            };

            return new XmlResult(model);
        }
    }
}
