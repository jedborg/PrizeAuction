using System.Web.Mvc;
using auction.Areas.FluentValidation.Models;

namespace auction.Areas.FluentValidation.Controllers
{
    public class FluentValidationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            return View(contact);
        }
    }
}
