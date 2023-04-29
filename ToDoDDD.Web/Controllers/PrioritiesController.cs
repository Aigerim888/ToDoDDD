using Microsoft.AspNetCore.Mvc;
using ToDoDDD.BLL.UOW;
using ToDoDDD.DAL.Entitities;
using ToDoDDD.Web.ViewModels;
using ToDoDDD.Web.ViewModels;

namespace ToDoDDD.Web.Controllers
{
    public class PrioritiesController : Controller
    {
        private readonly UnitOfWork _uow;

        public PrioritiesController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public IActionResult Index()
        {
            List<Priority> priority = _uow.PriorityRepository.Get().ToList();
            return View(priority);
        }
        public IActionResult Create()
        {
            Priority priority = new Priority();
            Status status = new Status();
            IndexViewModels ivm = new IndexViewModels
            {
                Priority=priority,
                Status=status,
                
            };
            return View();
        }
        [HttpPost]
        public IActionResult Create(Priority priority)
        {
         
            if(priority == null)
            {
                return NotFound();
            }
            priority.Id = Guid.NewGuid();
            if(ModelState.IsValid)
            {
                _uow.PriorityRepository.Insert(priority);
                _uow.Save();
                return RedirectToAction("Index");   
            }
            return View();
        }

    }
}
