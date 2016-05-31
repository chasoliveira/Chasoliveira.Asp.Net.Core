using Chasoliveira.Core.Application;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Chasoliveira.Core.Mvc
{
    public class Startup 
    {
        public IConfigurationRoot Configuration { get; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
            DependencyService.Register(services, ConnectionString);
            services.AddScoped<IContactAppService, ContactAppService>();
            services.AddScoped<IHistoryAppService, HistoryAppService>();
            services.AddScoped<IPersonAppService, PersonAppService>();
            services.AddScoped<ISkillAppService, SkillAppService>();
            services.AddScoped<ISocialAppService, SocialAppService>();
            services.AddScoped<ITokenAppService, TokenAppService>();
            services.AddScoped<IUserAppService, UserAppService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            DbInitializer.Initialize(app.ApplicationServices);
        }

        string ConnectionString
        {
            get
            {
                var defaultConnection = Configuration?.GetSection("AppSettings")?[nameof(ConnectionString)];
                return Configuration.GetConnectionString(defaultConnection);
            }
        }
    }
}
