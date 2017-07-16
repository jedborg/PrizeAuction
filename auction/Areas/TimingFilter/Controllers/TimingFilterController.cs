using System.Threading;
using System.Web.Mvc;
using auction.Areas.TimingFilter.Utility;

namespace auction.Areas.TimingFilter.Controllers
{
    public class TimingFilterController : Controller
    {
        [ExecutionTiming]
        public ActionResult Index()
        {
            Thread.Sleep(100);
            return View();
        }
    }
}
