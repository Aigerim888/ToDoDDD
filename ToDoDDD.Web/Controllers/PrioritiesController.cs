using Microsoft.AspNetCore.Mvc;

namespace ToDoDDD.Web.Controllers
{
    public class PrioritiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
