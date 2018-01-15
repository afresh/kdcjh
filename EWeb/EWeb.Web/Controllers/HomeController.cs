using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace EWeb.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : EWebControllerBase
    {
        public ActionResult Index()
        {
            return View("~/WebSites/index.html"); //Layout of the angular application.
        }
	}
}