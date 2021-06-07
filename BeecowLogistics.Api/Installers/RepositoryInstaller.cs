using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;
using BeecowLogistics.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BeecowLogistics.Api.Installers
{
    public class RepositoryInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var connetionString = configuration.GetConnectionString("ConnStr");
            services.AddDbContext<BeecowLogisticContext>(options =>
                options.UseSqlServer(
                    connetionString,
                    o => o.MigrationsAssembly("BeecowLogistics.Services")));


            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IMapperService, MapperService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserService, UserService>();


            //services.AddScoped<ILogging, Logging>();
            //services.AddScoped<IWebHelper, WebHelper>();
        }

    }
}
