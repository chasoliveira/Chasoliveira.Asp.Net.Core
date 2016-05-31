using System.Collections.Generic;
using System.Threading.Tasks;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chasoliveira.Core.Mvc.ViewComponents
{
    public class CoursesHistoryViewComponent : ViewComponent
    {
        readonly IHistoryAppService _historyAppService;
        public CoursesHistoryViewComponent(IHistoryAppService historyAppService)
        {
            _historyAppService = historyAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personId)
        {
            var model = await GetItemsAsync(personId);
            return View(model);
        }
        private Task<IEnumerable<HistoryDTO>> GetItemsAsync(int personId)
        {
            return Task.FromResult(_historyAppService.AllCoursesByPerson(personId));
        }
    }
}
