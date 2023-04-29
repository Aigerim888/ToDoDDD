using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ToDoDDD.BLL.UOW;
using ToDoDDD.DAL.Entitities;
using ToDoDDD.Web.ViewModels;

namespace ToDoDDD.Web.Controllers
{
    public class IssuesController : Controller
    {
        private readonly UnitOfWork _uow;
        public IssuesController(UnitOfWork uow)
        {
            _uow= uow;  
        }
        public IActionResult Index()
        {
            IEnumerable<Issue> issue = _uow.IssueRepository.Get();
            return View(issue);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Issue issue)
        {
            if(issue==null)
            {
                return NotFound();
            }
            issue.Id= Guid.NewGuid();
            if(ModelState.IsValid)
            {
                
                _uow.IssueRepository.Insert(issue);
                _uow.Save();
                return RedirectToAction("Index");
            }

            IndexViewModels ivm = new IndexViewModels();
           


            return View();  
        }
        public IActionResult Details(int id)
        {
        
           
        }
}
