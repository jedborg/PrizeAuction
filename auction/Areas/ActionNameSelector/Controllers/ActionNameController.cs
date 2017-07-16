using System.Web.Mvc;
using auction.Areas.ActionNameSelector.Utility;

namespace auction.Areas.ActionNameSelector.Controllers
{
    public class ActionNameController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Product]
        public ActionResult Product(int productId)
        {
            return Content("You asked for product #" + productId);
        }
    }
}
