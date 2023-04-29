using Microsoft.AspNetCore.Mvc;

namespace ToDoDDD.Web.Controllers
{
    public class IssuesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
