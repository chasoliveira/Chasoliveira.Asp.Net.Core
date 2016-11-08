using Microsoft.AspNetCore.Mvc;
using Chasoliveira.Core.Application.Interfaces;

namespace Chasoliveira.Core.Mvc.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/[controller]")]
    public class PersonController : Controller
    {
        readonly IPersonAppService _personAppService;
        public PersonController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }
        public IActionResult Index()
        {
            var person = _personAppService.FirstActive();
            return View(person);
        }
    }
}
