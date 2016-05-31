using Chasoliveira.Core.Domain.Interfaces.Repositories;
using Chasoliveira.Core.Domain.Interfaces.Services;
using Chasoliveira.Core.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Chasoliveira.Core.Data.Repositories;

namespace Chasoliveira.Core.Application
{
    public static class DependencyService
    {
        public static void Register(IServiceCollection services, string connection)
        {
            MapperModelDTO.Initialize();
            Data.DependencyService.Register(services, connection);            
            RegisterRepository(services);
            RegisterServices(services);
        }

        static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IHistoryService, HistoryService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<ISkillService, SkillService>();
            services.AddScoped<ISocialService, SocialService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITokenService, TokenService>();
        }

        static void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IHistoryRepository, HistoryRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();
            services.AddScoped<ISocialRepository, SocialRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITokenRepository, TokenRepository>();
        }
    }
}
