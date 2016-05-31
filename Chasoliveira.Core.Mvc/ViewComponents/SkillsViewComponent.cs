using System.Collections.Generic;
using System.Threading.Tasks;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chasoliveira.Core.Mvc.ViewComponents
{
    public class SkillsViewComponent: ViewComponent
    {
        readonly ISkillAppService _skillAppService;
        public SkillsViewComponent(ISkillAppService skillAppService)
        {
            _skillAppService = skillAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personId)
        {
            var model = await GetItemsAsync(personId);
            return View(model);
        }
        private Task<IEnumerable<SkillDTO>> GetItemsAsync(int personId)
        {
            return Task.FromResult(_skillAppService.AllByPerson(personId));
        }
    }
}
