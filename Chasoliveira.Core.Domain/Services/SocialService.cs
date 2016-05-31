using System;
using System.Collections.Generic;
using System.Linq;
using Chasoliveira.Core.Domain.Entities;
using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;

namespace Chasoliveira.Core.Domain.Services
{
    public class SocialService : ServiceBase<Social>, ISocialService
    {
        readonly ISocialRepository _socialRepository;
        public SocialService(ISocialRepository socialRepository) : base(socialRepository)
        {
            _socialRepository = socialRepository;
        }

        public IEnumerable<Social> AllByPerson(int personId)
        {
            return _socialRepository.All(s => s.PersonId == personId).OrderBy(s => s.Ord);
        }
    }
}
