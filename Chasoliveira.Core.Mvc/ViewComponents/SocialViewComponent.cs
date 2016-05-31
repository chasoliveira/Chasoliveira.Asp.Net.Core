using System.Collections.Generic;
using System.Threading.Tasks;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chasoliveira.Core.Mvc.ViewComponents
{
    public class SocialViewComponent: ViewComponent
    {
        readonly ISocialAppService _socialAppService;
        public SocialViewComponent(ISocialAppService socialAppService)
        {
            _socialAppService = socialAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personId)
        {
            var model = await GetItemsAsync(personId);
            return View(model);
        }
        private Task<IEnumerable<SocialDTO>> GetItemsAsync(int personId)
        {
            return Task.FromResult(_socialAppService.AllByPerson(personId));
        }
    }
}
