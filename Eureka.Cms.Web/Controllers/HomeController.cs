using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Eureka.Cms.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}