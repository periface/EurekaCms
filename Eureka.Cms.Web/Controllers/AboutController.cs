using System.Web.Mvc;

namespace Eureka.Cms.Web.Controllers
{
    public class AboutController : CmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}