using System.Web.Mvc;
using auction.Areas.FluentMetadata.Models;

namespace auction.Areas.FluentMetadata.Controllers
{
    public class FluentMetadataController : Controller
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
