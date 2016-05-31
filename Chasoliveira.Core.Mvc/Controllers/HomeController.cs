using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace chasoliveira.Mvc.Controllers
{
    public class HomeController : Controller
    {
        readonly IPersonAppService _personAppService;
        public HomeController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public IActionResult Index()
        {
            var person = _personAppService.FindOne(1) ;
            return View(person);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
