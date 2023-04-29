using Microsoft.AspNetCore.Mvc;
using ToDoDDD.BLL.UOW;
using ToDoDDD.DAL.Entitities;

namespace ToDoDDD.Web.Controllers
{
    public class StatusesController : Controller
    {
        private readonly UnitOfWork _uow;
        public StatusesController(UnitOfWork uow)
        {
            _uow = uow; 
        }
        public IActionResult Index()
        {
            var qwe= Guid.NewGuid().ToString();
            ViewBag.qwe = qwe;
            IEnumerable<Status> statuses = _uow.StatusRepository.Get();
            return View(statuses);
        }
    }
}
