using Chasoliveira.Core.Data.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Chasoliveira.Core.Domain.Interfaces;

namespace Chasoliveira.Core.Data
{
    public class DependencyService
    {
        public static void Register(IServiceCollection services, string connection)
        {
            services.AddDbContext<ChasoDBContext>(opt =>
            opt.UseSqlite(connection, o =>
            o.MigrationsAssembly("Chasoliveira.Core.Mvc")))
                .AddEntityFrameworkSqlite();
        }
    }
}
