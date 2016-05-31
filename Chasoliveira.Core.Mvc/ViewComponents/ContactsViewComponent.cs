using System.Collections.Generic;
using System.Threading.Tasks;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Chasoliveira.Core.Mvc.ViewComponents
{
    public class ContactsViewComponent: ViewComponent
    {
        readonly IContactAppService _contactAppService;
        public ContactsViewComponent(IContactAppService contactAppService)
        {
            _contactAppService = contactAppService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int personId) {
            var model = await GetItemsAsync(personId);
            return View(model);
        }
        private Task<IEnumerable<ContactDTO>> GetItemsAsync(int personId) {
            return Task.FromResult(_contactAppService.AllByPerson(personId));
        }
    }
}
